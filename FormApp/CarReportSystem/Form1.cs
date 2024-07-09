using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //�J�[���|�[�g�Ǘ��p���X�g
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReports;
        }

        //�ǉ��{�^��
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
            tslbMessage.Text = "�L�^�҂܂��͎Ԗ��̓��͂�����܂���";
        }

        //���W�I�{�^���@���[�J�[�o�^
        public CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked)
                return CarReport.MakerGroup.�g���^;
            if (rbHonda.Checked)
                return CarReport.MakerGroup.�z���_;
            if (rbNissan.Checked)
                return CarReport.MakerGroup.���Y;
            if (rbSubaru.Checked)
                return CarReport.MakerGroup.�X�o��;
            if (rbImport.Checked)
                return CarReport.MakerGroup.�A����;

            return CarReport.MakerGroup.���̑�;

        }

        //���W�I�{�^���@�Z�b�g
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.�Ȃ�:
                    rbClear();
                    break;
                case CarReport.MakerGroup.�g���^:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.�X�o��:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.���Y:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.�z���_:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.�A����:
                    rbImport.Checked = true;
                    break;
                case CarReport.MakerGroup.���̑�:
                    rbOther.Checked = true;
                    break;
                default:
                    break;


            }
        }

        //���W�I�{�^���@�N���A
        private void rbClear() {
            rbToyota.Checked = false;
            rbHonda.Checked = false;
            rbNissan.Checked = false;
            rbSubaru.Checked = false;
            rbImport.Checked = false;
            rbOther.Checked = false;
        }

        //�摜�J���{�^��
        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
        }

        //�摜�폜�{�^��
        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReport.Columns["Picture"].Visible = false;

            //���݂ɐF��ݒ�(�f�[�^�O���b�h�r���[)
            dgvCarReport.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvCarReport.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        //�f�[�^�O���b�h�r���[�C�x���g
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

        //�폜�{�^��
        private void btDeleteReport_Click(object sender, EventArgs e) {
            if (dgvCarReport.CurrentRow == null) return;
            if (!dgvCarReport.CurrentRow.Selected) return;



            listCarReports.RemoveAt(dgvCarReport.CurrentRow.Index);
            clearText();



        }

        //�C���{�^��
        private void btModifyReport_Click(object sender, EventArgs e) {
            if (dgvCarReport.CurrentRow == null) return;
            if (!dgvCarReport.CurrentRow.Selected) return;
            if (cbAuther.Text != string.Empty || cbCarName.Text != string.Empty) {
                tslbMessage.Text = "�L�^�҂܂��͎Ԗ��̓��͂�����܂���";
                return;
            }

            listCarReports[dgvCarReport.CurrentRow.Index].Date = dtpDate.Value;
            listCarReports[dgvCarReport.CurrentRow.Index].Author = cbAuther.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dgvCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Report = tbReport.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Picture = pbPicture.Image;
            dgvCarReport.Refresh();//�f�[�^�O���b�h�r���[�̍X�V

        }

        //�L�^�҂̗������R���{�{�b�N�X�֓o�^(�d���Ȃ�)
        private void setCbAuthor(string author) {
            if (!cbAuther.Items.Contains(author)) {
                cbAuther.Items.Add(author);
            }

        }

        //�Ԗ��̗������R���{�{�b�N�X�֓o�^(�d���Ȃ�)
        private void setCbCarName(string name) {
            if (!cbCarName.Items.Contains(name)) {
                cbCarName.Items.Add(name);
            }
        }

        //�e�L�X�g�N���A
        private void clearText() {
            dtpDate.Value = DateTime.Now;
            dgvCarReport.CurrentCell = null;
            setRadioButtonMaker(CarReport.MakerGroup.�Ȃ�);
            cbAuther.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
            pbPicture.Image = null;
        }

        //�ۑ��{�^��
        private void btReportSave_Click(object sender, EventArgs e) {
            ReportSaveFile();
        }

        //�t�@�C���ۑ�����
        private void ReportSaveFile() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //�o�C�i���`���ŃV���A����
#pragma warning disable SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    using (FileStream fs = File.Open(sfdReportFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);

                    }

                }

                catch (Exception) {
                    tslbMessage.Text = "�������݃G���[";
                }
            }
        }

        //�J���{�^���C�x���g�n���h��
        private void btReportOpen_Click(object sender, EventArgs e) {
            ReportOpenFile();

        }

        //�t�@�C���I�[�v������
        private void ReportOpenFile() {
            if (ofdReportFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //�t�V���A�����Ńo�C�i���`������荞��
#pragma warning disable SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
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

                    tslbMessage.Text = "�f�[�^���Ⴂ�܂�";
                }
                dgvCarReport.ClearSelection();
            }
        }

        //�N���A�{�^��
        private void btClearReport_Click(object sender, EventArgs e) {
            clearText();
        }

        private void �J��ToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportOpenFile();//�t�@�C���I�[�v������
        }

        private void �ۑ�ToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportSaveFile();//�t�@�C���ۑ�����
        }

        private void �I��ToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("�{���ɏI�����܂����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }
    }
}
