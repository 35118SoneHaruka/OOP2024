using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string outfile) {
            var employee = new Employee {
                Id = 001,
                Name = "sizen",
                HireDate = new DateTime(2004, 6, 7),
            };

            using (var writer = XmlWriter.Create(outfile)) {
                var serializer = new XmlSerializer(employee.GetType());
                serializer.Serialize(writer, employee);
            }

            using (var reader = XmlReader.Create(outfile)) {
                var serializer = new XmlSerializer(typeof(Employee));
                var emp = serializer.Deserialize(reader);
                Console.WriteLine(emp);
            }
        }

        private static void Exercise1_2(string putfile) {
            
        }

        private static void Exercise1_3(string outfile) {
            
        }

        private static void Exercise1_4(string outfile) {
            
        }
    }
}
