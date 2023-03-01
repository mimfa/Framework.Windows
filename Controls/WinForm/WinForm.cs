using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MiMFa.Controls.WinForm.Tools;
using MiMFa.Service;
using MiMFa.General;
using MiMFa.Exclusive.Animate;
using MiMFa.Engine;
using MiMFa.Model;
using System.ComponentModel;
using System.ComponentModel.Design;
using MiMFa.Graphic;

namespace MiMFa.Controls.WinForm
{
    [DefaultEventAttribute("ValueChanged")]
    //[Designer(typeof(System.Windows.Forms.Design.ControlDesigner), typeof(IDesigner))]
    public class WinForm : UserControl
    {
        #region Field

        protected SimplySlider SIMPLYSLIDER = new SimplySlider(5);
        protected FormMove FORMMOVE = new  FormMove();
        protected ObjectMoveOrResize OBJECTMOR = new ObjectMoveOrResize();
        protected Highlight HILIGHT = new Highlight( MiMFa.Properties.Resources.Hover, false);
        protected ToolTip TOOLTIP = new ToolTip();

        private bool _InvertColor = false;
        private bool _LockState = false;

        #endregion

        #region Property
        [CategoryAttribute()]
        [DefaultValue((Control)null)]
        public Control RelatedControl { get; set; } = null;
        public virtual string TempDirectory
        {
            get
            {
            if (this.DesignMode) return "";
                string str = "";
                try
                {
                    str = Config.TemporaryDirectory + this.GetType().Name + "\\";
                    PathService.CreateAllDirectories(str);
                }
                catch {
                    str = Config.ApplicationDirectory  + "Temp\\" + this.GetType().Name + "\\";
                    PathService.CreateAllDirectories(str);
                }
                return str;
            }
        }
        public virtual bool InvertColor
        {
            get { return _InvertColor; }
            set
            {
                if ((this._InvertColor = value)) this.ForeColor = MiMFa.Graphic.Coloristic.InvertColor(this.BackColor);
            }
        }
        //public virtual IEnumerable<Control> Entities => MiMFa_Framework.Service.MiMFa_ControlService.GetAllChildControls(this);
        public virtual bool LockState
        {
            get { return _LockState; }
            set
            {
                _LockState = value;
            }
        }

        #endregion

        #region Function

        public WinForm()
        {
        }

        protected virtual void SetAllEventParentToControls()
        {
            if (this.DesignMode) return;
            var childs = ControlService.GetFinalControls(this,3).ToList();
            if (childs != null)
                for (int i = 0; i < childs.Count; i++)
                {
                    Control child = childs[i];
                    child.Click += new EventHandler((object sender, EventArgs e) => { this.OnClick(e); });
                    child.DoubleClick += new EventHandler((object sender, EventArgs e) => { this.OnDoubleClick(e); });
                    child.MouseDoubleClick += new MouseEventHandler((object sender, MouseEventArgs e) => { this.OnMouseDoubleClick(e); });
                    child.MouseDown += new MouseEventHandler((object sender, MouseEventArgs e) => { this.OnMouseDown(e); });
                    child.MouseUp += new MouseEventHandler((object sender, MouseEventArgs e) => { this.OnMouseUp(e); });
                    child.MouseMove += new MouseEventHandler((object sender, MouseEventArgs e) => { this.OnMouseMove(e); });
                    child.MouseEnter += new EventHandler((object sender, EventArgs e) => { this.OnMouseEnter(e); });
                    child.MouseLeave += new EventHandler((object sender, EventArgs e) => { this.OnMouseLeave(e); });
                    child.MouseHover += new EventHandler((object sender, EventArgs e) => { this.OnMouseHover(e); });
                    child.MouseWheel += new MouseEventHandler((object sender, MouseEventArgs e) => { this.OnMouseWheel(e); });
                }
        }

        #endregion

        #region Target

        protected virtual void FormMove_MouseDown(object sender, MouseEventArgs e)
        {
            FORMMOVE.MouseDragedDown(sender, e);
        }
        protected virtual void FormMove_MouseLeave(object sender, EventArgs e)
        {
            FORMMOVE.MouseDragedLeave(sender, e);
        }
        protected virtual void FormMove_MouseMove(object sender, MouseEventArgs e)
        {
            FORMMOVE.MouseDragedMove(sender, e);
        }
        protected virtual void FormMove_MouseUp(object sender, MouseEventArgs e)
        {
            FORMMOVE.MouseDragedUp(sender, e);
        }

        protected virtual void Hilight_MouseEnter(object sender, EventArgs e)
        {
            HILIGHT.MouseEnter(sender, e);
        }
        protected virtual void Hilight_MouseLeave(object sender, EventArgs e)
        {
            HILIGHT.MouseLeave(sender, e);
        }
        protected virtual void Hilight_This_MouseEnter(object sender, EventArgs e)
        {
            HILIGHT.MouseEnter((UserControl)(sender??this));
        }
        protected virtual void Hilight_This_MouseLeave(object sender, EventArgs e)
        {
            HILIGHT.MouseLeave((UserControl)(sender ?? this));
        }
        #endregion

    }
}
