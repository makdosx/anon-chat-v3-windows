using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;


namespace Anon
{
    public partial class Anon : Form
    {
        public Anon()
        {
            InitializeComponent();
            InitBrowser();

            //Method 1. center at initilization
            //this.StartPosition = FormStartPosition.CenterScreen;

            //Method 2. The manual way
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 3;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

        }

        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("http://anon.www1.gr/");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
    }
}
