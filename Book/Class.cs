using System;


namespace Book
{
    class Class
    {
        static void Main(string[] args)
        {
            /* Book b1 = new Book("harry potter", "Rowling", "12345", "fantasy", 100);
             Book b2 = new Book("dream", "pilo pilo","4248","drama",300);
             Book b3 = new Book("cat", "jas", "1862", "fantasy", 100);
             b1.ShowInfo();
             b3.ShowInfo();             
             b2.ShowInfo();
             b1.AddBookCopy(100);
             b1.ShowInfo();*/

            Book b1 = new Book();
            b1.setBookName("harry potter");
            b1.setBookAuthor("Rowling");
            b1.setBookId("8765");
            b1.setBookType("fantasy");
            b1.setBookCopy(9);
            b1.ShowInfo();
            Book b2 = new Book();
            b2.setBookName("dream");
            b2.setBookAuthor("jack");
            b2.setBookId("10003");
            b2.setBookType("drama");
            b2.setBookCopy(10);
            b2.ShowInfo();
            Book b3 = new Book();
            b3.setBookName("cat");
            b3.setBookAuthor("jhon");
            b3.setBookId("8765");
            b3.setBookType("fantasy");
            b3.setBookCopy(7);
            b3.ShowInfo();
            b1.AddBookCopy(100);
            b1.ShowInfo();
            Book.showTotalBook();
            Book.showTotalBook();
            Console.WriteLine("total book type  " + Book.showTotalBook());
            

            Library l1 = new Library("AIUB", "Dhaka");
            
            l1.ShowLibInfo();
            Console.WriteLine("----------------------------------------------");
            l1.AddNewBook(b1);
            l1.AddNewBook(b2);
            l1.AddNewBook(b3);
            l1.AddNewBookCopy(b2, 3);
            l1.DeleteBook(b1);            
            l1.ShowLibInfo();
            Console.ReadKey();

        }
    }
}
