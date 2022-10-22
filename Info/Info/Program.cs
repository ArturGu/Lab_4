using System;

namespace Info
{
    public class Books
    {

        public string Author { get; set;}
        public int Year { get; set; }
        public int Price { get; set; }



        public Books(string Author, int Year, int Price)
        {
            this.Author = Author;
            this.Year = Year;
            this.Price = Price;
        }
    }

    public class Alone_with_myself : Books
    {
        public Alone_with_myself(string Author, int Year, int Price) : base(Author, Year, Price)
        {

        }
    }

    public class The_witcher : Books
    {
        public The_witcher(string Author, int Year, int Price) : base(Author, Year, Price)
        {

        }
    }

    public class Harry_Potter : Books
    {
        public Harry_Potter(string Author, int Year, int Price) : base(Author, Year, Price)
        {

        }
    }

    public class List<T> where T : Books
    {
        public void DebugInfo(T books)
        {
            Console.WriteLine($"Class: {books}");
            Console.WriteLine($"Characteristics:");
            Console.WriteLine($"Author: {books.Author}. Year of publication: {books.Year}. Price: {books.Price}UAH");
            Console.WriteLine();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Alone_with_myself alone_with_myself = new Alone_with_myself("Marcus Aurelius", 2022, 165);
            The_witcher the_witcher = new The_witcher("Andrzej Sapkowski", 2017, 1215);
            Harry_Potter harry_potter = new Harry_Potter("Joan Rowling", 2019, 2220);
            List<Books> goods = new List<Books>();

            goods.DebugInfo(alone_with_myself);
            goods.DebugInfo(the_witcher);
            goods.DebugInfo(harry_potter);
            Console.ReadKey();
        }
    }
}