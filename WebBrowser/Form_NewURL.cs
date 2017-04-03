using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form_NewURL : Form
    {
        public Form_NewURL()
        {
            InitializeComponent();
        }

        private void btn_tamam_Click(object sender, EventArgs e)
        {
            Form_Main f = new Form_Main();
            File.WriteAllText(@"url.txt", txtbox_URL.Text);
            Process.Start(Application.ExecutablePath);
            Application.Exit();
        }
    }
}
