using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("数字を入力してください：");
            var str = Console.ReadLine();
            int.TryParse(str, out var num);
            var s1 = num.ToString("#,0");
            Console.Write("カンマ付きに変換：");
            Console.WriteLine(s1);
        }
    }
}
