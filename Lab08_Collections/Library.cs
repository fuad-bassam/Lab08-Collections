using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_BookLibrary
{

   
    public class Library : ILibrary
    {
       


        private Dictionary<string, Book> libraryBooks = new Dictionary<string,Book>();

        public int Count { get; set; }
        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {

            libraryBooks.Add(title, new Book(title, firstName, lastName, numberOfPages));
            Console.WriteLine("add book" + title);
            Count++;
        }

        public Book Borrow(string title)
        {

           

            if (libraryBooks.TryGetValue(title,out Book book))
            {
               
                libraryBooks.Remove(title);
                Console.WriteLine(" Borrow book " + title);
                Count--;
                return book;
            }
            else
            {
                Console.WriteLine("book was not found" );
                return null;
            }
        }
        public void Return(Book book)
        {


            libraryBooks.Add(book.Title, book);
            Count++;
        }



        public IEnumerator<Book> GetEnumerator()
        {

            //  var item1= libraryBooks.GetEnumerator();

            //foreach (KeyValuePair<string, Book> item in libraryBooks)
            //{
            //    yield return item.Value;
            //}


            foreach ( Book item in libraryBooks.Values)
            {
                yield return item;
            }


        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (KeyValuePair<string, Book> item in libraryBooks)
            {
                yield return item;
            }
        }
    }
}
