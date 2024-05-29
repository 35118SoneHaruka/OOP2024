﻿using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            // 4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2004, 6),
                new YearMonth(2010, 9),
                new YearMonth(2020, 12),
            };

            // 4.2.2
            Console.WriteLine("\n- 4.2.2 ---");
            Exercise2_2(ymCollection);
            Console.WriteLine("\n- 4.2.4 ---");

            // 4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("\n- 4.2.5 ---");


            // 4.2.5
            Exercise2_5(ymCollection);
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach (var item in ymCollection) {
                Console.WriteLine(item);
            }
        }

        private static YearMonth Exercise2_3(YearMonth[] ymCollection) {
            foreach (var item in ymCollection) {
                if (item.Is21Century) {
                    return item;
                }

            }
            return null;
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            if(Exercise2_3(ymCollection)== null) {
                Console.WriteLine("21世紀のデータはありません");
            } else {
                Console.WriteLine(Exercise2_3(ymCollection) );
            }

        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
           
        }
    }
}
