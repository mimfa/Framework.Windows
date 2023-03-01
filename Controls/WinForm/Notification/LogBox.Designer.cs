namespace MiMFa.Controls.WinForm.Notification
{
    partial class LogBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PB = new System.Windows.Forms.ProgressBar();
            this.MainStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddb_Scripting_Log = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_Scripting_ActiveNotice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Scripting_ActiveLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Scripting_ActiveBeep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ActiveDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.forSubjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forSuccessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forWarningsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forErrorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_FinalDuties = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_Scripting_Final_S = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Scripting_Final_H = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Scripting_Final_LA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Scripting_Final_Off = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Scripting_Final_RB = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Scripting_Final_CP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Save = new System.Windows.Forms.ToolStripButton();
            this.tsb_Open = new System.Windows.Forms.ToolStripButton();
            this.tsb_Print = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_ZI = new System.Windows.Forms.ToolStripButton();
            this.tsb_ZO = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Copy = new System.Windows.Forms.ToolStripButton();
            this.tsb_Cut = new System.Windows.Forms.ToolStripButton();
            this.tsb_Paste = new System.Windows.Forms.ToolStripButton();
            this.tsl_MaxLines = new System.Windows.Forms.ToolStripLabel();
            this.tscb_MaxLines = new System.Windows.Forms.ToolStripComboBox();
            this.tsb_Clear = new System.Windows.Forms.ToolStripButton();
            this.tsl_Warning = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Error = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Success = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Message = new System.Windows.Forms.ToolStripLabel();
            this.RTB = new System.Windows.Forms.RichTextBox();
            this.ContextStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WaitBar = new System.Windows.Forms.PictureBox();
            this.NotificationBox = new System.Windows.Forms.Label();
            this.MainStripMenu.SuspendLayout();
            this.ContextStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PB
            // 
            this.PB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PB.ForeColor = System.Drawing.Color.Black;
            this.PB.Location = new System.Drawing.Point(0, 329);
            this.PB.Margin = new System.Windows.Forms.Padding(0);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(738, 2);
            this.PB.TabIndex = 27;
            this.PB.Visible = false;
            // 
            // MainStripMenu
            // 
            this.MainStripMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.tsddb_Scripting_Log,
            this.tsmi_FinalDuties,
            this.toolStripSeparator10,
            this.tsb_Save,
            this.tsb_Open,
            this.tsb_Print,
            this.toolStripSeparator1,
            this.tsb_ZI,
            this.tsb_ZO,
            this.toolStripSeparator11,
            this.tsb_Copy,
            this.tsb_Cut,
            this.tsb_Paste,
            this.tsl_MaxLines,
            this.tscb_MaxLines,
            this.tsb_Clear,
            this.tsl_Warning,
            this.tsl_Error,
            this.tsl_Success,
            this.tsl_Message});
            this.MainStripMenu.Location = new System.Drawing.Point(0, 0);
            this.MainStripMenu.Name = "MainStripMenu";
            this.MainStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainStripMenu.Size = new System.Drawing.Size(738, 33);
            this.MainStripMenu.TabIndex = 29;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoToolTip = false;
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem1});
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(39, 29);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "Clear";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.tsb_Clear_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.tsb_Open_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.tsb_Save_Click);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.printToolStripMenuItem1.Text = "Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.tsb_Print_Click);
            // 
            // tsddb_Scripting_Log
            // 
            this.tsddb_Scripting_Log.AutoToolTip = false;
            this.tsddb_Scripting_Log.BackColor = System.Drawing.Color.Transparent;
            this.tsddb_Scripting_Log.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddb_Scripting_Log.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Scripting_ActiveNotice,
            this.tsmi_Scripting_ActiveLog,
            this.tsmi_Scripting_ActiveBeep,
            this.tsmi_ActiveDialog});
            this.tsddb_Scripting_Log.Margin = new System.Windows.Forms.Padding(2);
            this.tsddb_Scripting_Log.Name = "tsddb_Scripting_Log";
            this.tsddb_Scripting_Log.Padding = new System.Windows.Forms.Padding(5);
            this.tsddb_Scripting_Log.ShowDropDownArrow = false;
            this.tsddb_Scripting_Log.Size = new System.Drawing.Size(41, 29);
            this.tsddb_Scripting_Log.Text = "Log";
            // 
            // tsmi_Scripting_ActiveNotice
            // 
            this.tsmi_Scripting_ActiveNotice.Checked = true;
            this.tsmi_Scripting_ActiveNotice.CheckOnClick = true;
            this.tsmi_Scripting_ActiveNotice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_Scripting_ActiveNotice.Name = "tsmi_Scripting_ActiveNotice";
            this.tsmi_Scripting_ActiveNotice.Size = new System.Drawing.Size(109, 22);
            this.tsmi_Scripting_ActiveNotice.Text = "Notice";
            this.tsmi_Scripting_ActiveNotice.CheckedChanged += new System.EventHandler(this.tsmi_Scripting_ActiveNotice_CheckedChanged);
            // 
            // tsmi_Scripting_ActiveLog
            // 
            this.tsmi_Scripting_ActiveLog.Checked = true;
            this.tsmi_Scripting_ActiveLog.CheckOnClick = true;
            this.tsmi_Scripting_ActiveLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_Scripting_ActiveLog.Name = "tsmi_Scripting_ActiveLog";
            this.tsmi_Scripting_ActiveLog.Size = new System.Drawing.Size(109, 22);
            this.tsmi_Scripting_ActiveLog.Text = "Logs";
            this.tsmi_Scripting_ActiveLog.CheckedChanged += new System.EventHandler(this.tsmi_Scripting_ActiveLog_CheckedChanged);
            // 
            // tsmi_Scripting_ActiveBeep
            // 
            this.tsmi_Scripting_ActiveBeep.CheckOnClick = true;
            this.tsmi_Scripting_ActiveBeep.Name = "tsmi_Scripting_ActiveBeep";
            this.tsmi_Scripting_ActiveBeep.Size = new System.Drawing.Size(109, 22);
            this.tsmi_Scripting_ActiveBeep.Text = "Beep";
            this.tsmi_Scripting_ActiveBeep.CheckedChanged += new System.EventHandler(this.tsmi_Scripting_ActiveBeep_CheckedChanged);
            // 
            // tsmi_ActiveDialog
            // 
            this.tsmi_ActiveDialog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forSubjectsToolStripMenuItem,
            this.forMessagesToolStripMenuItem,
            this.forSuccessesToolStripMenuItem,
            this.forWarningsToolStripMenuItem,
            this.forErrorsToolStripMenuItem});
            this.tsmi_ActiveDialog.Name = "tsmi_ActiveDialog";
            this.tsmi_ActiveDialog.Size = new System.Drawing.Size(109, 22);
            this.tsmi_ActiveDialog.Text = "Dialog";
            this.tsmi_ActiveDialog.ToolTipText = "Dialog with Supervisor";
            // 
            // forSubjectsToolStripMenuItem
            // 
            this.forSubjectsToolStripMenuItem.CheckOnClick = true;
            this.forSubjectsToolStripMenuItem.Name = "forSubjectsToolStripMenuItem";
            this.forSubjectsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.forSubjectsToolStripMenuItem.Text = "For Subjects";
            this.forSubjectsToolStripMenuItem.ToolTipText = "Dialog with Supervisor";
            this.forSubjectsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.forSubjectsToolStripMenuItem_CheckedChanged);
            // 
            // forMessagesToolStripMenuItem
            // 
            this.forMessagesToolStripMenuItem.CheckOnClick = true;
            this.forMessagesToolStripMenuItem.Name = "forMessagesToolStripMenuItem";
            this.forMessagesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.forMessagesToolStripMenuItem.Text = "For Messages";
            this.forMessagesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.forMessagesToolStripMenuItem_CheckedChanged);
            // 
            // forSuccessesToolStripMenuItem
            // 
            this.forSuccessesToolStripMenuItem.CheckOnClick = true;
            this.forSuccessesToolStripMenuItem.Name = "forSuccessesToolStripMenuItem";
            this.forSuccessesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.forSuccessesToolStripMenuItem.Text = "For Successes";
            this.forSuccessesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.forSuccessesToolStripMenuItem_CheckedChanged);
            // 
            // forWarningsToolStripMenuItem
            // 
            this.forWarningsToolStripMenuItem.CheckOnClick = true;
            this.forWarningsToolStripMenuItem.Name = "forWarningsToolStripMenuItem";
            this.forWarningsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.forWarningsToolStripMenuItem.Text = "For Warnings";
            this.forWarningsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.forWarningsToolStripMenuItem_CheckedChanged);
            // 
            // forErrorsToolStripMenuItem
            // 
            this.forErrorsToolStripMenuItem.CheckOnClick = true;
            this.forErrorsToolStripMenuItem.Name = "forErrorsToolStripMenuItem";
            this.forErrorsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.forErrorsToolStripMenuItem.Text = "For Errors";
            this.forErrorsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.forErrorsToolStripMenuItem_CheckedChanged);
            // 
            // tsmi_FinalDuties
            // 
            this.tsmi_FinalDuties.AutoToolTip = false;
            this.tsmi_FinalDuties.BackColor = System.Drawing.Color.Transparent;
            this.tsmi_FinalDuties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmi_FinalDuties.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Scripting_Final_S,
            this.tsmi_Scripting_Final_H,
            this.tsmi_Scripting_Final_LA,
            this.tsmi_Scripting_Final_Off,
            this.tsmi_Scripting_Final_RB,
            this.tsmi_Scripting_Final_CP});
            this.tsmi_FinalDuties.Margin = new System.Windows.Forms.Padding(2);
            this.tsmi_FinalDuties.Name = "tsmi_FinalDuties";
            this.tsmi_FinalDuties.Padding = new System.Windows.Forms.Padding(5);
            this.tsmi_FinalDuties.ShowDropDownArrow = false;
            this.tsmi_FinalDuties.Size = new System.Drawing.Size(82, 29);
            this.tsmi_FinalDuties.Text = "Final Duties";
            // 
            // tsmi_Scripting_Final_S
            // 
            this.tsmi_Scripting_Final_S.CheckOnClick = true;
            this.tsmi_Scripting_Final_S.Name = "tsmi_Scripting_Final_S";
            this.tsmi_Scripting_Final_S.Size = new System.Drawing.Size(186, 22);
            this.tsmi_Scripting_Final_S.Text = "Sleep Computer";
            // 
            // tsmi_Scripting_Final_H
            // 
            this.tsmi_Scripting_Final_H.CheckOnClick = true;
            this.tsmi_Scripting_Final_H.Name = "tsmi_Scripting_Final_H";
            this.tsmi_Scripting_Final_H.Size = new System.Drawing.Size(186, 22);
            this.tsmi_Scripting_Final_H.Text = "Hibernate Computer";
            // 
            // tsmi_Scripting_Final_LA
            // 
            this.tsmi_Scripting_Final_LA.CheckOnClick = true;
            this.tsmi_Scripting_Final_LA.Name = "tsmi_Scripting_Final_LA";
            this.tsmi_Scripting_Final_LA.Size = new System.Drawing.Size(186, 22);
            this.tsmi_Scripting_Final_LA.Text = "Logoff Computer";
            // 
            // tsmi_Scripting_Final_Off
            // 
            this.tsmi_Scripting_Final_Off.CheckOnClick = true;
            this.tsmi_Scripting_Final_Off.Name = "tsmi_Scripting_Final_Off";
            this.tsmi_Scripting_Final_Off.Size = new System.Drawing.Size(186, 22);
            this.tsmi_Scripting_Final_Off.Text = "ShutDown Computer";
            // 
            // tsmi_Scripting_Final_RB
            // 
            this.tsmi_Scripting_Final_RB.CheckOnClick = true;
            this.tsmi_Scripting_Final_RB.Name = "tsmi_Scripting_Final_RB";
            this.tsmi_Scripting_Final_RB.Size = new System.Drawing.Size(186, 22);
            this.tsmi_Scripting_Final_RB.Text = "Reboot Computer";
            // 
            // tsmi_Scripting_Final_CP
            // 
            this.tsmi_Scripting_Final_CP.CheckOnClick = true;
            this.tsmi_Scripting_Final_CP.Name = "tsmi_Scripting_Final_CP";
            this.tsmi_Scripting_Final_CP.Size = new System.Drawing.Size(186, 22);
            this.tsmi_Scripting_Final_CP.Text = "Close Program";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 33);
            // 
            // tsb_Save
            // 
            this.tsb_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Save.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsb_Save.Margin = new System.Windows.Forms.Padding(2);
            this.tsb_Save.Name = "tsb_Save";
            this.tsb_Save.Padding = new System.Windows.Forms.Padding(1);
            this.tsb_Save.Size = new System.Drawing.Size(37, 29);
            this.tsb_Save.Text = "💾";
            this.tsb_Save.ToolTipText = "Save";
            this.tsb_Save.Click += new System.EventHandler(this.tsb_Save_Click);
            // 
            // tsb_Open
            // 
            this.tsb_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Open.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsb_Open.Margin = new System.Windows.Forms.Padding(2);
            this.tsb_Open.Name = "tsb_Open";
            this.tsb_Open.Padding = new System.Windows.Forms.Padding(1);
            this.tsb_Open.Size = new System.Drawing.Size(37, 29);
            this.tsb_Open.Text = "📁";
            this.tsb_Open.ToolTipText = "Open";
            this.tsb_Open.Click += new System.EventHandler(this.tsb_Open_Click);
            // 
            // tsb_Print
            // 
            this.tsb_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Print.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsb_Print.Margin = new System.Windows.Forms.Padding(2);
            this.tsb_Print.Name = "tsb_Print";
            this.tsb_Print.Padding = new System.Windows.Forms.Padding(1);
            this.tsb_Print.Size = new System.Drawing.Size(31, 29);
            this.tsb_Print.Text = "⎙";
            this.tsb_Print.ToolTipText = "Print";
            this.tsb_Print.Click += new System.EventHandler(this.tsb_Print_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // tsb_ZI
            // 
            this.tsb_ZI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_ZI.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsb_ZI.Margin = new System.Windows.Forms.Padding(2);
            this.tsb_ZI.Name = "tsb_ZI";
            this.tsb_ZI.Padding = new System.Windows.Forms.Padding(1);
            this.tsb_ZI.Size = new System.Drawing.Size(27, 29);
            this.tsb_ZI.Text = "+";
            this.tsb_ZI.ToolTipText = "Zoom In (Ctrl+[+])";
            this.tsb_ZI.Click += new System.EventHandler(this.tsb_ZI_Click);
            // 
            // tsb_ZO
            // 
            this.tsb_ZO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_ZO.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsb_ZO.Margin = new System.Windows.Forms.Padding(2);
            this.tsb_ZO.Name = "tsb_ZO";
            this.tsb_ZO.Padding = new System.Windows.Forms.Padding(1);
            this.tsb_ZO.Size = new System.Drawing.Size(23, 29);
            this.tsb_ZO.Text = "-";
            this.tsb_ZO.ToolTipText = "Zoom Out (Ctrl+[-])";
            this.tsb_ZO.Click += new System.EventHandler(this.tsb_ZO_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 33);
            // 
            // tsb_Copy
            // 
            this.tsb_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Copy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsb_Copy.Margin = new System.Windows.Forms.Padding(2);
            this.tsb_Copy.Name = "tsb_Copy";
            this.tsb_Copy.Padding = new System.Windows.Forms.Padding(1);
            this.tsb_Copy.Size = new System.Drawing.Size(26, 29);
            this.tsb_Copy.Text = "C";
            this.tsb_Copy.ToolTipText = "Copy";
            this.tsb_Copy.Click += new System.EventHandler(this.tsb_Copy_Click);
            // 
            // tsb_Cut
            // 
            this.tsb_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Cut.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsb_Cut.Margin = new System.Windows.Forms.Padding(2);
            this.tsb_Cut.Name = "tsb_Cut";
            this.tsb_Cut.Padding = new System.Windows.Forms.Padding(1);
            this.tsb_Cut.Size = new System.Drawing.Size(25, 29);
            this.tsb_Cut.Text = "X";
            this.tsb_Cut.ToolTipText = "Cut";
            this.tsb_Cut.Click += new System.EventHandler(this.tsb_Cut_Click);
            // 
            // tsb_Paste
            // 
            this.tsb_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Paste.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsb_Paste.Margin = new System.Windows.Forms.Padding(2);
            this.tsb_Paste.Name = "tsb_Paste";
            this.tsb_Paste.Padding = new System.Windows.Forms.Padding(1);
            this.tsb_Paste.Size = new System.Drawing.Size(26, 29);
            this.tsb_Paste.Text = "V";
            this.tsb_Paste.ToolTipText = "Paste";
            this.tsb_Paste.Click += new System.EventHandler(this.tsb_Paste_Click);
            // 
            // tsl_MaxLines
            // 
            this.tsl_MaxLines.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsl_MaxLines.Name = "tsl_MaxLines";
            this.tsl_MaxLines.Size = new System.Drawing.Size(55, 30);
            this.tsl_MaxLines.Text = "500 Lines";
            this.tsl_MaxLines.Click += new System.EventHandler(this.tsl_MaxLines_Click);
            // 
            // tscb_MaxLines
            // 
            this.tscb_MaxLines.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscb_MaxLines.Items.AddRange(new object[] {
            "50",
            "100",
            "500",
            "1000",
            "5000",
            "10000"});
            this.tscb_MaxLines.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tscb_MaxLines.Name = "tscb_MaxLines";
            this.tscb_MaxLines.Size = new System.Drawing.Size(75, 33);
            this.tscb_MaxLines.Text = "500";
            this.tscb_MaxLines.Visible = false;
            this.tscb_MaxLines.TextChanged += new System.EventHandler(this.tscb_MaxLines_TextChanged);
            // 
            // tsb_Clear
            // 
            this.tsb_Clear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Clear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsb_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.tsb_Clear.Name = "tsb_Clear";
            this.tsb_Clear.Padding = new System.Windows.Forms.Padding(1);
            this.tsb_Clear.Size = new System.Drawing.Size(38, 29);
            this.tsb_Clear.Text = "🔄";
            this.tsb_Clear.ToolTipText = "Clear All";
            this.tsb_Clear.Click += new System.EventHandler(this.tsb_Clear_Click);
            // 
            // tsl_Warning
            // 
            this.tsl_Warning.ActiveLinkColor = System.Drawing.Color.DarkOrange;
            this.tsl_Warning.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsl_Warning.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsl_Warning.ForeColor = System.Drawing.Color.DarkOrange;
            this.tsl_Warning.Name = "tsl_Warning";
            this.tsl_Warning.Size = new System.Drawing.Size(19, 30);
            this.tsl_Warning.Text = "0";
            // 
            // tsl_Error
            // 
            this.tsl_Error.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsl_Error.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsl_Error.ForeColor = System.Drawing.Color.Tomato;
            this.tsl_Error.Name = "tsl_Error";
            this.tsl_Error.Size = new System.Drawing.Size(19, 30);
            this.tsl_Error.Text = "0";
            // 
            // tsl_Success
            // 
            this.tsl_Success.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsl_Success.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsl_Success.ForeColor = System.Drawing.Color.LimeGreen;
            this.tsl_Success.Name = "tsl_Success";
            this.tsl_Success.Size = new System.Drawing.Size(19, 30);
            this.tsl_Success.Text = "0";
            // 
            // tsl_Message
            // 
            this.tsl_Message.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsl_Message.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsl_Message.Name = "tsl_Message";
            this.tsl_Message.Size = new System.Drawing.Size(19, 30);
            this.tsl_Message.Text = "0";
            // 
            // RTB
            // 
            this.RTB.AcceptsTab = true;
            this.RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB.ContextMenuStrip = this.ContextStripMenu;
            this.RTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB.Location = new System.Drawing.Point(0, 33);
            this.RTB.Name = "RTB";
            this.RTB.Size = new System.Drawing.Size(738, 295);
            this.RTB.TabIndex = 30;
            this.RTB.Text = "";
            this.RTB.WordWrap = false;
            this.RTB.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RTB_LinkClicked);
            this.RTB.TextChanged += new System.EventHandler(this.rtb_TextChanged);
            // 
            // ContextStripMenu
            // 
            this.ContextStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator12,
            this.selectAllToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator13,
            this.clearAllToolStripMenuItem,
            this.toolStripSeparator15,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.ContextStripMenu.Name = "cms_Log";
            this.ContextStripMenu.ShowImageMargin = false;
            this.ContextStripMenu.ShowItemToolTips = false;
            this.ContextStripMenu.Size = new System.Drawing.Size(198, 198);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.tsb_Print_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(194, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.tsb_SelectAll);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.tsb_Copy_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.tsb_Cut_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.tsb_Paste_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(194, 6);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Delete)));
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.tsb_Clear_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(194, 6);
            this.toolStripSeparator15.Visible = false;
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Visible = false;
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.tsb_ZI_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Visible = false;
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.tsb_ZO_Click);
            // 
            // WaitBar
            // 
            this.WaitBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WaitBar.Image = global::MiMFa.Properties.Resources.Progress_Bar_Crystal;
            this.WaitBar.Location = new System.Drawing.Point(0, 328);
            this.WaitBar.Name = "WaitBar";
            this.WaitBar.Size = new System.Drawing.Size(738, 1);
            this.WaitBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WaitBar.TabIndex = 31;
            this.WaitBar.TabStop = false;
            this.WaitBar.Visible = false;
            // 
            // NotificationBox
            // 
            this.NotificationBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NotificationBox.Location = new System.Drawing.Point(0, 331);
            this.NotificationBox.Name = "NotificationBox";
            this.NotificationBox.Padding = new System.Windows.Forms.Padding(5);
            this.NotificationBox.Size = new System.Drawing.Size(738, 25);
            this.NotificationBox.TabIndex = 32;
            this.NotificationBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotificationBox.Visible = false;
            this.NotificationBox.TextChanged += new System.EventHandler(this.NotificationBox_TextChanged);
            this.NotificationBox.Click += new System.EventHandler(this.NotificationBox_Click);
            // 
            // LogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RTB);
            this.Controls.Add(this.WaitBar);
            this.Controls.Add(this.MainStripMenu);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.NotificationBox);
            this.Name = "LogBox";
            this.Size = new System.Drawing.Size(738, 356);
            this.Load += new System.EventHandler(this.LogView_Load);
            this.MainStripMenu.ResumeLayout(false);
            this.MainStripMenu.PerformLayout();
            this.ContextStripMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WaitBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar PB;
        public System.Windows.Forms.ToolStrip MainStripMenu;
        public System.Windows.Forms.ToolStripDropDownButton tsddb_Scripting_Log;
        public System.Windows.Forms.ToolStripMenuItem tsmi_Scripting_ActiveNotice;
        public System.Windows.Forms.ToolStripMenuItem tsmi_Scripting_ActiveLog;
        public System.Windows.Forms.ToolStripMenuItem tsmi_Scripting_ActiveBeep;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tsb_Save;
        private System.Windows.Forms.ToolStripButton tsb_Open;
        private System.Windows.Forms.ToolStripButton tsb_Print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_ZI;
        private System.Windows.Forms.ToolStripButton tsb_ZO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton tsb_Copy;
        private System.Windows.Forms.ToolStripButton tsb_Cut;
        private System.Windows.Forms.ToolStripButton tsb_Paste;
        private System.Windows.Forms.ToolStripButton tsb_Clear;
        private System.Windows.Forms.ToolStripLabel tsl_Error;
        private System.Windows.Forms.ToolStripLabel tsl_Success;
        private System.Windows.Forms.ToolStripLabel tsl_Message;
        private System.Windows.Forms.RichTextBox RTB;
        public System.Windows.Forms.ContextMenuStrip ContextStripMenu;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ActiveDialog;
        private System.Windows.Forms.ToolStripLabel tsl_Warning;
        private System.Windows.Forms.ToolStripLabel tsl_MaxLines;
        private System.Windows.Forms.ToolStripComboBox tscb_MaxLines;
        public System.Windows.Forms.ToolStripDropDownButton tsmi_FinalDuties;
        public System.Windows.Forms.ToolStripMenuItem tsmi_Scripting_Final_S;
        public System.Windows.Forms.ToolStripMenuItem tsmi_Scripting_Final_H;
        public System.Windows.Forms.ToolStripMenuItem tsmi_Scripting_Final_LA;
        public System.Windows.Forms.ToolStripMenuItem tsmi_Scripting_Final_Off;
        public System.Windows.Forms.ToolStripMenuItem tsmi_Scripting_Final_RB;
        public System.Windows.Forms.ToolStripMenuItem tsmi_Scripting_Final_CP;
        public System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        public System.Windows.Forms.PictureBox WaitBar;
        public System.Windows.Forms.Label NotificationBox;
        public System.Windows.Forms.ToolStripMenuItem forSubjectsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem forMessagesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem forSuccessesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem forErrorsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem forWarningsToolStripMenuItem;
    }
}