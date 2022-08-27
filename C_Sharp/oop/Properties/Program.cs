using System;

namespace Defining {
    class Program {
        public class Book {
            private string _name;
            private string _author;
            private  int _pagecount;

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
            
            // use properties to implement access to internal data
            // this is called a Property with a "backing field"
            public string Name {
                get {
                    return _name;
                }
                set {
                    _name = value;
                }
            }

            // a shorthand way of writing properties using => operator
            // this will create "expresssion-bodied" properties
            public string Author {
                get => _author;
                set => _author = value;
            }

            public int Pagecount {
                get => _pagecount;
                set => _pagecount = value;
            }

            // get and set can be omitted if modification or reading
            // of value is to be prevented, or it can create a "computed property"
            public string Description {
                get => $"{Name} by {Author}, {Pagecount} pages";
            }

            // properties can be auto-generated - if there's no 
            // backing field, the property can hold data
            public string ISBN {
                get; set;
            }
            public decimal Price {
                get; set;
            }
        }
        static void Main(string[] args) {
            // create a new book object
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            // access properties
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Description);

            // set ISBN and Price properties
            b1.ISBN = "100140447938";
            b1.Price = 24.95m;
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Description);
        }
    }
}