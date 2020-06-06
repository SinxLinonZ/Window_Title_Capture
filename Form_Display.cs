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
//using System.Runtime.InteropServices;
//using Microsoft.Xna.Framework.Graphics;


namespace Live_Netease_Music_Title
{


    public partial class Form_Display : Form
    {

        public static Form_Display G_formDisplay;

        private static bool customBackground = Form_Main_Window.G_customBackground;
        private static Color customDisplayBackColor;
        private static bool displayRolling;

        private bool mouseDown;
        private Point lastLocation;

        private bool topMost = false;
        private bool penetrate = false;

        private int offset = 0;
        private int timerTime = 0;

        public Form_Display()
        {
            InitializeComponent();
            G_formDisplay = this;
            C_updateSettings();
        }

        private void Form_Display_Load(object sender, EventArgs e)
        {
            C_updateSettings();

        }

        private void label_Display_Click(object sender, EventArgs e)
        {

        }

        public void C_updateSettings()
        {
            offset = label_Display.Size.Width - G_formDisplay.Size.Width;

            label_Display.Font = Form_Main_Window.G_displayFont;
            label_Display.ForeColor = Form_Main_Window.G_displayColor;
            customDisplayBackColor = Form_Main_Window.G_customDisplayBackColor;
            label_Display.Text = Form_Main_Window.G_title;

            displayRolling = Form_Main_Window.G_displayModeRolling;
            customBackground = Form_Main_Window.G_customBackground;

            topMost = Form_Main_Window.G_topMost;

            label_Display.Location = new Point(0, 0);

            //    penetrate = Form_Main_Window.G_Penetrate;

            if (G_formDisplay.TopMost != topMost)
            {
                G_formDisplay.TopMost = Form_Main_Window.G_topMost;
            }
        //    if (Form_Main_Window.G_Penetrate != penetrate)
        //    {
        //        SetPenetrate(Form_Main_Window.G_Penetrate);
        //    }

            if (!customBackground)
            {
                G_formDisplay.BackColor = SystemColors.Control;
                G_formDisplay.TransparencyKey = SystemColors.Control;
            }
            else
            {
                G_formDisplay.TransparencyKey = SystemColors.MenuHighlight;
                G_formDisplay.BackColor = customDisplayBackColor;
                //G_formDisplay.TransparencyKey = Color.Empty;
                // Unknown Error.
                // Randomly get error if set to Color.Empty.
                G_formDisplay.Opacity = Form_Main_Window.G_customDisplayBackTransValue/100.0;
            }

            if (!displayRolling)
            {
                //G_formDisplay.Size = new Size(label_Display.Size.Width-1, label_Display.Size.Height) ;
                G_formDisplay.Size = new Size(label_Display.Size.Width, label_Display.Size.Height) ;
            }
            else
            {

                //G_formDisplay.Size = new Size(Form_Main_Window.G_displayRollingSize - 1, label_Display.Size.Height);
                G_formDisplay.Size = new Size(Form_Main_Window.G_displayRollingSize - 1, label_Display.Size.Height);

                if (label_Display.Size.Width > G_formDisplay.Size.Width)
                {
                    timerTime = 0;
                    timer_Rolling.Start();
                } 
                else
                {
                    timerTime = 0;
                }

            }
        }


        private void timer_Rolling_Tick(object sender, EventArgs e)
        {
            offset = label_Display.Size.Width - G_formDisplay.Size.Width;
            if (offset <= 0)
            {
                return;
            }
            if (timerTime > 2 * 100 && timerTime <= 2 * 100 + offset)
            {
                if (Math.Abs(label_Display.Left) < offset)
                {
                    //label_Display.Location = new Point(label_Display.Left--, 0);
                    label_Display.Location = new Point(label_Display.Location.X - 1, 0);
                    //label_Display.Left -= 1;
                }
            }
            if (timerTime > 2 * 100 + offset + 2 * 100)
            {
                if (Math.Abs(label_Display.Left) > 0)
                {
                    //label_Display.Location = new Point(label_Display.Left++, 0);
                    label_Display.Location = new Point(label_Display.Location.X + 1, 0);
                    //label_Display.Left -= 1;
                }
                else
                {
                    timerTime = 0;
                }
            }
            timerTime++;
        }


        private void Form_Display_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_Display_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form_Display_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label_Display_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                G_formDisplay.Location = new Point(
                    (G_formDisplay.Location.X - lastLocation.X) + e.X, (G_formDisplay.Location.Y - lastLocation.Y) + e.Y);

                G_formDisplay.Update();
            }

        }









        /*
                private const uint WS_EX_LAYERED = 0x80000;
                private const int WS_EX_TRANSPARENT = 0x20;
                private const int GWL_STYLE = (-16);
                private const int GWL_EXSTYLE = (-20);
                private const int LWA_ALPHA = 0;

                [DllImport("user32", EntryPoint = "SetWindowLong")]
                private static extern uint SetWindowLong(
                IntPtr hwnd,
                int nIndex,
                uint dwNewLong
                );

                [DllImport("user32", EntryPoint = "GetWindowLong")]
                private static extern uint GetWindowLong(
                IntPtr hwnd,
                int nIndex
                );

                [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
                private static extern int SetLayeredWindowAttributes(
                IntPtr hwnd,
                int crKey,
                int bAlpha,
                int dwFlags
                );

                public void SetPenetrate(bool flag = true)
                {
                    uint style = GetWindowLong(this.Handle, GWL_EXSTYLE);
                    if (flag)
                        SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_TRANSPARENT | WS_EX_LAYERED);
                    else
                        SetWindowLong(this.Handle, GWL_EXSTYLE, style & ~(WS_EX_TRANSPARENT | WS_EX_LAYERED));
                    SetLayeredWindowAttributes(this.Handle, 0, 100, LWA_ALPHA);
                }
        */

    }
}

