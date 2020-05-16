namespace Live_Netease_Music_Title
{
    partial class Form_Display
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
            this.label_Display = new System.Windows.Forms.Label();
            this.timer_Rolling = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_Display
            // 
            this.label_Display.AutoSize = true;
            this.label_Display.BackColor = System.Drawing.Color.Transparent;
            this.label_Display.Location = new System.Drawing.Point(0, 0);
            this.label_Display.Name = "label_Display";
            this.label_Display.Size = new System.Drawing.Size(69, 13);
            this.label_Display.TabIndex = 0;
            this.label_Display.Text = "label_Display";
            this.label_Display.Click += new System.EventHandler(this.label_Display_Click);
            this.label_Display.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Display_MouseDown);
            this.label_Display.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_Display_MouseMove);
            this.label_Display.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Display_MouseUp);
            // 
            // timer_Rolling
            // 
            this.timer_Rolling.Interval = 10;
            this.timer_Rolling.Tick += new System.EventHandler(this.timer_Rolling_Tick);
            // 
            // Form_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(120, 58);
            this.Controls.Add(this.label_Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Display";
            this.Text = "Form_Display";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form_Display_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Display_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Display_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Display_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Display;
        private System.Windows.Forms.Timer timer_Rolling;
    }
}