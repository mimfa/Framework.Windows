using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiMFa.Controls.WinForm.ButtonPack;
using MiMFa.Service;
using MiMFa.General;
using MiMFa.Model;

namespace MiMFa.Controls.WinForm.Tab
{
    public partial class LevelViewer : TabPage
    {
        [Category]
        public SmartDictionary<int,KeyValuePair<string,Func<Form>>> Pages { get; private set; } = new SmartDictionary<int, KeyValuePair<string, Func<Form>>>();
        public SmartDictionary<int, Form> Forms { get; set; } = new SmartDictionary<int, Form>();
        public int StartPage { get; set; } = 0;
        public override bool ShowIcon
        {
            get
            {
                return base.ShowIcon;
            }

            set
            {
                base.ShowIcon = value;
                Indexers.Visible = value;
            }
        }

        public LevelViewer() :base()
        {
            InitializeComponent();
            //base.OBJECTMOR.AddControl(Indexers);
            //base.OBJECTMOR.AddControl(Buttons);
        }
        public override void Refresh()
        {
            try
            {
                foreach (var item in Pages)
                    Indexers.Items.Add(item.Key, item.Value.Key);
                Indexers.Refresh();
                PageViewer();
            }
            catch { }
            base.Refresh();
        }

        public void Add(string uniccode, Func<Form> constructor)
        {
            Pages.AddOrSet(Pages.Count,new KeyValuePair<string, Func<Form>>(uniccode,constructor));
        }
        public void AddRenge(params KeyValuePair<string, Func<Form>>[] forms)
        {
            if (forms == null) return;
            for (int i = 0; i < forms.Length; i++)
                Add(forms[i].Key, forms[i].Value);
        }

        public override void ShowPage(Func<Form> constructor, string uniccode, bool openRepeatInNewTab = false)
        {
                    ProgressRun(1);
            var ff = from v in Pages where v.Value.Key == uniccode select v.Key;
            if (ff != null && ff.Count() > 0)
                StartPage = ff.First();
            else Pages.Add( StartPage = Pages.Count, new KeyValuePair<string, Func<Form>>(uniccode, constructor));
            PageViewer();
                    ProgressRun(100);
        }
        public override void ShowPage(Form form, string uniccode, bool openRepeatInNewTab = false)
        {
                    ProgressRun(1);
            var ff = from v in Pages where v.Value.Key == uniccode select v.Key;
            if (ff != null && ff.Count() > 0)
                StartPage = ff.First();
            else Forms.Add(StartPage = Pages.Count, form);
            PageViewer();
            ProgressRun(100);
        }
        public void PageViewer()
        {
                    ProgressRun(1);
            Buttons.btn_Back.Enabled = StartPage > 0;
            Buttons.btn_Next.Enabled = StartPage < Pages.Count -1;
            if (StartPage > -1 && StartPage < Pages.Count)
            {
                Form f;
                if (Forms.TryGetValue(StartPage, out f))
                    ControlService.ShowFormIntoPanel(ref p_Main, f);
                else
                {
                    f = Pages[StartPage].Value();
                    Forms.AddOrSet(StartPage,f );
                    ControlService.ShowFormIntoPanel(ref p_Main, f);
                }
                var ba = ConvertService.ToButtonAction(f.Tag);
                Buttons.SetButtons(ba);
                Indexers.CurrentIndex(StartPage);
            }
            else StartPage = -1;
                    ProgressRun(100);
        }

        public void OnBackAction(object sender, EventArgs e)
        {
            StartPage--;
            Indexers.NotDoneIndex(StartPage + 1);
            PageViewer();
        }
        public void OnNextAction(object sender, EventArgs e)
        {
            StartPage++;
            Indexers.DoneIndex(StartPage-1);
            PageViewer();
        }
    }
}
