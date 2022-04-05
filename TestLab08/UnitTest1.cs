using System;
using Xunit;
using Lab08_BookLibrary;
namespace TestLab08
{
    public class UnitTest1
    {
        [Fact]
        //Add a Book to Library
        public void TestAddingBook()
        {
            Library testLibrary = new Library();
            testLibrary.Add("testBook", "Yousef", "fuad", 23);

            var test = testLibrary.GetEnumerator();
            test.MoveNext();
            Assert.Equal("testBook", test.Current.Title);
            // Assert.DoesNotContain()


        }

        [Fact]
        //Borrowing a Book form Library 
        public void TestBorrowingBook1()
        {
            Library testLibrary = new Library();
            Book x = new Book("testBook", "Yousef", "fuad", 23);

            testLibrary.Return(x);



            Assert.Equal(x, testLibrary.Borrow("testBook"));
        }

        [Fact]
        //remove a Book form Library 
        public void TestBorrowingBook2()
        {
            Library testLibrary = new Library();
            Book x = new Book("testBook", "Yousef", "fuad", 23);

            testLibrary.Return(x);

            testLibrary.Borrow("testBook");




            Assert.DoesNotContain(x, testLibrary);
        }

        [Fact]
        //Borrowing a null form Library Borrowing
        public void TestBorrowingBook3()
        {
            Library testLibrary = new Library();
            Book x = new Book("testBook", "Yousef", "fuad", 23);

            testLibrary.Return(x);






            Assert.Null(testLibrary.Borrow("Book2"));
        }

        [Fact]
        //Borrowing a null form Library Borrowing
        public void TestReturnBook()
        {
            Library testLibrary = new Library();
            Book x = new Book("testBook", "Yousef", "fuad", 23);

            testLibrary.Return(x);

            Assert.Contains(x, testLibrary);
        }


        [Fact]
        //Test Pack Backpack
        public void TestPackBackpack()
        {
            BackPack<Book> bp = new BackPack<Book>();
            Book x = new Book("testBook", "Yousef", "fuad", 23);
            Book s = new Book("testBook2", "Yousef", "fuad", 122);
            bp.Pack(x);
           
            Assert.Contains(x, bp);
        }

        [Fact]
        //Test Pack Backpack
        public void TestPackBackpack2()
        {
            BackPack<string> bp = new BackPack<string>();
            string yusef = "yusef";
            bp.Pack(yusef);

            Assert.Contains(yusef, bp);
        }

        [Fact]
        //Test Unpack Backpack
        public void TestUnpackBackpack()
        {
            BackPack<Book> bp = new BackPack<Book>();
            Book x = new Book("testBook", "Yousef", "fuad", 23);
            bp.Pack(x);
            bp.Unpack(0);
            Assert.DoesNotContain(x, bp);
        }
        [Fact]
        //Test Unpack Backpack
        public void TestUnpackBackpack2()
        {
            BackPack<int> bp = new BackPack<int>();
            int x = 23;
            bp.Pack(x);
            bp.Unpack(0);
            Assert.DoesNotContain(x, bp);
        }
    }
}
