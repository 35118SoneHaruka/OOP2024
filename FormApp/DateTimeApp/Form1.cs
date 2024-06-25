namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDateCount_Click(object sender, EventArgs e) {
            //tbDisp.Text = "ÅZÅZì˙ñ⁄";
            //tbDisp.Text = dtpBirthday.Value.ToString("d");

            var today = DateTime.Today;

            TimeSpan diff = today - dtpBirthday.Value;

            tbDisp.Text = (diff.Days + 1) + "ì˙ñ⁄";

        }

        private void btDayBefore_Click(object sender, EventArgs e) {
            var past = dtpBirthday.Value.AddDays(-(double)nudDay.Value);

            tbDisp.Text = past.ToString("D");
        }

        private void btDayAfter_Click(object sender, EventArgs e) {
            var future = dtpBirthday.Value.AddDays((double)nudDay.Value);

            tbDisp.Text = future.ToString("D");
        }
    }
}
