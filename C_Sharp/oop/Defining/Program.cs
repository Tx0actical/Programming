using System;

namespace Defining {
    class Program {
        public class Book {
            string _name;
            string _author;
            int _pagecount;

            // Classes can have one or more constructors
            public Book(string name, string author, int pages) {
                _name = name;
                _author = author;
                _pagecount = pages;
            }

            // methods are used to operate on the class and data
            public string GetDescription() {
                return $"{_name} by {_author} having pagecount {_pagecount}";
            }
        }
        static void Main(string[] args) {
            // Create new object instances using the "new" operator
            Book b1 = new Book("Book 1", "Author 1", 800);
            Book b2 = new Book("Book 2", "Author 2", 900);

            // Call a method on the object
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());
        }
    }
}