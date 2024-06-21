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

            Console.WriteLine("あなたは{0}に生まれました",dt1.ToString("dddd"));







            //CultureInfo japaneseCulture = new CultureInfo("ja-JP");
            //Console.WriteLine("あなたは{0}に生まれました", dt1.ToString("dddd",japaneseCulture));
            //if(dayOfWeek == DayOfWeek.Monday) {
            //    Console.WriteLine("あなたは月曜日に生まれました");
            //}
            //if (dayOfWeek == DayOfWeek.Tuesday) {
            //    Console.WriteLine("あなたは火曜日に生まれました");
            //}
            //if (dayOfWeek == DayOfWeek.Wednesday) {
            //    Console.WriteLine("あなたは水曜日に生まれました");
            //}
            //if (dayOfWeek == DayOfWeek.Thursday) {
            //    Console.WriteLine("あなたは木曜日に生まれました");
            //}
            //if (dayOfWeek == DayOfWeek.Friday) {
            //    Console.WriteLine("あなたは金曜日に生まれました");
            //}
            //if (dayOfWeek == DayOfWeek.Saturday) {
            //    Console.WriteLine("あなたは土曜日に生まれました");
            //}
            //if (dayOfWeek == DayOfWeek.Sunday) {
            //    Console.WriteLine("あなたは日曜日に生まれました");
            //}


        }
    }
}
