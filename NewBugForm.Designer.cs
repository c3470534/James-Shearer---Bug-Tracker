namespace BugTracker
{
    partial class NewBugForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBugForm));
            this.labelHyphen1 = new System.Windows.Forms.Label();
            this.labelLineTitleNew = new System.Windows.Forms.Label();
            this.labelCauseNew = new System.Windows.Forms.Label();
            this.labelSymptomNew = new System.Windows.Forms.Label();
            this.labelLineNoEndNew = new System.Windows.Forms.Label();
            this.labelLineNoStartNew = new System.Windows.Forms.Label();
            this.labelMethodNew = new System.Windows.Forms.Label();
            this.labelClassNew = new System.Windows.Forms.Label();
            this.txtLineNoEndNew = new System.Windows.Forms.TextBox();
            this.txtLineNoStartNew = new System.Windows.Forms.TextBox();
            this.txtMethodNew = new System.Windows.Forms.TextBox();
            this.txtClassNew = new System.Windows.Forms.TextBox();
            this.txtCauseNew = new System.Windows.Forms.TextBox();
            this.txtSymptomNew = new System.Windows.Forms.TextBox();
            this.labelApplicationNew = new System.Windows.Forms.Label();
            this.txtApplicationNew = new System.Windows.Forms.TextBox();
            this.buttonNewBug = new System.Windows.Forms.Button();
            this.txtCodeNew = new ICSharpCode.TextEditor.TextEditorControl();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.txtAuthorNew = new System.Windows.Forms.TextBox();
            this.buttonNBCancel = new System.Windows.Forms.Button();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHyphen1
            // 
            this.labelHyphen1.AutoSize = true;
            this.labelHyphen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHyphen1.Location = new System.Drawing.Point(126, 405);
            this.labelHyphen1.Name = "LH1";
            this.labelHyphen1.Size = new System.Drawing.Size(11, 15);
            this.labelHyphen1.TabIndex = 44;
            this.labelHyphen1.Text = "-";
            // 
            // labelLineTitleNew
            // 
            this.labelLineTitleNew.AutoSize = true;
            this.labelLineTitleNew.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineTitleNew.ForeColor = System.Drawing.Color.Black;
            this.labelLineTitleNew.Location = new System.Drawing.Point(6, 407);
            this.labelLineTitleNew.Name = "labelLineTitleNew";
            this.labelLineTitleNew.Size = new System.Drawing.Size(72, 13);
            this.labelLineTitleNew.TabIndex = 43;
            this.labelLineTitleNew.Text = "Line Number";
            // 
            // labelCauseNew
            // 
            this.labelCauseNew.AutoSize = true;
            this.labelCauseNew.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCauseNew.Location = new System.Drawing.Point(40, 328);
            this.labelCauseNew.Name = "labelCauseNew";
            this.labelCauseNew.Size = new System.Drawing.Size(38, 13);
            this.labelCauseNew.TabIndex = 42;
            this.labelCauseNew.Text = "Cause";
            // 
            // labelSymptomNew
            // 
            this.labelSymptomNew.AutoSize = true;
            this.labelSymptomNew.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSymptomNew.Location = new System.Drawing.Point(24, 303);
            this.labelSymptomNew.Name = "labelSymptomNew";
            this.labelSymptomNew.Size = new System.Drawing.Size(54, 13);
            this.labelSymptomNew.TabIndex = 41;
            this.labelSymptomNew.Text = "Symptom";
            // 
            // labelLineNoEndNew
            // 
            this.labelLineNoEndNew.AutoSize = true;
            this.labelLineNoEndNew.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineNoEndNew.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelLineNoEndNew.Location = new System.Drawing.Point(140, 424);
            this.labelLineNoEndNew.Name = "labelLineNoEndNew";
            this.labelLineNoEndNew.Size = new System.Drawing.Size(27, 13);
            this.labelLineNoEndNew.TabIndex = 40;
            this.labelLineNoEndNew.Text = "End";
            // 
            // labelLineNoStartNew
            // 
            this.labelLineNoStartNew.AutoSize = true;
            this.labelLineNoStartNew.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineNoStartNew.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelLineNoStartNew.Location = new System.Drawing.Point(93, 424);
            this.labelLineNoStartNew.Name = "labelLineNoStartNew";
            this.labelLineNoStartNew.Size = new System.Drawing.Size(31, 13);
            this.labelLineNoStartNew.TabIndex = 39;
            this.labelLineNoStartNew.Text = "Start";
            // 
            // labelMethodNew
            // 
            this.labelMethodNew.AutoSize = true;
            this.labelMethodNew.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMethodNew.Location = new System.Drawing.Point(28, 379);
            this.labelMethodNew.Name = "labelMethodNew";
            this.labelMethodNew.Size = new System.Drawing.Size(48, 13);
            this.labelMethodNew.TabIndex = 38;
            this.labelMethodNew.Text = "Method";
            // 
            // labelClassNew
            // 
            this.labelClassNew.AutoSize = true;
            this.labelClassNew.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassNew.Location = new System.Drawing.Point(43, 353);
            this.labelClassNew.Name = "labelClassNew";
            this.labelClassNew.Size = new System.Drawing.Size(33, 13);
            this.labelClassNew.TabIndex = 37;
            this.labelClassNew.Text = "Class";
            // 
            // txtLineNoEndNew
            // 
            this.txtLineNoEndNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLineNoEndNew.Location = new System.Drawing.Point(138, 404);
            this.txtLineNoEndNew.Name = "txtLineNoEndNew";
            this.txtLineNoEndNew.Size = new System.Drawing.Size(40, 20);
            this.txtLineNoEndNew.TabIndex = 36;
            // 
            // txtLineNoStartNew
            // 
            this.txtLineNoStartNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLineNoStartNew.Location = new System.Drawing.Point(84, 404);
            this.txtLineNoStartNew.Name = "txtLineNoStartNew";
            this.txtLineNoStartNew.Size = new System.Drawing.Size(40, 20);
            this.txtLineNoStartNew.TabIndex = 35;
            // 
            // txtMethodNew
            // 
            this.txtMethodNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMethodNew.Location = new System.Drawing.Point(84, 376);
            this.txtMethodNew.Name = "txtMethodNew";
            this.txtMethodNew.Size = new System.Drawing.Size(524, 20);
            this.txtMethodNew.TabIndex = 34;
            // 
            // txtClassNew
            // 
            this.txtClassNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtClassNew.Location = new System.Drawing.Point(84, 350);
            this.txtClassNew.Name = "txtClassNew";
            this.txtClassNew.Size = new System.Drawing.Size(524, 20);
            this.txtClassNew.TabIndex = 33;
            // 
            // txtCauseNew
            // 
            this.txtCauseNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCauseNew.Location = new System.Drawing.Point(84, 325);
            this.txtCauseNew.Name = "txtCauseNew";
            this.txtCauseNew.Size = new System.Drawing.Size(524, 20);
            this.txtCauseNew.TabIndex = 32;
            // 
            // txtSymptomNew
            // 
            this.txtSymptomNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSymptomNew.Location = new System.Drawing.Point(84, 300);
            this.txtSymptomNew.Name = "txtSymptomNew";
            this.txtSymptomNew.Size = new System.Drawing.Size(524, 20);
            this.txtSymptomNew.TabIndex = 31;
            // 
            // labelApplicationNew
            // 
            this.labelApplicationNew.AutoSize = true;
            this.labelApplicationNew.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationNew.Location = new System.Drawing.Point(12, 278);
            this.labelApplicationNew.Name = "labelApplicationNew";
            this.labelApplicationNew.Size = new System.Drawing.Size(66, 13);
            this.labelApplicationNew.TabIndex = 30;
            this.labelApplicationNew.Text = "Application";
            // 
            // txtApplicationNew
            // 
            this.txtApplicationNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtApplicationNew.Location = new System.Drawing.Point(84, 275);
            this.txtApplicationNew.Name = "txtApplicationNew";
            this.txtApplicationNew.Size = new System.Drawing.Size(524, 20);
            this.txtApplicationNew.TabIndex = 28;
            // 
            // buttonNewBug
            // 
            this.buttonNewBug.Location = new System.Drawing.Point(543, 404);
            this.buttonNewBug.Name = "buttonNewBug";
            this.buttonNewBug.Size = new System.Drawing.Size(65, 23);
            this.buttonNewBug.TabIndex = 45;
            this.buttonNewBug.Text = "Submit";
            this.buttonNewBug.UseVisualStyleBackColor = true;
            this.buttonNewBug.Click += new System.EventHandler(this.ButtonNewBug_Click);
            // 
            // txtCodeNew
            // 
            this.txtCodeNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodeNew.IsReadOnly = false;
            this.txtCodeNew.Location = new System.Drawing.Point(5, 5);
            this.txtCodeNew.Name = "txtCodeNew";
            this.txtCodeNew.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.txtCodeNew.Size = new System.Drawing.Size(614, 260);
            this.txtCodeNew.TabIndex = 46;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelAuthor.Location = new System.Drawing.Point(8, 5);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(47, 13);
            this.labelAuthor.TabIndex = 47;
            this.labelAuthor.Text = "Author:";
            // 
            // txtAuthorNew
            // 
            this.txtAuthorNew.BackColor = System.Drawing.SystemColors.Control;
            this.txtAuthorNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthorNew.Location = new System.Drawing.Point(85, 5);
            this.txtAuthorNew.Name = "txtAuthorNew";
            this.txtAuthorNew.Size = new System.Drawing.Size(82, 13);
            this.txtAuthorNew.TabIndex = 48;
            this.txtAuthorNew.Text = "testuser001";
            // 
            // buttonNBCancel
            // 
            this.buttonNBCancel.Location = new System.Drawing.Point(461, 404);
            this.buttonNBCancel.Name = "buttonNBCancel";
            this.buttonNBCancel.Size = new System.Drawing.Size(65, 23);
            this.buttonNBCancel.TabIndex = 49;
            this.buttonNBCancel.Text = "Cancel";
            this.buttonNBCancel.UseVisualStyleBackColor = true;
            this.buttonNBCancel.Click += new System.EventHandler(this.ButtonNBCancel_Click);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "C++",
            "C#",
            "HTML",
            "Java",
            "Java Script",
            "PHP",
            "XML"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(543, 1);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(77, 21);
            this.comboBoxLanguage.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(467, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Language";
            // 
            // NewBugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.buttonNBCancel);
            this.Controls.Add(this.txtAuthorNew);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.txtCodeNew);
            this.Controls.Add(this.buttonNewBug);
            this.Controls.Add(this.labelHyphen1);
            this.Controls.Add(this.labelLineTitleNew);
            this.Controls.Add(this.labelCauseNew);
            this.Controls.Add(this.labelSymptomNew);
            this.Controls.Add(this.labelLineNoEndNew);
            this.Controls.Add(this.labelLineNoStartNew);
            this.Controls.Add(this.labelMethodNew);
            this.Controls.Add(this.labelClassNew);
            this.Controls.Add(this.txtLineNoEndNew);
            this.Controls.Add(this.txtLineNoStartNew);
            this.Controls.Add(this.txtMethodNew);
            this.Controls.Add(this.txtClassNew);
            this.Controls.Add(this.txtCauseNew);
            this.Controls.Add(this.txtSymptomNew);
            this.Controls.Add(this.labelApplicationNew);
            this.Controls.Add(this.txtApplicationNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "NewBugForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHyphen1;
        private System.Windows.Forms.Label labelLineTitleNew;
        private System.Windows.Forms.Label labelCauseNew;
        private System.Windows.Forms.Label labelSymptomNew;
        private System.Windows.Forms.Label labelLineNoEndNew;
        private System.Windows.Forms.Label labelLineNoStartNew;
        private System.Windows.Forms.Label labelMethodNew;
        private System.Windows.Forms.Label labelClassNew;
        private System.Windows.Forms.TextBox txtLineNoEndNew;
        private System.Windows.Forms.TextBox txtLineNoStartNew;
        private System.Windows.Forms.TextBox txtMethodNew;
        private System.Windows.Forms.TextBox txtClassNew;
        private System.Windows.Forms.TextBox txtCauseNew;
        private System.Windows.Forms.TextBox txtSymptomNew;
        private System.Windows.Forms.Label labelApplicationNew;
        private System.Windows.Forms.TextBox txtApplicationNew;
        private System.Windows.Forms.Button buttonNewBug;
        private ICSharpCode.TextEditor.TextEditorControl txtCodeNew;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox txtAuthorNew;
        private System.Windows.Forms.Button buttonNBCancel;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label label1;
    }
}