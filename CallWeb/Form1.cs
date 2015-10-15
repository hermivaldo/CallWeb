using System;
using System.Windows.Forms;

namespace CallWeb
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
           // webBrowser1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebBrowser broser = new WebBrowser();
            webBrowser1.Navigate("");
            
        }


        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.Equals(""))
            {
                webBrowser1.Document.GetElementById("name").InnerText = "";
                webBrowser1.Document.GetElementById("password").InnerText = "";

                HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("input");
                foreach (HtmlElement el in elc)
                {
                    if (el.GetAttribute("type").Equals("submit"))
                    {
                        el.InvokeMember("Click");
                    }
                }
            }
            
        }
    }
}
