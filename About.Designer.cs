namespace Live_Netease_Music_Title
{
    partial class Form_About
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_tempAvatar = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.label_AuthorValue = new System.Windows.Forms.Label();
            this.label_Ver = new System.Windows.Forms.Label();
            this.label_VerValue = new System.Windows.Forms.Label();
            this.label_Tester = new System.Windows.Forms.Label();
            this.linkLabel_TesterValue = new System.Windows.Forms.LinkLabel();
            this.label_SourceCode = new System.Windows.Forms.Label();
            this.linkLabel_SourceCodeValue = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_tempAvatar
            // 
            this.label_tempAvatar.AutoSize = true;
            this.label_tempAvatar.Location = new System.Drawing.Point(36, 70);
            this.label_tempAvatar.Name = "label_tempAvatar";
            this.label_tempAvatar.Size = new System.Drawing.Size(76, 13);
            this.label_tempAvatar.TabIndex = 1;
            this.label_tempAvatar.Text = "头像赶来中...";
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Location = new System.Drawing.Point(143, 21);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(37, 13);
            this.label_Author.TabIndex = 2;
            this.label_Author.Text = "作者：";
            // 
            // label_AuthorValue
            // 
            this.label_AuthorValue.AutoSize = true;
            this.label_AuthorValue.Location = new System.Drawing.Point(186, 21);
            this.label_AuthorValue.Name = "label_AuthorValue";
            this.label_AuthorValue.Size = new System.Drawing.Size(79, 13);
            this.label_AuthorValue.TabIndex = 2;
            this.label_AuthorValue.Text = "林子易 / h-kys";
            // 
            // label_Ver
            // 
            this.label_Ver.AutoSize = true;
            this.label_Ver.Location = new System.Drawing.Point(143, 39);
            this.label_Ver.Name = "label_Ver";
            this.label_Ver.Size = new System.Drawing.Size(37, 13);
            this.label_Ver.TabIndex = 2;
            this.label_Ver.Text = "版本：";
            // 
            // label_VerValue
            // 
            this.label_VerValue.AutoSize = true;
            this.label_VerValue.Location = new System.Drawing.Point(186, 39);
            this.label_VerValue.Name = "label_VerValue";
            this.label_VerValue.Size = new System.Drawing.Size(47, 13);
            this.label_VerValue.TabIndex = 2;
            this.label_VerValue.Text = "0.5 Beta";
            // 
            // label_Tester
            // 
            this.label_Tester.AutoSize = true;
            this.label_Tester.Location = new System.Drawing.Point(143, 57);
            this.label_Tester.Name = "label_Tester";
            this.label_Tester.Size = new System.Drawing.Size(37, 13);
            this.label_Tester.TabIndex = 2;
            this.label_Tester.Text = "测试：";
            this.label_Tester.Click += new System.EventHandler(this.label_Tester_Click);
            // 
            // linkLabel_TesterValue
            // 
            this.linkLabel_TesterValue.AutoSize = true;
            this.linkLabel_TesterValue.Location = new System.Drawing.Point(186, 57);
            this.linkLabel_TesterValue.Name = "linkLabel_TesterValue";
            this.linkLabel_TesterValue.Size = new System.Drawing.Size(73, 13);
            this.linkLabel_TesterValue.TabIndex = 3;
            this.linkLabel_TesterValue.TabStop = true;
            this.linkLabel_TesterValue.Text = "名前SshiRaN";
            this.linkLabel_TesterValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_TesterValue_LinkClicked);
            // 
            // label_SourceCode
            // 
            this.label_SourceCode.AutoSize = true;
            this.label_SourceCode.Location = new System.Drawing.Point(143, 75);
            this.label_SourceCode.Name = "label_SourceCode";
            this.label_SourceCode.Size = new System.Drawing.Size(37, 13);
            this.label_SourceCode.TabIndex = 2;
            this.label_SourceCode.Text = "源码：";
            this.label_SourceCode.Click += new System.EventHandler(this.label_Tester_Click);
            // 
            // linkLabel_SourceCodeValue
            // 
            this.linkLabel_SourceCodeValue.AutoSize = true;
            this.linkLabel_SourceCodeValue.Location = new System.Drawing.Point(186, 75);
            this.linkLabel_SourceCodeValue.Name = "linkLabel_SourceCodeValue";
            this.linkLabel_SourceCodeValue.Size = new System.Drawing.Size(38, 13);
            this.linkLabel_SourceCodeValue.TabIndex = 4;
            this.linkLabel_SourceCodeValue.TabStop = true;
            this.linkLabel_SourceCodeValue.Text = "Github";
            this.linkLabel_SourceCodeValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_SourceCodeValue_LinkClicked);
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 151);
            this.Controls.Add(this.linkLabel_SourceCodeValue);
            this.Controls.Add(this.linkLabel_TesterValue);
            this.Controls.Add(this.label_VerValue);
            this.Controls.Add(this.label_SourceCode);
            this.Controls.Add(this.label_Tester);
            this.Controls.Add(this.label_AuthorValue);
            this.Controls.Add(this.label_Ver);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.label_tempAvatar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_About";
            this.Text = "关于";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_tempAvatar;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Label label_AuthorValue;
        private System.Windows.Forms.Label label_Ver;
        private System.Windows.Forms.Label label_VerValue;
        private System.Windows.Forms.Label label_Tester;
        private System.Windows.Forms.LinkLabel linkLabel_TesterValue;
        private System.Windows.Forms.Label label_SourceCode;
        private System.Windows.Forms.LinkLabel linkLabel_SourceCodeValue;
    }
}