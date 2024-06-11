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
                string prefecturalOffice;
                if (prefectureDict.ContainsKey(prefecture)) {
                    Console.WriteLine("上書きしますか");
                    Console.WriteLine("1:yes");
                    Console.WriteLine("2:no");
                    if (int.Parse(Console.ReadLine()) == 1) {
                        Console.Write("県庁所在地：");
                        prefecturalOffice = Console.ReadLine();
                        prefectureDict[prefecture] = prefecturalOffice;
                    }

                } else {
                    Console.Write("県庁所在地：");
                    prefecturalOffice = Console.ReadLine();
                    prefectureDict.Add(prefecture, prefecturalOffice);
                }


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
                    var prefecture1 = Console.ReadLine();
                    if (prefectureDict.ContainsKey(prefecture1)) {
                        Console.WriteLine("県庁所在地:" + prefectureDict[prefecture1]);
                    }
                    
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
        }
    }
}
