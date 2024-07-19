using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements();
            foreach (var xsample in xelements) {
                var xname = xsample.Element("name");
                var xmenbers = xsample.Element("teammembers");
                Console.WriteLine("{0} 人数{1}", xname.Value, xmenbers.Value);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().OrderBy(x => (int)x.Element("firstplayed"));
            foreach (var xsample in xelements) {
                var xname = xsample.Element("name");
                var xkanji = xname.Attribute("kanji");
                var xfirstplayed = (int)xsample.Element("firstplayed");
                Console.WriteLine("{0}({1})", xkanji.Value, xfirstplayed);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().Select(x => new {
                Name = x.Element("name").Value,
                Teammembers = x.Element("teammembers").Value,
            });
            var xmax = xelements.Max(x => x.Teammembers);
            foreach (var item in xelements) {
                if(item.Teammembers == xmax) {
                    Console.WriteLine(item.Name);
                }
            }
        }

        private static void Exercise1_4(string file, string newfile) {
            var element = new XElement(file,
                new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                new XElement("teammembers", "11"),
                new XElement("firstplayed", "1863")
            );

            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);

            xdoc.Save(newfile);

            do {
                Console.Write("名称：");
                var name = Console.ReadLine();
                Console.Write("漢字：");
                var kanji = Console.ReadLine();
                Console.Write("人数：");
                var member =Console.ReadLine();
                Console.Write("起源：");
                var firstplayed =Console.ReadLine();

                element = new XElement(file,
                new XElement("name", name, new XAttribute("kanji", kanji)),
                new XElement("teammembers", member),
                new XElement("firstplayed", firstplayed)
                );
                xdoc.Root.Add(element);

                xdoc.Save(newfile);

                Console.WriteLine("追加(1),保存(2)");
                
            } while (int.Parse(Console.ReadLine()) == 1);

            
        }

       
    }
}
