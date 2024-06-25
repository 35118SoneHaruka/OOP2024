namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx8_1_Click(object sender, EventArgs e) {
            var today = DateTime.Now;
            tbDisp.Text = today.ToString("yyyy/MM/dd HH:mm") + "\r\n";
            tbDisp.Text += today.ToString("yyyy�NMM��dd�� HH��mm��ss�b") + "\r\n";
            tbDisp.Text += today.ToString("ggyy�N MM��dd��(dddd)");
        }

        private void btEx8_2_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            DateTime nextTuesday = NextDay(today,DayOfWeek.Tuesday);
            tbDisp.Text = "���̉Ηj���́F" + nextTuesday.ToString("d");
        }

        public static DateTime NextDay(DateTime date,DayOfWeek dayOfWeek) {
            var days =(int)dayOfWeek - (int)(date.DayOfWeek);
            if(days <= 0) 
                days += 7;
            return date.AddDays(days);
            
        }
    }
}
