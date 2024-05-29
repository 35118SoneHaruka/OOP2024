using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class YearMonth {
        //4.1.1
        public int Year { get; private set; }
        public int Month { get; private set; }

        public YearMonth(int year, int month) {
            Year = year;
            Month = month;

        }

        //4.1.2
        public bool Is21Century {
            get {
                return Year>= 2001 && Year <= 2100;
            }
        }

        //4.1.3
        public YearMonth AddOneMonth() {
            int year = Year;
            int month = Month;
            month++;
            if(month >= 12) {
                year++;
                month = 1;
            }
            return new YearMonth(year, month);

            /*if(Month == 12) {
                return new YearMonth(year +1, 1);
            } else {
                return new YearMonth(year, Month + 1);
            }*/
        }

        //4.1.4
        public override string ToString() {
            return Year + "年" + Month + "月";
            //return $"{Year}年{Month}月"

        }
    }
}
