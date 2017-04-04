using System;
using System.IO;
using System.Security.Permissions;
using System.Windows.Forms;

namespace WebBrowser
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public partial class Form_Main : Form
    {
        string address;
        ContextMenuStrip menu = new ContextMenuStrip();

        public Form_Main()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            if (File.Exists(@"url.txt"))
            {
                string[] lines = File.ReadAllLines(@"url.txt");
                if (!lines.Equals(""))
                    address = lines[0];
                else
                    address = "www.google.com";
            }
            else
                address = "www.google.com";

            NavigateToURL(address);
            menu.Items.Add("Exit", null, menu_clicked);
            menu.Items.Add("Change URL", null, menu_clicked);
        }

        public void NavigateToURL(string address)
        {
            if (string.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") && !address.StartsWith("https://"))
                address = "http://" + address;
            try
            {
                webBrowser.Navigate(new Uri(address));
            }
            catch (UriFormatException)
            {
                return;
            }
        }

        private void menu_clicked(object sender, EventArgs e)
        {
            var clickedItem = sender;

            if(clickedItem.ToString() == "Exit") Environment.Exit(0);
            else
            {
                Form_NewURL nURL = new Form_NewURL();
                nURL.ShowDialog();
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser.Document.MouseDown += Document_Click;
        }
        
        private void Document_Click(object sender, HtmlElementEventArgs e)
        {
            if (e.MouseButtonsPressed == MouseButtons.Right)
                menu.Show(Cursor.Position);
        }
    }
}
