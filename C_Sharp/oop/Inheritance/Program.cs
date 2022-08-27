using System;
namespace Inheritance {
    class Publication {
        private string _name;
        public Publication(string name, int pagecount, decimal price) {
            _name = name;
            PageCount = pagecount;
            Price = price;
        }
        // PageCount property has no backing field
        public int PageCount {
            get; set;
        }
        public decimal Price {
            get; set;
        }
        public string Name {
            // return the name
            get { return _name; }
            //use the setter to validate the new property value
            set {
                if (value == "") {
                    throw new ArgumentException("Name cannot be blank");
                }
                _name = value;
            }
        }
        // using "virtual" keyword to indicate that a method
        // can be overridden by subclass to customise behaviour
        public virtual string GetDescription() {
            return $"{Name}, {PageCount} pages";
        }
    }
    // Declare "Magazine" as a subclass of Publication
    class Magazine : Publication {
        private string _publisher;

        // use base() keyword to initialise the base class
        public Magazine (string name, string publisher, int pagecount, decimal price) : base (name, pagecount, price) {
            _publisher = publisher;
        }
        public string Publisher {
            get => _publisher;
            set => _publisher = value;
        }
    }
    class Book : Publication {
        private string _author;
        // use base() keyword to initialise the base class
        public Book(string name, string author, int pagecount, decimal price) : base(name, pagecount, price) {
            _author = author;
        }

        public string Author {
            get => _author;
            set => _author = value;
        }

        // use the override keyword to override a base class method
        public override string GetDescription()
        {
            return $"{Name} by {Author}, {PageCount} pages";
        }
    }

    class Program {
        public static void Main(string[] args) {
            // create some publications
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825, 39.95m);
            Magazine m1 = new Magazine("Time", "Time USA", 75, 4.95m);

            Console.WriteLine($"{b1.Name}, {b1.Author}");
            Console.WriteLine($"{m1.Name}, {m1.Publisher}");

            // property validation logic will prevent an empty name
            // b1.Name = "";

            // call override functions
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b1.Price);
            Console.WriteLine(m1.GetDescription());
            Console.WriteLine(m1.Price);
        }
    }
}