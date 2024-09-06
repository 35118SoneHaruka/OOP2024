using System;
using System.Collections;
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
        private Dictionary<string, string> website; 
        private List<ItemData> xdocs;
        public Form1() {
            InitializeComponent();
            getCombobox();
        }

        private void btGet_Click(object sender, EventArgs e) {
            var text = "https";
            if (comboBox1.Text.Contains(text)) {
                using (var wc = new WebClient()) {
                    var url = wc.OpenRead(comboBox1.Text);
                    var xdoc = XDocument.Load(url);
                    xdocs = xdoc.Root.Descendants("item").Select(item => new ItemData { Title = item.Element("title").Value, link = item.Element("link").Value }).ToList();
                    foreach (var xdocument in xdocs) {
                        lbRssTitle.Items.Add(xdocument.Title);
                    }
                }
            } else {
                using (var wc = new WebClient()) {
                    var url = wc.OpenRead(website[comboBox1.Text]);
                    var xdoc = XDocument.Load(url);
                    xdocs = xdoc.Root.Descendants("item").Select(item => new ItemData { Title = item.Element("title").Value, link = item.Element("link").Value }).ToList();
                    foreach (var xdocument in xdocs) {
                        lbRssTitle.Items.Add(xdocument.Title);
                    }
                }
            }

           
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            Uri websiteUri = new Uri(xdocs[lbRssTitle.SelectedIndex].link);
            webView21.Source = websiteUri;
        }

        private void getCombobox() {
           website = new Dictionary<string, string>() {
               {"主要","https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
               {"国内","https://news.yahoo.co.jp/rss/topics/domestic.xml" },
               {"国際","https://news.yahoo.co.jp/rss/topics/world.xml" },
               {"経済","https://news.yahoo.co.jp/rss/topics/business.xml" },
               {"エンタメ","https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
               {"スポーツ","https://news.yahoo.co.jp/rss/topics/sports.xml" },
               {"IT","https://news.yahoo.co.jp/rss/topics/it.xml" },
               {"科学","https://news.yahoo.co.jp/rss/topics/science.xml" },
               {"地域","https://news.yahoo.co.jp/rss/topics/local.xml" }

           };
            comboBox1.Items.AddRange(website.Keys.ToArray());
        }

        private void button1_Click(object sender, EventArgs e) {
            website.Add(textBox1.Text,comboBox1.Text);
            comboBox1.Items.Add(GetKeyFromValue(website, comboBox1.Text));
            comboBox1.Text = "";
            textBox1.Text = "";
        }

        static string GetKeyFromValue(Dictionary<string, string> dictionary, string value) {
            return dictionary.FirstOrDefault(kvp => kvp.Value == value).Key;
        }
    }

    public class ItemData {
        public string Title { get; set; }
        public string link { get; set; }
    }
}
