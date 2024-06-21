using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
           
            Console.WriteLine("生年月日を入力");
            Console.Write("年：");
            var year = int.Parse( Console.ReadLine());
            Console.Write("月：");
            var month = int.Parse(Console.ReadLine());
            Console.Write("日：");
            var day = int.Parse(Console.ReadLine());

            var dt1 = new DateTime(year, month, day);
            var dt2 = DateTime.Today;

            //あなたは平成○○年〇月〇日〇曜日に生まれました

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = dt1.ToString("ggyy年M月d日dddd",culture);
            Console.WriteLine("あなたは{0}に生まれました",str);

            //あなたは生まれてから今日で〇〇〇〇日目です

            TimeSpan diff = dt2.Date - dt1.Date;
            Console.WriteLine("あなたは生まれてから今日で{0}日目です", diff.Days);



           



        }
    }
}
