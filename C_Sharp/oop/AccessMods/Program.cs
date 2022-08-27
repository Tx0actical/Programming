using System;

namespace Modifiers
{
    class Program
    {
        class Book
        {
            public string _name;
            protected string _author;
            private int _pagecount;

            public Book(string name, string author, int pagecount)
            {
                _name = name;
                _author = author;
                _pagecount = pagecount;
            }
            public string GetDescription()
            {
                return $"{_name} by {_author} having pagecount {_pagecount}";
            }

            // member variables can also be accessed using methods
            public string GetName() {
                return _name;
            }
            public void SetName(string s) {
                _name = s;
            }
            public string GetAuthor() {
                return _author;
            }
            public void SetAuthor(string s) {
                _author = s;
            }
            public void SetPages(int a) {
                _pagecount = a;
            }
        }

        public static void Main(string[] args)
        {
            Book b1 = new Book("Anybook", "Anyauthor", 300);

            b1._name = "Cat in the Hat";
            Console.WriteLine(b1.GetDescription());

            // set data using functions instead of accessing fields directly
            b1.SetName("Grapes of Wrath");
            b1.SetAuthor("John Steinbeck");
            b1.SetPages(464);
            Console.WriteLine(b1.GetDescription());
        }
    }
}