using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_p38 {
    internal class Program {
        static void Main(string[] args) {
            Employee employee = new Employee {
                Id = 100,
                Name = "山田太郎",
                Birthday = new DateTime(1992, 4, 5),
                DivisionName = "第一営業部",

            };
            Console.WriteLine("{0}({1})は、{2}に所属しています。",
                employee.Name,employee.GetAge(),employee.DivisionName);

            Student student = new Student { 
                Grade = 2,
                ClassNumber = 1,
                Name = "曽根",
                Birthday = new DateTime (2004,6,7),

            };
            Console.WriteLine("{0}({1})は、{2}年{3}組です。",
                student.Name, student.GetAge(), student.Grade, student.ClassNumber);

            //Person person = new Student();
            //Object o = new Student();

            Person person = student;
            if (person is Student)
                Console.WriteLine("person is Student");

            object obj = student;
            if (obj is Student)
                Console.WriteLine("obj is Student");
        }
    }
}
