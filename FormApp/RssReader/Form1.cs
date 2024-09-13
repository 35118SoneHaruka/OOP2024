using Microsoft.Web.WebView2.Core;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RssReader {
   

    public partial class Form1 : Form {

        static List<string> immutableKeys = new List<string> { "主要", "国内", "国際", "経済", "エンタメ", "スポーツ", "IT", "科学", "地域" };
        private Dictionary<string, string> website = new ImmutableKeyDictionary<string, string>(immutableKeys);
        private List<ItemData> xdocs;

        public Form1() {
            InitializeComponent();
            getCombobox();
        }

        //取得ボタン
        private void btGet_Click(object sender, EventArgs e) {
            lbRssTitle.Items.Clear();
            try {
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
            catch (Exception) {
                MessageBox.Show("正しいURLまたは名称を入力してください");
            }
        }

        //webniewに表示
        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            Uri websiteUri = new Uri(xdocs[lbRssTitle.SelectedIndex].link);
            webView21.Source = websiteUri;
        }

        //combobox初期値登録
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

        //お気に入り登録
        private void button1_Click(object sender, EventArgs e) {
            if(textBox1.Text != ""　&&  comboBox1.Text != "" && comboBox1.Text.Contains("https")) {
                try {
                    website.Add(textBox1.Text, comboBox1.Text);
                    comboBox1.Items.Add(GetKeyFromValue(website, comboBox1.Text));
                    comboBox1.Text = "";
                    textBox1.Text = "";
                    MessageBox.Show("登録が完了しました");

                }
                catch (ArgumentException) {
                    MessageBox.Show("同じ名前が存在しています、違う名前を入力してください");
                }
                catch (Exception) {
                    MessageBox.Show("URLまたはお気に入り名称を入力してください");
                }
            } else {
                MessageBox.Show("登録名またはURLを入力してください");
            }
            
        }

        static string GetKeyFromValue(Dictionary<string, string> dictionary, string value) {
            return dictionary.FirstOrDefault(kvp => kvp.Value == value).Key;
        }

        //お気に入り削除
        private void button2_Click(object sender, EventArgs e) {
            try {
                string key = textBox1.Text;

                if (string.IsNullOrEmpty(key)) {
                    throw new ArgumentException("名称が空です");
                }

                if (website.ContainsKey(key) && immutableKeys.Contains(key)) {
                    comboBox1.Text = "";
                    textBox1.Text = "";
                    throw new InvalidOperationException("初期登録は削除できません");
                }

                website.Remove(key);
                comboBox1.Items.Remove(key);
                comboBox1.Text = "";
                textBox1.Text = "";
                MessageBox.Show("削除が完了しました");
            }
            catch (InvalidOperationException ex) {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) {
                MessageBox.Show($"エラーが発生しました: {ex.Message}");
            }
        }
    }



    public class ItemData {
        public string Title { get; set; }
        public string link { get; set; }
    }

    public class ImmutableKeyDictionary<TKey, TValue> : Dictionary<TKey, TValue> {
        private readonly HashSet<TKey> immutableKeys;

        public ImmutableKeyDictionary(IEnumerable<TKey> immutableKeys) {
            this.immutableKeys = new HashSet<TKey>(immutableKeys);
        }

        public ImmutableKeyDictionary(IDictionary<TKey, TValue> dictionary, IEnumerable<TKey> immutableKeys) : base(dictionary) {
            this.immutableKeys = new HashSet<TKey>(immutableKeys);
        }

        public new bool Remove(TKey key) {
            if (immutableKeys.Contains(key)) {
                throw new InvalidOperationException($"Cannot delete immutable key: {key}");
            }
            return base.Remove(key);
        }

        public new void Clear() {
            foreach (var key in immutableKeys) {
                if (ContainsKey(key)) {
                    throw new InvalidOperationException($"Cannot delete immutable key: {key}");
                }
            }
            base.Clear();
        }
    }

}
