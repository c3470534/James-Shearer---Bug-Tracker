namespace BugTracker
{
    partial class OpenBug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenBug));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.checkBoxDisplayOwn = new System.Windows.Forms.CheckBox();
            this.checkBoxDisplayUnfixed = new System.Windows.Forms.CheckBox();
            this.listBoxOpen = new System.Windows.Forms.ListBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(45, 384);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(149, 384);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // checkBoxDisplayOwn
            // 
            this.checkBoxDisplayOwn.AutoSize = true;
            this.checkBoxDisplayOwn.Location = new System.Drawing.Point(61, 23);
            this.checkBoxDisplayOwn.Name = "checkBoxDisplayOwn";
            this.checkBoxDisplayOwn.Size = new System.Drawing.Size(201, 17);
            this.checkBoxDisplayOwn.TabIndex = 4;
            this.checkBoxDisplayOwn.Text = "Display only my own bug submissions";
            this.checkBoxDisplayOwn.UseVisualStyleBackColor = true;
            this.checkBoxDisplayOwn.CheckedChanged += new System.EventHandler(this.CheckBoxDisplayOwn_CheckedChanged);
            // 
            // checkBoxDisplayUnfixed
            // 
            this.checkBoxDisplayUnfixed.AutoSize = true;
            this.checkBoxDisplayUnfixed.Location = new System.Drawing.Point(61, 55);
            this.checkBoxDisplayUnfixed.Name = "checkBoxDisplayUnfixed";
            this.checkBoxDisplayUnfixed.Size = new System.Drawing.Size(145, 17);
            this.checkBoxDisplayUnfixed.TabIndex = 5;
            this.checkBoxDisplayUnfixed.Text = "Display only unfixed bugs";
            this.checkBoxDisplayUnfixed.UseVisualStyleBackColor = true;
            this.checkBoxDisplayUnfixed.CheckedChanged += new System.EventHandler(this.CheckBoxDisplayUnfixed_CheckedChanged);
            // 
            // listBoxOpen
            // 
            this.listBoxOpen.FormattingEnabled = true;
            this.listBoxOpen.Location = new System.Drawing.Point(23, 128);
            this.listBoxOpen.Name = "listBoxOpen";
            this.listBoxOpen.Size = new System.Drawing.Size(234, 238);
            this.listBoxOpen.TabIndex = 7;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "All Languages",
            "C++",
            "C#",
            "HTML",
            "Java",
            "Java Script",
            "PHP",
            "XML"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(45, 91);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(196, 21);
            this.comboBoxLanguage.TabIndex = 8;
            this.comboBoxLanguage.Text = "All Languages";
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLanguage_SelectedIndexChanged);
            // 
            // OpenBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 436);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.listBoxOpen);
            this.Controls.Add(this.checkBoxDisplayUnfixed);
            this.Controls.Add(this.checkBoxDisplayOwn);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OpenBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.CheckBox checkBoxDisplayOwn;
        private System.Windows.Forms.CheckBox checkBoxDisplayUnfixed;
        private System.Windows.Forms.ListBox listBoxOpen;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
    }
}