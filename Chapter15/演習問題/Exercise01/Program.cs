using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var price = Library.Books.Max(x => x.Price);
            var book = Library.Books.First(b => b.Price == price);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var groups = Library.Books.GroupBy(b => b.PublishedYear).Select(g => new { PublishedYear = g.Key, Count = g.Count() }).OrderBy(o => o.PublishedYear);
            foreach (var group in groups) {
                Console.WriteLine($"{group.PublishedYear} {group.Count}冊");
            };
        }

        private static void Exercise1_4() {
            var books = Library.Books.OrderByDescending(b => b.PublishedYear).ThenByDescending(b => b.Price).Join(Library.Categories,book => book.CategoryId,category => category.Id,(book,category) => new {
                                                                                                                                                                                             Title = book.Title,
                                                                                                                                                                                             Category = category.Name,
                                                                                                                                                                                             PublishedYear = book.PublishedYear,Price = book.Price
            });

            foreach (var book in books) {
                Console.WriteLine($"{book.PublishedYear}年  {book.Price}円　{book.Title}({book.Category})");
            }
        }

        private static void Exercise1_5() {
            var books = Library.Books.OrderByDescending(b => b.PublishedYear).ThenByDescending(b => b.Price).Join(Library.Categories, book => book.CategoryId, category => category.Id, (book, category) => new {
                Category = category.Name,
            });
            foreach (var book in books) {
                Console.WriteLine($"カテゴリー {book.Category}");
            }
        }

        private static void Exercise1_6() {
           
        }

        private static void Exercise1_7() {
            
        }

        private static void Exercise1_8() {
            
        }
    }
}
