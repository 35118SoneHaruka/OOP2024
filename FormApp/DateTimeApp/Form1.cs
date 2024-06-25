namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDateCount_Click(object sender, EventArgs e) {
            //tbDisp.Text = "ZZ“ú–Ú";
            //tbDisp.Text = dtpBirthday.Value.ToString("d");

            var today = DateTime.Today;

            TimeSpan diff = today - dtpDay.Value;

            tbDisp.Text = (diff.Days + 1) + "“ú–Ú";

        }

        private void btDayBefore_Click(object sender, EventArgs e) {
            var past = dtpDay.Value.AddDays(-(double)nudDay.Value);

            tbDisp.Text = past.ToString("D");
        }

        private void btDayAfter_Click(object sender, EventArgs e) {
            var future = dtpDay.Value.AddDays((double)nudDay.Value);

            tbDisp.Text = future.ToString("D");
        }

        private void btAge_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            var age = GetAge(dtpDay.Value,today);
            
            tbDisp.Text = age + "Î";
        }

        public static int GetAge(DateTime birthday,DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if(targetDay.AddDays(1) > birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}
