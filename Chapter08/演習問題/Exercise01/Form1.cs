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
            var today = DateTime.Today;
            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {
                var nextWeek = NextWeek(today, (DayOfWeek)dayofweek);
                tbDisp.Text += today.ToString("yy/MM/dd") + "の翌週の" + dayofweek + ":" + nextWeek.ToString("yy/MM/dd") + "\r\n";
                //var str = string.Format("{0:yy/MM/dd}の次週の{1}:",today,(DayOfWeek)dayofweek);
            }
            //DateTime nextTuesday = NextWeek(DateTime.Today, DayOfWeek.Tuesday);
            //tbDisp.Text = str + "\r\n";
        }

        public static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek) {
            //var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            //if (days <= 0) {
            //    days += 7;
            //}
            //return date.AddDays(days);
            var nextweek = date.AddDays(7);
            var day = (int)dayOfWeek - (int)date.DayOfWeek;
            return nextweek.AddDays(day);
        }

        private void tbEx8_3_Click(object sender, EventArgs e) {
            var tw = new TimeWatch();
            tw.Start();
            Thread.Sleep(1000);
            TimeSpan duration = tw.Stop();
            var str = String.Format("処理時間は{0}ミリ秒でした", duration.TotalMilliseconds);
            tbDisp.Text = str;
        }

        class TimeWatch {
            private DateTime _time;

            public void Start() {
                _time = DateTime.Now;

            }

            public TimeSpan Stop() {
                return DateTime.Now - _time  ;

            }
        }
    }
}
