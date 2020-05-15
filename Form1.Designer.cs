namespace Live_Netease_Music_Title
{
    partial class Form_Main_Window
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
            this.trackBar_Catch_Speed = new System.Windows.Forms.TrackBar();
            this.fontDialog_Display_Font = new System.Windows.Forms.FontDialog();
            this.label_Font = new System.Windows.Forms.Label();
            this.label_Catch_Speed = new System.Windows.Forms.Label();
            this.label_Catch_Speed_Value = new System.Windows.Forms.Label();
            this.label_line_v = new System.Windows.Forms.Label();
            this.button_Change_Font = new System.Windows.Forms.Button();
            this.groupBox_Font = new System.Windows.Forms.GroupBox();
            this.label_Font_Color_Preview = new System.Windows.Forms.Label();
            this.label_Font_Color = new System.Windows.Forms.Label();
            this.richTextBox_Font_Preview = new System.Windows.Forms.RichTextBox();
            this.groupBox_Display = new System.Windows.Forms.GroupBox();
            this.textBox_Display_Window_Size_Value = new System.Windows.Forms.TextBox();
            this.label_Display_Window_Size = new System.Windows.Forms.Label();
            this.radioButton_Display_Rolling = new System.Windows.Forms.RadioButton();
            this.radioButton_Display_No_Rolling = new System.Windows.Forms.RadioButton();
            this.radioButton_Background_Full_Transparent = new System.Windows.Forms.RadioButton();
            this.radioButton_Background_Custom = new System.Windows.Forms.RadioButton();
            this.label_Background_Color = new System.Windows.Forms.Label();
            this.label_Background_Color_Preview = new System.Windows.Forms.Label();
            this.label_Background_Transparent = new System.Windows.Forms.Label();
            this.label_Background_Transparent_Value = new System.Windows.Forms.Label();
            this.trackBar_Background_Transparent = new System.Windows.Forms.TrackBar();
            this.groupBox_Background = new System.Windows.Forms.GroupBox();
            this.label_line_h = new System.Windows.Forms.Label();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.button_Switch = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_Status_Value = new System.Windows.Forms.Label();
            this.colorDialog_Display_Font = new System.Windows.Forms.ColorDialog();
            this.colorDialog_Background = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker_Open_Display_Form = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_Get_Title = new System.ComponentModel.BackgroundWorker();
            this.checkBox_TopMost = new System.Windows.Forms.CheckBox();
            this.label_Copyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Catch_Speed)).BeginInit();
            this.groupBox_Font.SuspendLayout();
            this.groupBox_Display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Background_Transparent)).BeginInit();
            this.groupBox_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar_Catch_Speed
            // 
            this.trackBar_Catch_Speed.LargeChange = 1000;
            this.trackBar_Catch_Speed.Location = new System.Drawing.Point(12, 25);
            this.trackBar_Catch_Speed.Maximum = 100000;
            this.trackBar_Catch_Speed.Minimum = 100;
            this.trackBar_Catch_Speed.Name = "trackBar_Catch_Speed";
            this.trackBar_Catch_Speed.Size = new System.Drawing.Size(368, 45);
            this.trackBar_Catch_Speed.SmallChange = 500;
            this.trackBar_Catch_Speed.TabIndex = 0;
            this.trackBar_Catch_Speed.TickFrequency = 5000;
            this.trackBar_Catch_Speed.Value = 2000;
            this.trackBar_Catch_Speed.Scroll += new System.EventHandler(this.trackBar_Catch_Speed_Scroll);
            // 
            // fontDialog_Display_Font
            // 
            this.fontDialog_Display_Font.ShowApply = true;
            this.fontDialog_Display_Font.Apply += new System.EventHandler(this.fontDialog_Display_Font_Apply);
            // 
            // label_Font
            // 
            this.label_Font.AutoSize = true;
            this.label_Font.Location = new System.Drawing.Point(6, 18);
            this.label_Font.Name = "label_Font";
            this.label_Font.Size = new System.Drawing.Size(31, 13);
            this.label_Font.TabIndex = 1;
            this.label_Font.Text = "预览";
            // 
            // label_Catch_Speed
            // 
            this.label_Catch_Speed.AutoSize = true;
            this.label_Catch_Speed.Location = new System.Drawing.Point(12, 9);
            this.label_Catch_Speed.Name = "label_Catch_Speed";
            this.label_Catch_Speed.Size = new System.Drawing.Size(85, 13);
            this.label_Catch_Speed.TabIndex = 2;
            this.label_Catch_Speed.Text = "捕获时间间隔：";
            // 
            // label_Catch_Speed_Value
            // 
            this.label_Catch_Speed_Value.AutoSize = true;
            this.label_Catch_Speed_Value.Location = new System.Drawing.Point(103, 9);
            this.label_Catch_Speed_Value.Name = "label_Catch_Speed_Value";
            this.label_Catch_Speed_Value.Size = new System.Drawing.Size(31, 13);
            this.label_Catch_Speed_Value.TabIndex = 3;
            this.label_Catch_Speed_Value.Text = "2000";
            // 
            // label_line_v
            // 
            this.label_line_v.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_line_v.Location = new System.Drawing.Point(204, 70);
            this.label_line_v.Name = "label_line_v";
            this.label_line_v.Size = new System.Drawing.Size(2, 280);
            this.label_line_v.TabIndex = 5;
            // 
            // button_Change_Font
            // 
            this.button_Change_Font.Location = new System.Drawing.Point(105, 86);
            this.button_Change_Font.Name = "button_Change_Font";
            this.button_Change_Font.Size = new System.Drawing.Size(75, 23);
            this.button_Change_Font.TabIndex = 6;
            this.button_Change_Font.Text = "编辑字体...";
            this.button_Change_Font.UseVisualStyleBackColor = true;
            this.button_Change_Font.Click += new System.EventHandler(this.button_Change_Font_Click);
            // 
            // groupBox_Font
            // 
            this.groupBox_Font.Controls.Add(this.label_Font_Color_Preview);
            this.groupBox_Font.Controls.Add(this.label_Font_Color);
            this.groupBox_Font.Controls.Add(this.label_Font);
            this.groupBox_Font.Controls.Add(this.richTextBox_Font_Preview);
            this.groupBox_Font.Controls.Add(this.button_Change_Font);
            this.groupBox_Font.Location = new System.Drawing.Point(12, 70);
            this.groupBox_Font.Name = "groupBox_Font";
            this.groupBox_Font.Size = new System.Drawing.Size(186, 115);
            this.groupBox_Font.TabIndex = 8;
            this.groupBox_Font.TabStop = false;
            this.groupBox_Font.Text = "字体";
            // 
            // label_Font_Color_Preview
            // 
            this.label_Font_Color_Preview.BackColor = System.Drawing.Color.Black;
            this.label_Font_Color_Preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Font_Color_Preview.Location = new System.Drawing.Point(67, 91);
            this.label_Font_Color_Preview.Name = "label_Font_Color_Preview";
            this.label_Font_Color_Preview.Size = new System.Drawing.Size(13, 13);
            this.label_Font_Color_Preview.TabIndex = 8;
            this.label_Font_Color_Preview.Click += new System.EventHandler(this.label_Font_Color_Preview_Click);
            // 
            // label_Font_Color
            // 
            this.label_Font_Color.AutoSize = true;
            this.label_Font_Color.Location = new System.Drawing.Point(6, 91);
            this.label_Font_Color.Name = "label_Font_Color";
            this.label_Font_Color.Size = new System.Drawing.Size(55, 13);
            this.label_Font_Color.TabIndex = 7;
            this.label_Font_Color.Text = "字体颜色";
            // 
            // richTextBox_Font_Preview
            // 
            this.richTextBox_Font_Preview.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_Font_Preview.Location = new System.Drawing.Point(9, 35);
            this.richTextBox_Font_Preview.Multiline = false;
            this.richTextBox_Font_Preview.Name = "richTextBox_Font_Preview";
            this.richTextBox_Font_Preview.ReadOnly = true;
            this.richTextBox_Font_Preview.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_Font_Preview.Size = new System.Drawing.Size(171, 45);
            this.richTextBox_Font_Preview.TabIndex = 4;
            this.richTextBox_Font_Preview.Text = "これは一首English的歌";
            // 
            // groupBox_Display
            // 
            this.groupBox_Display.Controls.Add(this.textBox_Display_Window_Size_Value);
            this.groupBox_Display.Controls.Add(this.label_Display_Window_Size);
            this.groupBox_Display.Controls.Add(this.radioButton_Display_Rolling);
            this.groupBox_Display.Controls.Add(this.radioButton_Display_No_Rolling);
            this.groupBox_Display.Location = new System.Drawing.Point(213, 70);
            this.groupBox_Display.Name = "groupBox_Display";
            this.groupBox_Display.Size = new System.Drawing.Size(167, 95);
            this.groupBox_Display.TabIndex = 10;
            this.groupBox_Display.TabStop = false;
            this.groupBox_Display.Text = "模式";
            // 
            // textBox_Display_Window_Size_Value
            // 
            this.textBox_Display_Window_Size_Value.Enabled = false;
            this.textBox_Display_Window_Size_Value.Location = new System.Drawing.Point(94, 64);
            this.textBox_Display_Window_Size_Value.Name = "textBox_Display_Window_Size_Value";
            this.textBox_Display_Window_Size_Value.Size = new System.Drawing.Size(63, 20);
            this.textBox_Display_Window_Size_Value.TabIndex = 3;
            this.textBox_Display_Window_Size_Value.Text = "400";
            this.textBox_Display_Window_Size_Value.TextChanged += new System.EventHandler(this.textBox_Display_Window_Size_Value_TextChanged);
            this.textBox_Display_Window_Size_Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Display_Window_Size_Value_KeyPress);
            // 
            // label_Display_Window_Size
            // 
            this.label_Display_Window_Size.AutoSize = true;
            this.label_Display_Window_Size.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Display_Window_Size.Location = new System.Drawing.Point(26, 67);
            this.label_Display_Window_Size.Name = "label_Display_Window_Size";
            this.label_Display_Window_Size.Size = new System.Drawing.Size(61, 13);
            this.label_Display_Window_Size.TabIndex = 2;
            this.label_Display_Window_Size.Text = "窗口宽度：";
            // 
            // radioButton_Display_Rolling
            // 
            this.radioButton_Display_Rolling.AutoSize = true;
            this.radioButton_Display_Rolling.Location = new System.Drawing.Point(7, 44);
            this.radioButton_Display_Rolling.Name = "radioButton_Display_Rolling";
            this.radioButton_Display_Rolling.Size = new System.Drawing.Size(157, 17);
            this.radioButton_Display_Rolling.TabIndex = 1;
            this.radioButton_Display_Rolling.TabStop = true;
            this.radioButton_Display_Rolling.Text = "大于窗口宽度时混动显示";
            this.radioButton_Display_Rolling.UseVisualStyleBackColor = true;
            this.radioButton_Display_Rolling.CheckedChanged += new System.EventHandler(this.radioButton_Display_Rolling_CheckedChanged);
            // 
            // radioButton_Display_No_Rolling
            // 
            this.radioButton_Display_No_Rolling.AutoSize = true;
            this.radioButton_Display_No_Rolling.Checked = true;
            this.radioButton_Display_No_Rolling.Location = new System.Drawing.Point(7, 20);
            this.radioButton_Display_No_Rolling.Name = "radioButton_Display_No_Rolling";
            this.radioButton_Display_No_Rolling.Size = new System.Drawing.Size(150, 17);
            this.radioButton_Display_No_Rolling.TabIndex = 0;
            this.radioButton_Display_No_Rolling.TabStop = true;
            this.radioButton_Display_No_Rolling.Text = "不滚动，一次性显示全部";
            this.radioButton_Display_No_Rolling.UseVisualStyleBackColor = true;
            this.radioButton_Display_No_Rolling.CheckedChanged += new System.EventHandler(this.radioButton_Display_No_Rolling_CheckedChanged);
            // 
            // radioButton_Background_Full_Transparent
            // 
            this.radioButton_Background_Full_Transparent.Checked = true;
            this.radioButton_Background_Full_Transparent.Location = new System.Drawing.Point(9, 20);
            this.radioButton_Background_Full_Transparent.Name = "radioButton_Background_Full_Transparent";
            this.radioButton_Background_Full_Transparent.Size = new System.Drawing.Size(85, 17);
            this.radioButton_Background_Full_Transparent.TabIndex = 0;
            this.radioButton_Background_Full_Transparent.TabStop = true;
            this.radioButton_Background_Full_Transparent.Text = "完全透明";
            this.radioButton_Background_Full_Transparent.UseVisualStyleBackColor = true;
            this.radioButton_Background_Full_Transparent.CheckedChanged += new System.EventHandler(this.radioButton_Background_Full_Transparent_CheckedChanged);
            // 
            // radioButton_Background_Custom
            // 
            this.radioButton_Background_Custom.AutoSize = true;
            this.radioButton_Background_Custom.Location = new System.Drawing.Point(9, 43);
            this.radioButton_Background_Custom.Name = "radioButton_Background_Custom";
            this.radioButton_Background_Custom.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Background_Custom.TabIndex = 1;
            this.radioButton_Background_Custom.Text = "自定义";
            this.radioButton_Background_Custom.UseVisualStyleBackColor = true;
            this.radioButton_Background_Custom.CheckedChanged += new System.EventHandler(this.radioButton_Background_Custom_CheckedChanged);
            // 
            // label_Background_Color
            // 
            this.label_Background_Color.AutoSize = true;
            this.label_Background_Color.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Background_Color.Location = new System.Drawing.Point(25, 66);
            this.label_Background_Color.Name = "label_Background_Color";
            this.label_Background_Color.Size = new System.Drawing.Size(55, 13);
            this.label_Background_Color.TabIndex = 2;
            this.label_Background_Color.Text = "背景颜色";
            // 
            // label_Background_Color_Preview
            // 
            this.label_Background_Color_Preview.BackColor = System.Drawing.SystemColors.Control;
            this.label_Background_Color_Preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Background_Color_Preview.Location = new System.Drawing.Point(86, 66);
            this.label_Background_Color_Preview.Name = "label_Background_Color_Preview";
            this.label_Background_Color_Preview.Size = new System.Drawing.Size(13, 13);
            this.label_Background_Color_Preview.TabIndex = 3;
            this.label_Background_Color_Preview.Click += new System.EventHandler(this.label_Background_Color_Preview_Click);
            // 
            // label_Background_Transparent
            // 
            this.label_Background_Transparent.AutoSize = true;
            this.label_Background_Transparent.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Background_Transparent.Location = new System.Drawing.Point(25, 85);
            this.label_Background_Transparent.Name = "label_Background_Transparent";
            this.label_Background_Transparent.Size = new System.Drawing.Size(55, 13);
            this.label_Background_Transparent.TabIndex = 4;
            this.label_Background_Transparent.Text = "不透明度";
            // 
            // label_Background_Transparent_Value
            // 
            this.label_Background_Transparent_Value.AutoSize = true;
            this.label_Background_Transparent_Value.BackColor = System.Drawing.Color.Transparent;
            this.label_Background_Transparent_Value.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Background_Transparent_Value.Location = new System.Drawing.Point(83, 85);
            this.label_Background_Transparent_Value.Name = "label_Background_Transparent_Value";
            this.label_Background_Transparent_Value.Size = new System.Drawing.Size(21, 13);
            this.label_Background_Transparent_Value.TabIndex = 5;
            this.label_Background_Transparent_Value.Text = "0%";
            // 
            // trackBar_Background_Transparent
            // 
            this.trackBar_Background_Transparent.Enabled = false;
            this.trackBar_Background_Transparent.LargeChange = 10;
            this.trackBar_Background_Transparent.Location = new System.Drawing.Point(28, 102);
            this.trackBar_Background_Transparent.Maximum = 100;
            this.trackBar_Background_Transparent.Name = "trackBar_Background_Transparent";
            this.trackBar_Background_Transparent.Size = new System.Drawing.Size(152, 45);
            this.trackBar_Background_Transparent.SmallChange = 5;
            this.trackBar_Background_Transparent.TabIndex = 6;
            this.trackBar_Background_Transparent.TickFrequency = 10;
            this.trackBar_Background_Transparent.Value = 100;
            this.trackBar_Background_Transparent.Scroll += new System.EventHandler(this.trackBar_Background_Transparent_Scroll);
            // 
            // groupBox_Background
            // 
            this.groupBox_Background.Controls.Add(this.trackBar_Background_Transparent);
            this.groupBox_Background.Controls.Add(this.label_Background_Transparent_Value);
            this.groupBox_Background.Controls.Add(this.label_Background_Transparent);
            this.groupBox_Background.Controls.Add(this.label_Background_Color_Preview);
            this.groupBox_Background.Controls.Add(this.label_Background_Color);
            this.groupBox_Background.Controls.Add(this.radioButton_Background_Custom);
            this.groupBox_Background.Controls.Add(this.radioButton_Background_Full_Transparent);
            this.groupBox_Background.Location = new System.Drawing.Point(12, 191);
            this.groupBox_Background.Name = "groupBox_Background";
            this.groupBox_Background.Size = new System.Drawing.Size(186, 150);
            this.groupBox_Background.TabIndex = 9;
            this.groupBox_Background.TabStop = false;
            this.groupBox_Background.Text = "背景";
            // 
            // label_line_h
            // 
            this.label_line_h.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_line_h.Location = new System.Drawing.Point(12, 348);
            this.label_line_h.Name = "label_line_h";
            this.label_line_h.Size = new System.Drawing.Size(368, 2);
            this.label_line_h.TabIndex = 11;
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Location = new System.Drawing.Point(213, 194);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.Size = new System.Drawing.Size(167, 147);
            this.richTextBox_Log.TabIndex = 12;
            this.richTextBox_Log.Text = "Logs:\n";
            this.richTextBox_Log.TextChanged += new System.EventHandler(this.richTextBox_Log_TextChanged);
            // 
            // button_Switch
            // 
            this.button_Switch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Switch.Location = new System.Drawing.Point(213, 354);
            this.button_Switch.Name = "button_Switch";
            this.button_Switch.Size = new System.Drawing.Size(167, 60);
            this.button_Switch.TabIndex = 13;
            this.button_Switch.Text = "开始捕获";
            this.button_Switch.UseVisualStyleBackColor = true;
            this.button_Switch.Click += new System.EventHandler(this.button_Switch_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(12, 354);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(55, 13);
            this.label_Status.TabIndex = 14;
            this.label_Status.Text = "运行状态";
            // 
            // label_Status_Value
            // 
            this.label_Status_Value.AutoSize = true;
            this.label_Status_Value.Location = new System.Drawing.Point(12, 373);
            this.label_Status_Value.Name = "label_Status_Value";
            this.label_Status_Value.Size = new System.Drawing.Size(43, 13);
            this.label_Status_Value.TabIndex = 15;
            this.label_Status_Value.Text = "未捕获";
            // 
            // backgroundWorker_Open_Display_Form
            // 
            this.backgroundWorker_Open_Display_Form.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Open_Display_Form_DoWork);
            this.backgroundWorker_Open_Display_Form.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Open_Display_Form_RunWorkerCompleted);
            // 
            // backgroundWorker_Get_Title
            // 
            this.backgroundWorker_Get_Title.WorkerSupportsCancellation = true;
            this.backgroundWorker_Get_Title.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Get_Title_DoWork);
            // 
            // checkBox_TopMost
            // 
            this.checkBox_TopMost.AutoSize = true;
            this.checkBox_TopMost.Location = new System.Drawing.Point(213, 171);
            this.checkBox_TopMost.Name = "checkBox_TopMost";
            this.checkBox_TopMost.Size = new System.Drawing.Size(74, 17);
            this.checkBox_TopMost.TabIndex = 16;
            this.checkBox_TopMost.Text = "窗口置顶";
            this.checkBox_TopMost.UseVisualStyleBackColor = true;
            this.checkBox_TopMost.CheckedChanged += new System.EventHandler(this.checkBox_TopMost_CheckedChanged);
            // 
            // label_Copyright
            // 
            this.label_Copyright.AutoSize = true;
            this.label_Copyright.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Copyright.Location = new System.Drawing.Point(12, 397);
            this.label_Copyright.Name = "label_Copyright";
            this.label_Copyright.Size = new System.Drawing.Size(150, 13);
            this.label_Copyright.TabIndex = 17;
            this.label_Copyright.Text = "v0.1 Beta 作者：林子易 h-kys";
            // 
            // Form_Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 419);
            this.Controls.Add(this.label_Copyright);
            this.Controls.Add(this.checkBox_TopMost);
            this.Controls.Add(this.label_Status_Value);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button_Switch);
            this.Controls.Add(this.richTextBox_Log);
            this.Controls.Add(this.label_line_h);
            this.Controls.Add(this.groupBox_Display);
            this.Controls.Add(this.groupBox_Background);
            this.Controls.Add(this.groupBox_Font);
            this.Controls.Add(this.label_line_v);
            this.Controls.Add(this.label_Catch_Speed_Value);
            this.Controls.Add(this.label_Catch_Speed);
            this.Controls.Add(this.trackBar_Catch_Speed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form_Main_Window";
            this.Text = "网易云音乐播放抓取";
            this.Load += new System.EventHandler(this.Form_Main_Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Catch_Speed)).EndInit();
            this.groupBox_Font.ResumeLayout(false);
            this.groupBox_Font.PerformLayout();
            this.groupBox_Display.ResumeLayout(false);
            this.groupBox_Display.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Background_Transparent)).EndInit();
            this.groupBox_Background.ResumeLayout(false);
            this.groupBox_Background.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar_Catch_Speed;
        private System.Windows.Forms.FontDialog fontDialog_Display_Font;
        private System.Windows.Forms.Label label_Font;
        private System.Windows.Forms.Label label_Catch_Speed;
        private System.Windows.Forms.Label label_Catch_Speed_Value;
        private System.Windows.Forms.Label label_line_v;
        private System.Windows.Forms.Button button_Change_Font;
        private System.Windows.Forms.GroupBox groupBox_Font;
        private System.Windows.Forms.GroupBox groupBox_Display;
        private System.Windows.Forms.RadioButton radioButton_Display_No_Rolling;
        private System.Windows.Forms.TextBox textBox_Display_Window_Size_Value;
        private System.Windows.Forms.Label label_Display_Window_Size;
        private System.Windows.Forms.RadioButton radioButton_Display_Rolling;
        private System.Windows.Forms.RadioButton radioButton_Background_Full_Transparent;
        private System.Windows.Forms.RadioButton radioButton_Background_Custom;
        private System.Windows.Forms.Label label_Background_Color;
        private System.Windows.Forms.Label label_Background_Color_Preview;
        private System.Windows.Forms.Label label_Background_Transparent;
        private System.Windows.Forms.Label label_Background_Transparent_Value;
        private System.Windows.Forms.TrackBar trackBar_Background_Transparent;
        private System.Windows.Forms.GroupBox groupBox_Background;
        private System.Windows.Forms.Label label_line_h;
        private System.Windows.Forms.RichTextBox richTextBox_Log;
        private System.Windows.Forms.Button button_Switch;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_Status_Value;
        private System.Windows.Forms.RichTextBox richTextBox_Font_Preview;
        private System.Windows.Forms.ColorDialog colorDialog_Display_Font;
        private System.Windows.Forms.ColorDialog colorDialog_Background;
        private System.Windows.Forms.Label label_Font_Color_Preview;
        private System.Windows.Forms.Label label_Font_Color;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Open_Display_Form;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Get_Title;
        private System.Windows.Forms.CheckBox checkBox_TopMost;
        private System.Windows.Forms.Label label_Copyright;
    }
}

