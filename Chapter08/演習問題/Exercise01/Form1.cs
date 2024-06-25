namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx8_1_Click(object sender, EventArgs e) {
            var today = DateTime.Now;
            tbDisp.Text = today.ToString("yyyy/MM/dd HH:mm") + "\r\n";
            tbDisp.Text += today.ToString("yyyy”NMMŒŽdd“ú HHŽžmm•ªss•b") + "\r\n";
            tbDisp.Text += today.ToString("ggyy”N MMŒŽdd“ú(dddd)");
        }

        private void btEx8_2_Click(object sender, EventArgs e) {

        }
    }
}
