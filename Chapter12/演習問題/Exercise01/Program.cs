using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
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

        private static void Exercise1_2(string outfile) {
            var employee = new Employee[] {
                new Employee {
                    Id = 001,
                    Name = "sizen",
                    HireDate = new DateTime(2004, 6, 7),
                },
                new Employee {
                    Id = 002,
                    Name = "fujii",
                    HireDate = new DateTime(2004, 6, 5),
                }

            };

            var settings = new XmlWriterSettings {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };
            using (var writer = XmlWriter.Create(outfile, settings)) {
                var serializer = new DataContractSerializer(employee.GetType());
                serializer.WriteObject(writer, employee);
            }
        }

        private static void Exercise1_3(string outfile) {
            using (var reader = XmlReader.Create(outfile)) {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var emps = serializer.ReadObject(reader) as Employee[];
                foreach (var item in emps) {
                    Console.WriteLine("{0} {1} {2}", item.Id,item.Name,item.HireDate);
                }

            }
            
        }

        private static void Exercise1_4(string outfile) {
            var employee = new Employee[] {
                new Employee {
                    Id = 001,
                    Name = "sizen",
                    HireDate = new DateTime(2004, 6, 7),
                },
                new Employee {
                    Id = 002,
                    Name = "fujii",
                    HireDate = new DateTime(2004, 6, 5),
                }

            };


            var options = new JsonSerializerOptions {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };

            string jsonString = JsonSerializer.Serialize(employee, options);
            File.WriteAllText(outfile,jsonString);
            Console.WriteLine(jsonString);
          
        }
    }
}
