using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //コンストラクタ
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReports;
        }

        //追加ボタン
        private void btAddReport_Click(object sender, EventArgs e) {
            if (cbAuther.Text != string.Empty || cbCarName.Text != string.Empty) {
                CarReport carReport = new CarReport {
                    Date = dtpDate.Value,
                    Author = cbAuther.Text,
                    Maker = GetRadioButtonMaker(),
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    Picture = pbPicture.Image,
                };
                listCarReports.Add(carReport);
                setCbAuthor(cbAuther.Text);
                setCbCarName(cbCarName.Text);
                tslbMessage.Text = "";
                clearText();
                dgvCarReport.ClearSelection();
                return;

            }
            tslbMessage.Text = "記録者または車名の入力がありません";
        }

        //ラジオボタン　メーカー登録
        public CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked)
                return CarReport.MakerGroup.トヨタ;
            if (rbHonda.Checked)
                return CarReport.MakerGroup.ホンダ;
            if (rbNissan.Checked)
                return CarReport.MakerGroup.日産;
            if (rbSubaru.Checked)
                return CarReport.MakerGroup.スバル;
            if (rbImport.Checked)
                return CarReport.MakerGroup.輸入車;

            return CarReport.MakerGroup.その他;

        }

        //ラジオボタン　セット
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.なし:
                    rbClear();
                    break;
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImport.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;


            }
        }

        //ラジオボタン　クリア
        private void rbClear() {
            rbToyota.Checked = false;
            rbHonda.Checked = false;
            rbNissan.Checked = false;
            rbSubaru.Checked = false;
            rbImport.Checked = false;
            rbOther.Checked = false;
        }

        //画像開くボタン
        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
        }

        //画像削除ボタン
        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReport.Columns["Picture"].Visible = false;

            //交互に色を設定(データグリッドビュー)
            dgvCarReport.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvCarReport.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        //データグリッドビューイベント
        private void dgvCarReport_Click(object sender, EventArgs e) {
            if (dgvCarReport.CurrentRow == null) return;
            if (dgvCarReport.Rows.Count <= 0) return;
            if (!dgvCarReport.CurrentRow.Selected) return;
            dtpDate.Value = (DateTime)dgvCarReport.CurrentRow.Cells["Date"].Value;
            cbAuther.Text = (string)dgvCarReport.CurrentRow.Cells["author"].Value;
            setRadioButtonMaker((CarReport.MakerGroup)dgvCarReport.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dgvCarReport.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvCarReport.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvCarReport.CurrentRow.Cells["picture"].Value;

        }

        //削除ボタン
        private void btDeleteReport_Click(object sender, EventArgs e) {
            if (dgvCarReport.CurrentRow == null) return;
            if (!dgvCarReport.CurrentRow.Selected) return;



            listCarReports.RemoveAt(dgvCarReport.CurrentRow.Index);
            clearText();



        }

        //修正ボタン
        private void btModifyReport_Click(object sender, EventArgs e) {
            if (dgvCarReport.CurrentRow == null) return;
            if (!dgvCarReport.CurrentRow.Selected) return;
            if (cbAuther.Text != string.Empty || cbCarName.Text != string.Empty) {
                tslbMessage.Text = "記録者または車名の入力がありません";
                return;
            }

            listCarReports[dgvCarReport.CurrentRow.Index].Date = dtpDate.Value;
            listCarReports[dgvCarReport.CurrentRow.Index].Author = cbAuther.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dgvCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Report = tbReport.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Picture = pbPicture.Image;
            dgvCarReport.Refresh();//データグリッドビューの更新

        }

        //記録者の履歴をコンボボックスへ登録(重複なし)
        private void setCbAuthor(string author) {
            if (!cbAuther.Items.Contains(author)) {
                cbAuther.Items.Add(author);
            }

        }

        //車名の履歴をコンボボックスへ登録(重複なし)
        private void setCbCarName(string name) {
            if (!cbCarName.Items.Contains(name)) {
                cbCarName.Items.Add(name);
            }
        }

        //テキストクリア
        private void clearText() {
            dtpDate.Value = DateTime.Now;
            dgvCarReport.CurrentCell = null;
            setRadioButtonMaker(CarReport.MakerGroup.なし);
            cbAuther.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
            pbPicture.Image = null;
        }

        //保存ボタン
        private void btReportSave_Click(object sender, EventArgs e) {
            ReportSaveFile();
        }

        //ファイル保存処理
        private void ReportSaveFile() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
#pragma warning disable SYSLIB0011 // 型またはメンバーが旧型式です
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // 型またはメンバーが旧型式です
                    using (FileStream fs = File.Open(sfdReportFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);

                    }

                }

                catch (Exception) {
                    tslbMessage.Text = "書き込みエラー";
                }
            }
        }

        //開くボタンイベントハンドラ
        private void btReportOpen_Click(object sender, EventArgs e) {
            ReportOpenFile();

        }

        //ファイルオープン処理
        private void ReportOpenFile() {
            if (ofdReportFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //逆シリアル化でバイナリ形式を取り込む
#pragma warning disable SYSLIB0011 // 型またはメンバーが旧型式です
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // 型またはメンバーが旧型式です
                    using (FileStream fs = File.Open(ofdReportFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReport.DataSource = listCarReports;
                        foreach (var carReport in listCarReports) {
                            setCbAuthor(carReport.Author);
                            setCbCarName(carReport.CarName);
                        }
                        tslbMessage.Text = "";
                    }

                }
                catch (Exception) {

                    tslbMessage.Text = "データが違います";
                }
                dgvCarReport.ClearSelection();
            }
        }

        //クリアボタン
        private void btClearReport_Click(object sender, EventArgs e) {
            clearText();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportOpenFile();//ファイルオープン処理
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportSaveFile();//ファイル保存処理
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("本当に終了しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }
    }
}
