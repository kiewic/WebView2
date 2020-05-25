using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace WebView2App
{
    public partial class Form1 : Form
    {
        WebView2 webView;

        public Form1()
        {
            InitializeComponent();

            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            webView.Source = new Uri("https://example.com");
            this.Controls.Add(webView);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Delay(7000);
            webView.CoreWebView2.Navigate("https://kiewic.com");
        }
    }
}
