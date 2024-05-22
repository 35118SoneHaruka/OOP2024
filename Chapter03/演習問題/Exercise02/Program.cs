using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };

            Console.WriteLine("***3.2.1***");
            Exercise2_1(names);

            Console.WriteLine("***3.2.2***");
            Exercise2_2(names);

            Console.WriteLine("***3.2.3***");
            Exercise2_3(names);

            Console.WriteLine("***3.2.4***");
            Exercise2_4(names);

        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力、空行で終了");
            do {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) {
                    break;
                } else {
                    int index = names.FindIndex(s => s == line);
                    Console.WriteLine(index);
                    Console.WriteLine("都市名を入力、空行で終了");
                }

            } while (true);
        }

        private static void Exercise2_2(List<string> names) {
            var query = names.Count(s => s.Contains('o'));
            Console.WriteLine("oを含む文字列の個数は" + query);

        }

        private static void Exercise2_3(List<string> names) {
            char ch = 'o';
            Console.WriteLine(ch + "を含む文字を出力");
            var query = names.Where(s => s.Contains(ch)).ToArray();
            foreach (var item in query) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise2_4(List<string> names) {
            var query = names.Where(s => s.StartsWith("B")).Select(s =>new{s.Length,s } );
            Console.WriteLine("Bで始まる都市名の文字数");
            foreach (var i in query) {
                Console.WriteLine(i.s + ","+ i.Length);
            }

        }
    }
}
