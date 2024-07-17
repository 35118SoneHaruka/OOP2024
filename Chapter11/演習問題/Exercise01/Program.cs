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
            var xelements = xdoc.Root.Elements().OrderBy(x => (int) x.Element("firstplayed"));
            foreach (var xsample in xelements) {
                var xname =xsample.Element("name");
                var xkanji = xname.Attribute("kanji");
                var xfirstplayed =(int) xsample.Element("firstplayed");
                Console.WriteLine("{0}({1})", xkanji.Value, xfirstplayed);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().Select(x => new {
                                                    Name = x.Element("name").Value,
                                                    Teammenbers = x.Element("teammembers").Value
                                                 });
                        
            
        }

        private static void Exercise1_4(string file, string newfile) {

        }
    }
}
