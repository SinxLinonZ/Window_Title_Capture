using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_Netease_Music_Title.Properties;

namespace Live_Netease_Music_Title
{
    public partial class Form_Main_Window : Form
    {
        //  Define Variables for Global Use

        public static Font G_displayFont;
        public static Color G_displayColor;

        public static bool G_customBackground = false;
        public static Color G_customDisplayBackColor;
        //public static bool G_customDisplayBackTrans;
        public static int G_customDisplayBackTransValue = 100;

        public static bool G_displayModeRolling = false;
        public static int G_displayRollingSize = 400;

        public static bool running = false;

        public static int G_process_ID;
        public static IntPtr G_process_Handle;
        public static string G_last_title;
        public static string G_title;

        public static bool G_topMost = false;
        //        public static bool G_Penetrate = false;

        public static Form_Main_Window MainForm = null;

        public static IntPtr hhook = new IntPtr();


        public Form_Main_Window()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            MainForm = this;
        }

        private void Form_Main_Window_Load(object sender, EventArgs e)
        {
            //  Open Second Form
            backgroundWorker_Open_Display_Form.RunWorkerAsync();

            //  Load Save Settings if Exists
            if (Settings.Default.Changed)
            {
                G_displayFont = Settings.Default.G_displayFont;
                G_displayColor = Settings.Default.G_displayColor;

                G_customBackground = Settings.Default.G_customBackground;
                G_customDisplayBackColor = Settings.Default.G_customDisplayBackColor;
                G_customDisplayBackTransValue = Settings.Default.G_customDisplayBackTransValue;

                G_displayModeRolling = Settings.Default.G_displayModeRolling;
                G_displayRollingSize = Settings.Default.G_displayRollingSize;

                G_topMost = Settings.Default.G_topMost;

                Settings.Default.Changed = true;

                richTextBox_Font_Preview.Font = G_displayFont;
                label_Font_Color_Preview.BackColor = 
                    richTextBox_Font_Preview.ForeColor = 
                    G_displayColor;

                if (!G_customBackground)
                {
                    radioButton_Background_Full_Transparent.Checked = true;
                    radioButton_Background_Custom.Checked = false;
                    label_Background_Color.ForeColor =
                        label_Background_Transparent.ForeColor =
                        label_Background_Transparent_Value.ForeColor =
                        SystemColors.ControlDark;
                    richTextBox_Font_Preview.BackColor = 
                        label_Background_Color_Preview.BackColor = 
                        SystemColors.Control;
                    label_Background_Transparent_Value.Text = G_customDisplayBackTransValue.ToString() + "%";
                    trackBar_Background_Transparent.Value = G_customDisplayBackTransValue;
                    trackBar_Background_Transparent.Enabled = false;
                } else
                {
                    radioButton_Background_Full_Transparent.Checked = false;
                    radioButton_Background_Custom.Checked = true;
                    label_Background_Color.ForeColor =
                        label_Background_Transparent.ForeColor =
                        label_Background_Transparent_Value.ForeColor =
                        SystemColors.ControlText;
                    richTextBox_Font_Preview.BackColor = 
                        label_Background_Color_Preview.BackColor = 
                        G_customDisplayBackColor;
                    label_Background_Transparent_Value.Text = G_customDisplayBackTransValue.ToString() + "%";
                    trackBar_Background_Transparent.Value = G_customDisplayBackTransValue;
                    trackBar_Background_Transparent.Enabled = true;
                }

                if (!G_displayModeRolling)
                {
                    radioButton_Display_No_Rolling.Checked = true;
                    radioButton_Display_Rolling.Checked = false;
                    label_Display_Window_Size.ForeColor = SystemColors.ControlDark;
                    textBox_Display_Window_Size_Value.Enabled = false;
                    textBox_Display_Window_Size_Value.Text = G_displayRollingSize.ToString();
                } else
                {
                    radioButton_Display_No_Rolling.Checked = false;
                    radioButton_Display_Rolling.Checked = true;
                    label_Display_Window_Size.ForeColor = SystemColors.ControlText;
                    textBox_Display_Window_Size_Value.Enabled = true;
                    textBox_Display_Window_Size_Value.Text = G_displayRollingSize.ToString();
                }

                checkBox_TopMost.Checked = G_topMost;

                richTextBox_Log.Text += "找到上一次配置，已载入\r\n";

            } 
            else
            {
                richTextBox_Log.Text += "没有找到上一次配置，初始化配置\r\n";
            }

            Form_Display.G_formDisplay.C_updateSettings();
        }

        //  Save Settings when Closed
        private void Form_Main_Window_FormClosing(object sender, FormClosingEventArgs e)
        {

            Settings.Default.G_displayFont = G_displayFont;
            Settings.Default.G_displayColor = G_displayColor;

            Settings.Default.G_customBackground = G_customBackground;
            Settings.Default.G_customDisplayBackColor = G_customDisplayBackColor;
            Settings.Default.G_customDisplayBackTransValue = G_customDisplayBackTransValue;

            Settings.Default.G_displayModeRolling = G_displayModeRolling;
            Settings.Default.G_displayRollingSize = G_displayRollingSize;

            Settings.Default.G_topMost = G_topMost;

            Settings.Default.Changed = true;

            Settings.Default.Save();

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

        //  Exit whole Application if Second Window has been closed
        private void backgroundWorker_Open_Display_Form_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Environment.Exit(0);
        }



        //  Get Process ID and Handle
        //  Import WindowsAPI function
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        public static string GetWindowTitle(IntPtr hWnd)
        {
            var length = GetWindowTextLength(hWnd) + 1;
            var title = new StringBuilder(length);
            GetWindowText(hWnd, title, length);
            return title.ToString();
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
                        G_process_ID = process.Id;
                        G_process_Handle = process.MainWindowHandle;
                        G_last_title = G_title = GetWindowTitle(G_process_Handle);
                        get = true;
                        label_Status_Value.Text = "正在循环捕获...";
                        richTextBox_Log.Text += "已找到网易云音乐主窗体。进程ID：" + G_process_ID + "\r\n";
                        richTextBox_Log.Text += "Handle：" + G_process_Handle + "\r\n";
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
                    hhook = SetWinEventHook(EVENT_OBJECT_NAMECHANGE, EVENT_OBJECT_NAMECHANGE, IntPtr.Zero,
        procDelegate, Convert.ToUInt32(G_process_ID), 0, WINEVENT_OUTOFCONTEXT);
                }
            }
            else
            {
                label_Status_Value.Text = "正在停止捕获，请稍等...";
                richTextBox_Log.Text += "正在停止捕获\r\n";
                button_Switch.Text = "正在停止...";
                button_Switch.Enabled = false;

                UnhookWinEvent(hhook);

                label_Status_Value.Text = "未捕获（用户正常终止）";
                richTextBox_Log.Text += "已停止捕获\r\n";
                richTextBox_Log.Text += "----------------\r\n";
                button_Switch.Text = "开始捕获";
                button_Switch.Enabled = true;
            }
        }



        //  Event Hook
        //  Import WindowsAPI
        delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType,
    IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

        [DllImport("user32.dll")]
        static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr
           hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess,
           uint idThread, uint dwFlags);

        [DllImport("user32.dll")]
        static extern bool UnhookWinEvent(IntPtr hWinEventHook);

        //const uint EVENT_SYSTEM_FOREGROUND = 3;
        const uint EVENT_OBJECT_NAMECHANGE = 0x800C;
        const uint WINEVENT_OUTOFCONTEXT = 0;

        static WinEventDelegate procDelegate = new WinEventDelegate(WinEventProc);

        static void WinEventProc(IntPtr hWinEventHook, uint eventType,
            IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            G_title = GetWindowTitle(G_process_Handle);
            if (G_title != G_last_title)
            {
                G_last_title = G_title;
                Form_Display.G_formDisplay.C_updateSettings();
                MainForm.richTextBox_Log.Text += "检测到曲目切换\r\n" + G_title + "\r\n";
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

        private void timer_ExitCheck_Tick(object sender, EventArgs e)
        {
            if (running)
            {
                try
                {
                    var process = Process.GetProcessById(G_process_ID);
                }
                catch (Exception exited_e)
                {
                    MainForm.label_Status_Value.Text = "未捕获（异常终止）";
                    MainForm.richTextBox_Log.Text += "错误：网易云音乐进程可能被关闭，已停止捕获\r\n";
                    MainForm.richTextBox_Log.Text += exited_e.Message + "\r\n";
                    MainForm.button_Switch.Text = "开始捕获";
                    running = false;
                }
            }
            else
            {
                G_title = "";
                Form_Display.G_formDisplay.C_updateSettings();
            }
        }
    }
}
