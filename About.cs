using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Live_Netease_Music_Title
{
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void label_Tester_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_TesterValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://space.bilibili.com/9598325/");
        }

        private void linkLabel_SourceCodeValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SinxLinonZ/Window_Title_Capture/");
        }
    }
}
