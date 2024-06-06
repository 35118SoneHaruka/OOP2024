using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var prefectureDict = new Dictionary<string, string>();

            for (int i = 1; i <= 5; i++) {
                Console.WriteLine("県庁所在地の登録" + i);
                Console.Write("都道府県：");
                var prefecture = Console.ReadLine();
                Console.Write("県庁所在地：");
                var prefecturalOffice = Console.ReadLine();
                prefectureDict.Add(prefecture, prefecturalOffice);

            }

            Console.WriteLine();

            Console.WriteLine("*メニュー*");
            Console.WriteLine("1:一覧表示");
            Console.WriteLine("2:検索");
            Console.WriteLine("9:終了");
            Console.Write("数字を入力してください(半角)：");
            Console.WriteLine();

            var select = int.Parse(Console.ReadLine());

            while (select != 9) {
                if (select == 1) {
                    foreach (var prefecture in prefectureDict) {
                        Console.WriteLine("{0}の県庁所在地は{1}です", prefecture.Key, prefecture.Value);
                    }
                }else if(select == 2) {
                    Console.Write("都道府県：");
                    var prefecture1 = prefectureDict[Console.ReadLine()];
                    Console.WriteLine("県庁所在地:" + prefecture1);
                }
                Console.WriteLine("*メニュー*");
                Console.WriteLine("1:一覧表示");
                Console.WriteLine("2:検索");
                Console.WriteLine("9:終了");
                Console.Write("数字を入力してください(半角)：");
                select = int.Parse(Console.ReadLine());
                Console.WriteLine();

            }
            Console.WriteLine("終了します");



            /*foreach (var item in prefectureDict) {
                Console.WriteLine("{0}の県庁所在地は{1}です", item.Key, item.Value);
              }*/





            /*switch (select) {
                case 1:
                    foreach (var prefecture in prefectureDict) {
                        Console.WriteLine("{0}の県庁所在地は{1}です", prefecture.Key, prefecture.Value);
                    }
                    break;
                case 2:
                    Console.Write("都道府県：");
                    var prefecture1 = prefectureDict[Console.ReadLine()];
                    Console.WriteLine("県庁所在地:" + prefecture1);
                    break;
                case 9:
                    Console.WriteLine("終了します");
                    break;
            }















            /*var employeeDict = new Dictionary<int, Employee> {
               { 100, new Employee(100, "清水遼久") },
               { 112, new Employee(112, "芹沢洋和") },
               { 125, new Employee(125, "岩瀬奈央子") },
            };

            employeeDict.Add(126, new Employee(126, "曽根遼"));

            var name = employeeDict.Where(e => e.Value.Name.Contains("和"));

            
            foreach (var item in employeeDict.Values) {
                Console.WriteLine($"{item.Id}");
            }*/
        }
    }
}
