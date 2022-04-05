using System;
using Lab08_BookLibrary;
namespace Lab08_Collections
{
    class Program
    {


        static void Main(string[] args)
        {

            Book a = new Book("Lord1", "aa", "bb", 5);
            Library L = new Library();
            L.Add("Lord2", "zz", "yy", 23);

            L.Return(a);

            var x = L.GetEnumerator();

            while (x.MoveNext())
            {
                Console.WriteLine("x =" + x.Current.Title);
            }



            Library lib = new Library();

            lib.Add("1", "Yousef", "Qandeel", 21);
            lib.Add("2", "Hello", "World", 10);

            Console.WriteLine("Count: " + lib.Count);

            Console.WriteLine("My Books");
            foreach (Book book in lib)
            {
                Console.WriteLine(book.Title);
            }

            BackPack<Book> bp = new BackPack<Book>();
            bp.Pack(lib.Borrow("2"));

            Console.WriteLine("My Pack");
            foreach (Book book in bp)
            {
                Console.WriteLine(book.Title);
            }



        }

    }
}
