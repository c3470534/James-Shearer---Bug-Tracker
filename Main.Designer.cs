namespace BugTracker
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.LBINPUT = new System.Windows.Forms.ListBox();
            this.BUGIDTXT = new System.Windows.Forms.TextBox();
            this.USERNAMETXT = new System.Windows.Forms.TextBox();
            this.APPTXT = new System.Windows.Forms.TextBox();
            this.BUGID = new System.Windows.Forms.Label();
            this.LBUSERNAME = new System.Windows.Forms.Label();
            this.LBAPP = new System.Windows.Forms.Label();
            this.SYMPTOMTXT = new System.Windows.Forms.TextBox();
            this.CAUSETXT = new System.Windows.Forms.TextBox();
            this.CLASSTXT = new System.Windows.Forms.TextBox();
            this.METHODTXT = new System.Windows.Forms.TextBox();
            this.LNSTXT = new System.Windows.Forms.TextBox();
            this.LNETXT = new System.Windows.Forms.TextBox();
            this.LBCLASS = new System.Windows.Forms.Label();
            this.LBMETHOD = new System.Windows.Forms.Label();
            this.LBSTART = new System.Windows.Forms.Label();
            this.LBEND = new System.Windows.Forms.Label();
            this.LBSYMPTOM = new System.Windows.Forms.Label();
            this.LBCAUSE = new System.Windows.Forms.Label();
            this.LBLT = new System.Windows.Forms.Label();
            this.txtCode = new ICSharpCode.TextEditor.TextEditorControl();
            this.MS1 = new System.Windows.Forms.MenuStrip();
            this.FILE = new System.Windows.Forms.ToolStripMenuItem();
            this.NEW = new System.Windows.Forms.ToolStripMenuItem();
            this.OPEN = new System.Windows.Forms.ToolStripMenuItem();
            this.STS1 = new System.Windows.Forms.ToolStripSeparator();
            this.SUBMIT = new System.Windows.Forms.ToolStripMenuItem();
            this.STS2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.STS3 = new System.Windows.Forms.ToolStripSeparator();
            this.EXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.HELP = new System.Windows.Forms.ToolStripMenuItem();
            this.ABOUT = new System.Windows.Forms.ToolStripMenuItem();
            this.LH1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXTLANG = new System.Windows.Forms.TextBox();
            this.LBLANG = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LF = new System.Windows.Forms.TextBox();
            this.BF = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TTF = new System.Windows.Forms.ToolTip(this.components);
            this.MS1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBINPUT
            // 
            this.LBINPUT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBINPUT.BackColor = System.Drawing.SystemColors.Window;
            this.LBINPUT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBINPUT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBINPUT.FormattingEnabled = true;
            this.LBINPUT.ItemHeight = 15;
            this.LBINPUT.Location = new System.Drawing.Point(666, 33);
            this.LBINPUT.Margin = new System.Windows.Forms.Padding(0);
            this.LBINPUT.MaximumSize = new System.Drawing.Size(485, 242);
            this.LBINPUT.MinimumSize = new System.Drawing.Size(300, 210);
            this.LBINPUT.Name = "LBINPUT";
            this.LBINPUT.ScrollAlwaysVisible = true;
            this.LBINPUT.Size = new System.Drawing.Size(466, 242);
            this.LBINPUT.TabIndex = 1;
            this.LBINPUT.Tag = "";
            this.LBINPUT.SelectedIndexChanged += new System.EventHandler(this.ListBoxInput_SelectedIndexChanged);
            // 
            // BUGIDTXT
            // 
            this.BUGIDTXT.BackColor = System.Drawing.SystemColors.Control;
            this.BUGIDTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BUGIDTXT.Location = new System.Drawing.Point(126, 14);
            this.BUGIDTXT.Name = "BUGIDTXT";
            this.BUGIDTXT.ReadOnly = true;
            this.BUGIDTXT.Size = new System.Drawing.Size(121, 13);
            this.BUGIDTXT.TabIndex = 2;
            // 
            // USERNAMETXT
            // 
            this.USERNAMETXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.USERNAMETXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.USERNAMETXT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAMETXT.Location = new System.Drawing.Point(24, 187);
            this.USERNAMETXT.Name = "USERNAMETXT";
            this.USERNAMETXT.ReadOnly = true;
            this.USERNAMETXT.Size = new System.Drawing.Size(110, 16);
            this.USERNAMETXT.TabIndex = 3;
            // 
            // APPTXT
            // 
            this.APPTXT.BackColor = System.Drawing.SystemColors.Control;
            this.APPTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.APPTXT.Location = new System.Drawing.Point(126, 58);
            this.APPTXT.Name = "APPTXT";
            this.APPTXT.ReadOnly = true;
            this.APPTXT.Size = new System.Drawing.Size(208, 13);
            this.APPTXT.TabIndex = 4;
            // 
            // BUGID
            // 
            this.BUGID.AutoSize = true;
            this.BUGID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUGID.Location = new System.Drawing.Point(19, 11);
            this.BUGID.Name = "BUGID";
            this.BUGID.Size = new System.Drawing.Size(50, 17);
            this.BUGID.TabIndex = 5;
            this.BUGID.Text = "Bug ID";
            // 
            // LBUSERNAME
            // 
            this.LBUSERNAME.AutoSize = true;
            this.LBUSERNAME.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBUSERNAME.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBUSERNAME.Location = new System.Drawing.Point(32, 162);
            this.LBUSERNAME.Name = "LBUSERNAME";
            this.LBUSERNAME.Size = new System.Drawing.Size(91, 17);
            this.LBUSERNAME.TabIndex = 6;
            this.LBUSERNAME.Text = "Logged in as:";
            // 
            // LBAPP
            // 
            this.LBAPP.AutoSize = true;
            this.LBAPP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAPP.Location = new System.Drawing.Point(18, 55);
            this.LBAPP.Name = "LBAPP";
            this.LBAPP.Size = new System.Drawing.Size(79, 17);
            this.LBAPP.TabIndex = 7;
            this.LBAPP.Text = "Application";
            // 
            // SYMPTOMTXT
            // 
            this.SYMPTOMTXT.BackColor = System.Drawing.SystemColors.Control;
            this.SYMPTOMTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SYMPTOMTXT.Location = new System.Drawing.Point(126, 106);
            this.SYMPTOMTXT.Name = "SYMPTOMTXT";
            this.SYMPTOMTXT.ReadOnly = true;
            this.SYMPTOMTXT.Size = new System.Drawing.Size(520, 13);
            this.SYMPTOMTXT.TabIndex = 10;
            // 
            // CAUSETXT
            // 
            this.CAUSETXT.BackColor = System.Drawing.SystemColors.Control;
            this.CAUSETXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CAUSETXT.Location = new System.Drawing.Point(126, 166);
            this.CAUSETXT.Name = "CAUSETXT";
            this.CAUSETXT.ReadOnly = true;
            this.CAUSETXT.Size = new System.Drawing.Size(222, 13);
            this.CAUSETXT.TabIndex = 11;
            // 
            // CLASSTXT
            // 
            this.CLASSTXT.BackColor = System.Drawing.SystemColors.Control;
            this.CLASSTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLASSTXT.Location = new System.Drawing.Point(126, 184);
            this.CLASSTXT.Name = "CLASSTXT";
            this.CLASSTXT.ReadOnly = true;
            this.CLASSTXT.Size = new System.Drawing.Size(463, 13);
            this.CLASSTXT.TabIndex = 12;
            // 
            // METHODTXT
            // 
            this.METHODTXT.BackColor = System.Drawing.SystemColors.Control;
            this.METHODTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.METHODTXT.Location = new System.Drawing.Point(126, 208);
            this.METHODTXT.Name = "METHODTXT";
            this.METHODTXT.ReadOnly = true;
            this.METHODTXT.Size = new System.Drawing.Size(393, 13);
            this.METHODTXT.TabIndex = 13;
            // 
            // LNSTXT
            // 
            this.LNSTXT.BackColor = System.Drawing.SystemColors.Control;
            this.LNSTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LNSTXT.Location = new System.Drawing.Point(120, 232);
            this.LNSTXT.Name = "LNSTXT";
            this.LNSTXT.ReadOnly = true;
            this.LNSTXT.Size = new System.Drawing.Size(40, 13);
            this.LNSTXT.TabIndex = 14;
            this.LNSTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LNSTXT.TextChanged += new System.EventHandler(this.txtLineNoStart_TextChanged);
            // 
            // LNETXT
            // 
            this.LNETXT.BackColor = System.Drawing.SystemColors.Control;
            this.LNETXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LNETXT.Location = new System.Drawing.Point(174, 232);
            this.LNETXT.Name = "LNETXT";
            this.LNETXT.ReadOnly = true;
            this.LNETXT.Size = new System.Drawing.Size(40, 13);
            this.LNETXT.TabIndex = 15;
            this.LNETXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LNETXT.TextChanged += new System.EventHandler(this.txtLineNoEnd_TextChanged);
            // 
            // LBCLASS
            // 
            this.LBCLASS.AutoSize = true;
            this.LBCLASS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCLASS.Location = new System.Drawing.Point(19, 184);
            this.LBCLASS.Name = "LBCLASS";
            this.LBCLASS.Size = new System.Drawing.Size(39, 17);
            this.LBCLASS.TabIndex = 16;
            this.LBCLASS.Text = "Class";
            // 
            // LBMETHOD
            // 
            this.LBMETHOD.AutoSize = true;
            this.LBMETHOD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMETHOD.Location = new System.Drawing.Point(19, 205);
            this.LBMETHOD.Name = "LBMETHOD";
            this.LBMETHOD.Size = new System.Drawing.Size(56, 17);
            this.LBMETHOD.TabIndex = 17;
            this.LBMETHOD.Text = "Method";
            // 
            // LBSTART
            // 
            this.LBSTART.AutoSize = true;
            this.LBSTART.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBSTART.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LBSTART.Location = new System.Drawing.Point(118, 248);
            this.LBSTART.Name = "LBSTART";
            this.LBSTART.Size = new System.Drawing.Size(30, 13);
            this.LBSTART.TabIndex = 18;
            this.LBSTART.Text = "Start";
            // 
            // LBEND
            // 
            this.LBEND.AutoSize = true;
            this.LBEND.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEND.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LBEND.Location = new System.Drawing.Point(193, 248);
            this.LBEND.Name = "LBEND";
            this.LBEND.Size = new System.Drawing.Size(24, 13);
            this.LBEND.TabIndex = 19;
            this.LBEND.Text = "End";
            this.LBEND.Click += new System.EventHandler(this.labelLineNoEnd_Click);
            // 
            // LBSYMPTOM
            // 
            this.LBSYMPTOM.AutoSize = true;
            this.LBSYMPTOM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBSYMPTOM.Location = new System.Drawing.Point(19, 102);
            this.LBSYMPTOM.Name = "LBSYMPTOM";
            this.LBSYMPTOM.Size = new System.Drawing.Size(67, 17);
            this.LBSYMPTOM.TabIndex = 20;
            this.LBSYMPTOM.Text = "Symptom";
            // 
            // LBCAUSE
            // 
            this.LBCAUSE.AutoSize = true;
            this.LBCAUSE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCAUSE.Location = new System.Drawing.Point(19, 163);
            this.LBCAUSE.Name = "LBCAUSE";
            this.LBCAUSE.Size = new System.Drawing.Size(44, 17);
            this.LBCAUSE.TabIndex = 21;
            this.LBCAUSE.Text = "Cause";
            // 
            // LBLT
            // 
            this.LBLT.AutoSize = true;
            this.LBLT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLT.ForeColor = System.Drawing.Color.Black;
            this.LBLT.Location = new System.Drawing.Point(19, 228);
            this.LBLT.Name = "LBLT";
            this.LBLT.Size = new System.Drawing.Size(88, 17);
            this.LBLT.TabIndex = 22;
            this.LBLT.Text = "Line Number";
            this.LBLT.Click += new System.EventHandler(this.labelLineTitle_Click);
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCode.IsReadOnly = false;
            this.txtCode.Location = new System.Drawing.Point(0, 327);
            this.txtCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtCode.MinimumSize = new System.Drawing.Size(100, 300);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(1321, 401);
            this.txtCode.TabIndex = 24;
            this.txtCode.Load += new System.EventHandler(this.TxtCode_Load);
            // 
            // MS1
            // 
            this.MS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FILE,
            this.HELP});
            this.MS1.Location = new System.Drawing.Point(0, 0);
            this.MS1.Name = "MS1";
            this.MS1.Size = new System.Drawing.Size(1321, 24);
            this.MS1.TabIndex = 25;
            this.MS1.Text = "MS1";
            // 
            // FILE
            // 
            this.FILE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NEW,
            this.OPEN,
            this.STS1,
            this.SUBMIT,
            this.STS2,
            this.logoutToolStripMenuItem,
            this.STS3,
            this.EXIT});
            this.FILE.Name = "FILE";
            this.FILE.Size = new System.Drawing.Size(37, 20);
            this.FILE.Text = "File";
            // 
            // NEW
            // 
            this.NEW.Name = "NEW";
            this.NEW.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NEW.Size = new System.Drawing.Size(183, 22);
            this.NEW.Text = "New (Bug)";
            this.NEW.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OPEN
            // 
            this.OPEN.Name = "OPEN";
            this.OPEN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OPEN.Size = new System.Drawing.Size(183, 22);
            this.OPEN.Text = "Open (Bug)";
            this.OPEN.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // STS1
            // 
            this.STS1.Name = "STS1";
            this.STS1.Size = new System.Drawing.Size(180, 6);
            // 
            // SUBMIT
            // 
            this.SUBMIT.Name = "SUBMIT";
            this.SUBMIT.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SUBMIT.Size = new System.Drawing.Size(183, 22);
            this.SUBMIT.Text = "Submit (Edit)";
            this.SUBMIT.Click += new System.EventHandler(this.SubmitAuditToolStripMenuItem_Click);
            // 
            // STS2
            // 
            this.STS2.Name = "STS2";
            this.STS2.Size = new System.Drawing.Size(180, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // STS3
            // 
            this.STS3.Name = "STS3";
            this.STS3.Size = new System.Drawing.Size(180, 6);
            // 
            // EXIT
            // 
            this.EXIT.Name = "EXIT";
            this.EXIT.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.EXIT.Size = new System.Drawing.Size(183, 22);
            this.EXIT.Text = "Exit";
            this.EXIT.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HELP
            // 
            this.HELP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ABOUT});
            this.HELP.Name = "HELP";
            this.HELP.Size = new System.Drawing.Size(44, 20);
            this.HELP.Text = "Help";
            // 
            // ABOUT
            // 
            this.ABOUT.Name = "ABOUT";
            this.ABOUT.Size = new System.Drawing.Size(107, 22);
            this.ABOUT.Text = "About";
            this.ABOUT.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LH1
            // 
            this.LH1.AutoSize = true;
            this.LH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LH1.Location = new System.Drawing.Point(162, 229);
            this.LH1.Name = "LH1";
            this.LH1.Size = new System.Drawing.Size(11, 15);
            this.LH1.TabIndex = 26;
            this.LH1.Text = "-";
            this.LH1.Click += new System.EventHandler(this.labelHyphen1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.LBINPUT);
            this.panel1.Controls.Add(this.TXTLANG);
            this.panel1.Controls.Add(this.LBLANG);
            this.panel1.Controls.Add(this.LH1);
            this.panel1.Controls.Add(this.APPTXT);
            this.panel1.Controls.Add(this.LBLT);
            this.panel1.Controls.Add(this.BUGIDTXT);
            this.panel1.Controls.Add(this.LBCAUSE);
            this.panel1.Controls.Add(this.BUGID);
            this.panel1.Controls.Add(this.LBSYMPTOM);
            this.panel1.Controls.Add(this.LBAPP);
            this.panel1.Controls.Add(this.LBEND);
            this.panel1.Controls.Add(this.SYMPTOMTXT);
            this.panel1.Controls.Add(this.LBSTART);
            this.panel1.Controls.Add(this.CAUSETXT);
            this.panel1.Controls.Add(this.LBMETHOD);
            this.panel1.Controls.Add(this.CLASSTXT);
            this.panel1.Controls.Add(this.LBCLASS);
            this.panel1.Controls.Add(this.METHODTXT);
            this.panel1.Controls.Add(this.LNETXT);
            this.panel1.Controls.Add(this.LNSTXT);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.MaximumSize = new System.Drawing.Size(1200, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(205, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 303);
            this.panel1.TabIndex = 27;
            // 
            // TXTLANG
            // 
            this.TXTLANG.BackColor = System.Drawing.SystemColors.Control;
            this.TXTLANG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTLANG.Location = new System.Drawing.Point(126, 82);
            this.TXTLANG.Name = "TXTLANG";
            this.TXTLANG.ReadOnly = true;
            this.TXTLANG.Size = new System.Drawing.Size(219, 13);
            this.TXTLANG.TabIndex = 28;
            this.TXTLANG.TextChanged += new System.EventHandler(this.txtLanguage_TextChanged);
            // 
            // LBLANG
            // 
            this.LBLANG.AutoSize = true;
            this.LBLANG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLANG.ForeColor = System.Drawing.Color.Black;
            this.LBLANG.Location = new System.Drawing.Point(18, 78);
            this.LBLANG.Name = "LBLANG";
            this.LBLANG.Size = new System.Drawing.Size(68, 17);
            this.LBLANG.TabIndex = 27;
            this.LBLANG.Text = "Language";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(653, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 290);
            this.panel3.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Audit List:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 290);
            this.panel4.TabIndex = 31;
            // 
            // LF
            // 
            this.LF.BackColor = System.Drawing.SystemColors.Control;
            this.LF.Cursor = System.Windows.Forms.Cursors.Default;
            this.LF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LF.Location = new System.Drawing.Point(22, 223);
            this.LF.Name = "LF";
            this.LF.ReadOnly = true;
            this.LF.Size = new System.Drawing.Size(112, 20);
            this.LF.TabIndex = 31;
            this.LF.Text = "Unfixed";
            this.LF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTF.SetToolTip(this.LF, "Only source code creator may change \'Fixed\' status of bug.");
            // 
            // BF
            // 
            this.BF.Location = new System.Drawing.Point(22, 249);
            this.BF.Name = "BF";
            this.BF.Size = new System.Drawing.Size(112, 29);
            this.BF.TabIndex = 30;
            this.BF.Text = "Change";
            this.TTF.SetToolTip(this.BF, "Only source code creator may change \'Fixed\' status of bug.");
            this.BF.UseVisualStyleBackColor = true;
            this.BF.Click += new System.EventHandler(this.ButtonFix_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LBUSERNAME);
            this.panel2.Controls.Add(this.USERNAMETXT);
            this.panel2.Controls.Add(this.LF);
            this.panel2.Controls.Add(this.BF);
            this.panel2.Location = new System.Drawing.Point(1154, 24);
            this.panel2.MaximumSize = new System.Drawing.Size(500, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 290);
            this.panel2.TabIndex = 29;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Command";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1321, 728);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.MS1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS1;
            this.MinimumSize = new System.Drawing.Size(936, 767);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MS1.ResumeLayout(false);
            this.MS1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LBINPUT;
        private System.Windows.Forms.TextBox USERNAMETXT;
        private System.Windows.Forms.TextBox APPTXT;
        private System.Windows.Forms.Label BUGID;
        private System.Windows.Forms.Label LBUSERNAME;
        private System.Windows.Forms.Label LBAPP;
        private System.Windows.Forms.TextBox SYMPTOMTXT;
        private System.Windows.Forms.TextBox CAUSETXT;
        private System.Windows.Forms.TextBox CLASSTXT;
        private System.Windows.Forms.TextBox METHODTXT;
        private System.Windows.Forms.TextBox LNSTXT;
        private System.Windows.Forms.TextBox LNETXT;
        private System.Windows.Forms.Label LBCLASS;
        private System.Windows.Forms.Label LBMETHOD;
        private System.Windows.Forms.Label LBSTART;
        private System.Windows.Forms.Label LBEND;
        private System.Windows.Forms.Label LBSYMPTOM;
        private System.Windows.Forms.Label LBCAUSE;
        private System.Windows.Forms.Label LBLT;
        private System.Windows.Forms.TextBox BUGIDTXT;
        private ICSharpCode.TextEditor.TextEditorControl txtCode;
        private System.Windows.Forms.MenuStrip MS1;
        private System.Windows.Forms.ToolStripMenuItem FILE;
        private System.Windows.Forms.ToolStripMenuItem EXIT;
        private System.Windows.Forms.ToolStripMenuItem NEW;
        private System.Windows.Forms.ToolStripMenuItem OPEN;
        private System.Windows.Forms.ToolStripMenuItem HELP;
        private System.Windows.Forms.Label LH1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem SUBMIT;
        private System.Windows.Forms.TextBox TXTLANG;
        private System.Windows.Forms.Label LBLANG;
        private System.Windows.Forms.ToolStripSeparator STS1;
        private System.Windows.Forms.ToolStripSeparator STS2;
        private System.Windows.Forms.ToolStripSeparator STS3;
        private System.Windows.Forms.Button BF;
        private System.Windows.Forms.TextBox LF;
        private System.Windows.Forms.ToolTip TTF;
        private System.Windows.Forms.ToolStripMenuItem ABOUT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

