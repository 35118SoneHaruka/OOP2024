namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx8_1_Click(object sender, EventArgs e) {
            var today = DateTime.Now;
            tbDisp.Text = today.ToString("yyyy/MM/dd HH:mm") + "\r\n";
            tbDisp.Text += today.ToString("yyyy年MM月dd日 HH時mm分ss秒") + "\r\n";
            tbDisp.Text += today.ToString("ggyy年 MM月dd日(dddd)");
        }

        private void btEx8_2_Click(object sender, EventArgs e) {

        }
    }
}
