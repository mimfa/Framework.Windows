using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MiMFa.Service;
using System.Windows.Forms.Design.Behavior;
using MiMFa.Graphic;

namespace MiMFa.Controls.WinForm.Tools
{

    //[DesignerAttribute(typeof(ButtonDesigner))]
    [DefaultEventAttribute("Click")]
    public class Button : Tools
    {
        #region Field

        public ToolStrip TargetToolStrip = null;
        public Control TargetControl = null;
        public event EventHandler Target = (o,a)=> { };
        public event EventHandler DesignClick = (o,a)=> { };

        protected PictureBox ImageBox = new PictureBox();
        protected Label LabelBox = new System.Windows.Forms.Label();

        private bool _InvertImage= false;
        private bool _ThisSelected = false;
        private BorderStyle prevBS;

        #endregion

        #region Property
        [CategoryAttribute()]

        public virtual bool ThisSelected
        {
            get { return _ThisSelected; }
            set { _ThisSelected = value; }
        }

        public virtual Highlight.Mode HoverEffect
        {
            get { return HILIGHT.HilightMode; }
            set { HILIGHT.HilightMode = value; }
        }
        public virtual Color HoverBackColor
        {
            get { return HILIGHT.HilightBackColor; }
            set { HILIGHT.HilightBackColor = value; }
        }
        public virtual Color HoverForeColor
        {
            get { return HILIGHT.HilightForeColor; }
            set { HILIGHT.HilightForeColor = value; }
        }
        public virtual Image HoverImage
        {
            get { return HILIGHT.HilightBackImage; }
            set { HILIGHT.HilightBackImage = value; }
        }
        public virtual BorderStyle HoverBorderStyle
        {
            get { return HILIGHT.HilightBorderStyle; }
            set { HILIGHT.HilightBorderStyle = value; }
        }
        public virtual string Label
        {
            get { return LabelBox.Text; }
            set
            {
                LabelBox.Text = value;
            }
        }
        public virtual ContentAlignment LabelAlign
        {
            get { return LabelBox.TextAlign; }
            set
            {
                LabelBox.TextAlign = value;
            }
        }
        public virtual bool ShowLabel
        {
            get { return LabelBox.Visible; }
            set
            {
                LabelBox.Visible = value;
            }
        }
        public virtual Image Image
        {
            get { return ImageBox.Image; }
            set
            {
                ImageBox.Image = value;
                ImageInvert();
            }
        }
        public virtual bool ShowImage
        {
            get { return ImageBox.Visible; }
            set
            {
                ImageBox.Visible = value;
            }
        }
        public virtual PictureBoxSizeMode ImageLayout
        {
            get { return ImageBox.SizeMode; }
            set
            {
                ImageBox.SizeMode = value;
            }
        }
        public virtual Padding ImagePadding
        {
            get { return ImageBox.Margin; }
            set
            {
                ImageBox.Margin = value;
            }
        }
        public virtual bool InvertImage
        {
            get { return _InvertImage; }
            set
            {
                this._InvertImage = value;
                ImageInvert();
            }
        }
        #endregion

        #region Function

        public Button() : base()
        {
        }
        public virtual void DesignAction() { DesignClick(this, EventArgs.Empty); }
        public virtual bool SetOnlyThisSelected(bool set = true)
        {
            if (set)
                foreach (dynamic item in this.Parent.Controls)
                    try { item.ThisSelected = false; } catch { }
            return _ThisSelected = set;
        }
        public virtual void ImageInvert()
        {
            if (this._InvertImage)
            {
                ImageBox.Image = (new Graphic.ProcessImage()).Invert((Bitmap)ImageBox.Image);
                _InvertImage = false;
            }
        }
        public virtual void PerformClick()
        {
            OnClick(EventArgs.Empty);
        }

        #endregion

        #region Target
        protected virtual void Action_Click(object sender, EventArgs e)
        {
            Target(sender,e);
        }
        protected virtual void This_MouseDown(object sender, MouseEventArgs e)
        {
            prevBS = BorderStyle;
            BorderStyle = HoverBorderStyle;
        }
        protected virtual void This_MouseUp(object sender, MouseEventArgs e)
        {
           BorderStyle = prevBS;
        }
        #endregion

    }

    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ButtonDesigner : System.Windows.Forms.Design.ControlDesigner
    {
        DesignActionGlyph myGlyph = null;
        Adorner myAdorner;

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            // Add the custom set of glyphs using the BehaviorService. 
            // Glyphs live on adornders.
            myAdorner = new Adorner();
            BehaviorService.Adorners.Add(myAdorner);
            myGlyph = new DesignActionGlyph(BehaviorService, Control);
            myGlyph.Callback = () =>
            {
                ((Button)this.Control).DesignAction();
            };
            myAdorner.Glyphs.Add(myGlyph);
        }

        class DesignActionGlyph : Glyph
        {
            Control control;
            BehaviorService behaviorSvc;

            public Action Callback
            {
                get;
                set;
            }

            public DesignActionGlyph(BehaviorService behaviorSvc, Control control) : base(new DesignActionBehavior())
            {
                this.behaviorSvc = behaviorSvc;
                this.control = control;
            }

            public override Rectangle Bounds
            {
                get
                {
                    // Create a glyph that is 10x10 and sitting
                    // in the middle of the control.  Glyph coordinates
                    // are in adorner window coordinates, so we must map
                    // using the behavior service.
                    Point edge = behaviorSvc.ControlToAdornerWindow(control);
                    Rectangle bounds = new Rectangle(
                        edge.X,
                        edge.Y,
                        10,
                        10);
                    return bounds;
                }
            }

            public override Cursor GetHitTest(Point p)
            {
                // GetHitTest is called to see if the point is
                // within this glyph.  This gives us a chance to decide
                // what cursor to show.  Returning null from here means
                // the mouse pointer is not currently inside of the glyph.
                // Returning a valid cursor here indicates the pointer is
                // inside the glyph, and also enables our Behavior property
                // as the active behavior.
                if (Bounds.Contains(p)) return Cursors.Hand;
                return null;
            }

            public override void Paint(PaintEventArgs pe)
            {
                // Draw our glyph. It is simply a blue ellipse.
                pe.Graphics.DrawEllipse(Pens.Blue, Bounds);
            }

            // By providing our own behavior we can do something interesting
            // when the user clicks or manipulates our glyph.
            class DesignActionBehavior : Behavior
            {
                public override bool OnMouseUp(Glyph g, MouseButtons button)
                {
                    //MessageBox.Show("Hey, you clicked the mouse here");
                    //this.
                    DesignActionGlyph myG = (DesignActionGlyph)g;
                    if (myG.Callback != null)
                    {
                        myG.Callback();
                    }
                    return true; // indicating we processed this event.
                }
            }
        }
    }
}
