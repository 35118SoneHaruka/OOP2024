using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
   

    public partial class Form1 : Form {
        private List<ItemData> xdocs;
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {

            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbRssUrl.Text);
                var xdoc = XDocument.Load(url);
                xdocs = xdoc.Root.Descendants("item").Select(item => new ItemData { Title = item.Element("title").Value, link = item.Element("link").Value }).ToList();
                foreach (var xdocument in xdocs) {
                    lbRssTitle.Items.Add(xdocument.Title);
                }
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            Uri websiteUri = new Uri(xdocs[lbRssTitle.SelectedIndex].link);
            webView21.Source = websiteUri;
            //webView21.CoreWebView2.Navigate(xdocs[lbRssTitle.SelectedIndex].link);
        }
    }
    public class ItemData {
        public string Title { get; set; }
        public string link { get; set; }
    }
}
