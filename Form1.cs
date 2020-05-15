using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Live_Netease_Music_Title
{
    public partial class Form_Main_Window : Form
    {
        public static int G_catchSpeed = 2000;
        
        public static Font G_displayFont;
        public static Color G_displayColor;

        public static bool G_customBackground = false;
        public static Color G_customDisplayBackColor;
        public static bool G_customDisplayBackTrans;
        public static int G_customDisplayBackTransValue = 100;

        public static bool G_displayModeRolling = false;
        public static int G_displayRollingSize = 400;

        public static bool running = false;

        public static int G_process_ID;
        public static string G_last_title;
        public static string G_title;

        public static bool G_topMost = false;
//        public static bool G_Penetrate = false;

        public Form_Main_Window()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void Form_Main_Window_Load(object sender, EventArgs e)
        {
            label_Font_Color_Preview.BackColor = richTextBox_Font_Preview.ForeColor;

            backgroundWorker_Open_Display_Form.RunWorkerAsync();

        }

        private void button_Change_Font_Click(object sender, EventArgs e)
        {
            if (fontDialog_Display_Font.ShowDialog() != DialogResult.Cancel)
            {
                G_displayFont = richTextBox_Font_Preview.Font = fontDialog_Display_Font.Font;
                Form_Display.G_formDisplay.C_updateSettings();
            }
        }

        private void fontDialog_Display_Font_Apply(object sender, EventArgs e)
        {
            G_displayFont = richTextBox_Font_Preview.Font = fontDialog_Display_Font.Font;
            Form_Display.G_formDisplay.C_updateSettings();
        }

        private void label_Font_Color_Preview_Click(object sender, EventArgs e)
        {
            if (colorDialog_Display_Font.ShowDialog() != DialogResult.Cancel)
            {
                G_displayColor = richTextBox_Font_Preview.ForeColor = label_Font_Color_Preview.BackColor = colorDialog_Display_Font.Color;
                Form_Display.G_formDisplay.C_updateSettings();
            }
        }

        private void label_Background_Color_Preview_Click(object sender, EventArgs e)
        {

            if (!G_customBackground)
            {
                return;
            }

            if (colorDialog_Background.ShowDialog() != DialogResult.Cancel)
            {
                G_customDisplayBackColor = richTextBox_Font_Preview.BackColor = label_Background_Color_Preview.BackColor = colorDialog_Background.Color;
                Form_Display.G_formDisplay.C_updateSettings();
            }

        }

        private void trackBar_Catch_Speed_Scroll(object sender, EventArgs e)
        {

            int smallChangeValue = 50;
            int trackValue, source_trackValue;

            source_trackValue = trackValue = trackBar_Catch_Speed.Value;

            if (trackValue % smallChangeValue != 0)
            {

                trackValue = (trackValue / smallChangeValue) * smallChangeValue;

                if (source_trackValue == trackValue + 3)
                {
                    trackBar_Catch_Speed.Value = trackValue + smallChangeValue;
                } else
                {
                    trackBar_Catch_Speed.Value = trackValue;
                }

            }

            G_catchSpeed = trackBar_Catch_Speed.Value;
            label_Catch_Speed_Value.Text = G_catchSpeed.ToString();
        }

        private void radioButton_Background_Full_Transparent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Background_Full_Transparent.Checked) {
                G_customBackground = false;

                richTextBox_Font_Preview.BackColor = System.Drawing.SystemColors.Control;

                label_Background_Color.ForeColor = System.Drawing.SystemColors.ControlDark;
                label_Background_Color_Preview.BackColor = System.Drawing.SystemColors.Control;

                trackBar_Background_Transparent.Enabled = false;
                label_Background_Transparent.ForeColor = System.Drawing.SystemColors.ControlDark;
                label_Background_Transparent_Value.ForeColor = System.Drawing.SystemColors.ControlDark;


                Form_Display.G_formDisplay.C_updateSettings();
            }
        }

        private void radioButton_Background_Custom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Background_Custom.Checked)
            {
                G_customBackground = true;
                if (G_customDisplayBackColor != null)
                {
                    label_Background_Color_Preview.BackColor = G_customDisplayBackColor;
                } else
                {
                    G_customDisplayBackColor = label_Background_Color_Preview.BackColor = System.Drawing.Color.White;
                }

                trackBar_Background_Transparent.Enabled = true;
                label_Background_Transparent.ForeColor = System.Drawing.SystemColors.ControlText;
                label_Background_Transparent_Value.ForeColor = System.Drawing.SystemColors.ControlText;

                richTextBox_Font_Preview.BackColor = G_customDisplayBackColor;
                label_Background_Color.ForeColor = System.Drawing.SystemColors.ControlText;

                Form_Display.G_formDisplay.C_updateSettings();
            }
        }

        private void radioButton_Display_No_Rolling_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Display_No_Rolling.Checked)
            {
                label_Display_Window_Size.ForeColor = System.Drawing.SystemColors.ControlDark;
                textBox_Display_Window_Size_Value.Enabled = false;
                G_displayModeRolling = false;
                Form_Display.G_formDisplay.C_updateSettings();

            }

        }

        private void radioButton_Display_Rolling_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Display_Rolling.Checked)
            {
                label_Display_Window_Size.ForeColor = System.Drawing.SystemColors.ControlText;
                textBox_Display_Window_Size_Value.Enabled = true;
                G_displayModeRolling = true;
                Form_Display.G_formDisplay.C_updateSettings();


            }
        }

        private void textBox_Display_Window_Size_Value_TextChanged(object sender, EventArgs e)
        {

            var selfText = textBox_Display_Window_Size_Value.Text;
            int selfInt;

            if (selfText == "" || Int32.Parse(selfText) == 0)
            {
                textBox_Display_Window_Size_Value.Text = "400";
                G_displayRollingSize = 400;
                Form_Display.G_formDisplay.C_updateSettings();
                return;
            }


            selfText = System.Text.RegularExpressions.Regex.Replace(selfText, @"[^0-9]+", "");
            selfInt = Int32.Parse(selfText);

            textBox_Display_Window_Size_Value.Text = selfInt.ToString();

            if (selfInt > 1920)
            {
                textBox_Display_Window_Size_Value.Text = "1920";
                //G_displayRollingSize = Int32.Parse(textBox_Display_Window_Size_Value.Text);
                G_displayRollingSize = 1920;
                Form_Display.G_formDisplay.C_updateSettings();
                return;
            }
            G_displayRollingSize = selfInt;
            Form_Display.G_formDisplay.C_updateSettings();
        }

        private void textBox_Display_Window_Size_Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void backgroundWorker_Open_Display_Form_DoWork(object sender, DoWorkEventArgs e)
        {
            Application.Run(new Form_Display());
        }

        private void backgroundWorker_Open_Display_Form_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private int C_getProcessID()
        {
            bool get = false;

            var info = Process.GetProcessesByName("cloudmusic");
            if (info.Length > 0)
            {
                label_Status_Value.Text = "已捕获网易云音乐进程组";
                richTextBox_Log.Text += "已捕获网易云音乐进程组\r\n";
                foreach (var process in info)
                {
                    if (!string.IsNullOrEmpty(process.MainWindowTitle))
                    {
                        G_last_title = G_title = process.MainWindowTitle;
                        G_process_ID = process.Id;
                        get = true;
                        label_Status_Value.Text = "正在循环捕获...";
                        richTextBox_Log.Text += "已找到网易云音乐主窗体。进程ID：" + G_process_ID + "\r\n";
                        richTextBox_Log.Text += "检测到曲目切换\r\n" + G_title + "\r\n";
                        Form_Display.G_formDisplay.C_updateSettings();
                        return 0;
                    }
                }
                if (!get)
                {
                    label_Status_Value.Text = "未捕获（异常终止）";
                    richTextBox_Log.Text += "错误：没有找到网易云音乐主窗体，已停止捕获\r\n";
                    button_Switch.Text = "开始捕获";
                    running = false;
                    return -1;
                }
            } 
            else
            {
                label_Status_Value.Text = "未捕获（异常终止）";
                richTextBox_Log.Text += "错误：没有找到网易云音乐进程，已停止捕获\r\n";
                button_Switch.Text = "开始捕获";
                running = false;
                return -1;
            }

            label_Status_Value.Text = "未捕获（异常终止）";
            richTextBox_Log.Text += "错误：进程获取函数异常，已停止捕获\r\n";
            button_Switch.Text = "开始捕获";
            running = false;
            return -1;
        }


        private void button_Switch_Click(object sender, EventArgs e)
        {

            running = !running;

            if (running)
            {
                button_Switch.Text = "停止捕获";

                label_Status_Value.Text = "正在捕获网易云音乐进程组";
                richTextBox_Log.Text += "正在捕获网易云音乐进程组\r\n";

                if (C_getProcessID() == 0)
                {
                    backgroundWorker_Get_Title.RunWorkerAsync();
                }
            }
            else
            {
                label_Status_Value.Text = "正在停止捕获，请稍等...";
                richTextBox_Log.Text += "正在停止捕获\r\n";
                richTextBox_Log.Text += "请等待"+ (G_catchSpeed/1000).ToString()+ "秒\r\n";
                button_Switch.Text = "正在停止...";
                button_Switch.Enabled = false;

                backgroundWorker_Get_Title.CancelAsync();
                System.Threading.Thread.Sleep(G_catchSpeed);

                label_Status_Value.Text = "未捕获（用户正常终止）";
                richTextBox_Log.Text += "已停止捕获\r\n";
                richTextBox_Log.Text += "----------------\r\n";
                button_Switch.Text = "开始捕获";
                button_Switch.Enabled = true;
            }
        }

        private void backgroundWorker_Get_Title_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {

                if (backgroundWorker_Get_Title.CancellationPending)
                {
                    break;
                }

                try
                {
                    var process = Process.GetProcessById(G_process_ID);
                    G_title = process.MainWindowTitle;

                    if (G_title == G_last_title)
                    {
                        System.Threading.Thread.Sleep(G_catchSpeed);
                        continue;
                    }
                    else
                    {
                        G_last_title = G_title;
                        Form_Display.G_formDisplay.C_updateSettings();
                        richTextBox_Log.Text += "检测到曲目切换\r\n" + G_title + "\r\n";
                    }

                    System.Threading.Thread.Sleep(G_catchSpeed);

                }
                catch (Exception exited_e)
                {
                    label_Status_Value.Text = "未捕获（异常终止）";
                    richTextBox_Log.Text += "错误：网易云音乐进程可能被关闭，已停止捕获\r\n";
                    richTextBox_Log.Text += exited_e.Message + "\r\n";
                    button_Switch.Text = "开始捕获";
                    running = false;
                    break;
                }
            }

        }

        private void richTextBox_Log_TextChanged(object sender, EventArgs e)
        {
            richTextBox_Log.SelectionStart = richTextBox_Log.Text.Length;
            richTextBox_Log.ScrollToCaret();
        }

        private void trackBar_Background_Transparent_Scroll(object sender, EventArgs e)
        {

            int smallChangeValue = 5;
            int trackValue, source_trackValue;

            source_trackValue = trackValue = trackBar_Background_Transparent.Value;

            if (trackValue % smallChangeValue != 0)
            {

                trackValue = (trackValue / smallChangeValue) * smallChangeValue;

                if (source_trackValue == trackValue + 3)
                {
                    trackBar_Background_Transparent.Value = trackValue + smallChangeValue;
                }
                else
                {
                    trackBar_Background_Transparent.Value = trackValue;
                }

            }

            G_customDisplayBackTransValue = trackBar_Background_Transparent.Value;
            label_Background_Transparent_Value.Text = G_customDisplayBackTransValue.ToString() + "%";

            Form_Display.G_formDisplay.C_updateSettings();
        }

        private void checkBox_TopMost_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_TopMost.Checked)
            {
                G_topMost = true;
            } else
            {
                G_topMost = false;
            }

            Form_Display.G_formDisplay.C_updateSettings();

        }
    }
}
