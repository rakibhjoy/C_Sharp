using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{ 
    class Library
    {
        string libName;
        string libAddress;
        Book[] listOfBook=new Book[1000];
        int totalBook;
        public Library()
        {
            totalBook = 0;
        }
        public Library(string libName, string libAddress)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = 0;


        }
     
        

        public void ShowLibInfo()
        {
            Console.WriteLine("\nLibrary name: " + libName + "   Library Address:  " + libAddress);
            
            for(int i=0;i<totalBook;i++)
            {
                Console.WriteLine("Book no:" + (i + 1) + "\nBook name: " + listOfBook[i].getBookName() + "\nbook author: " + listOfBook[i].getBookAuthor() + "\nBook ID: " + listOfBook[i].getBookId() + "\nBook type: " + listOfBook[i].getBookType() + "\nBook copy: " + listOfBook[i].getBookCopy());
            }
            Console.WriteLine(" " );
            Console.WriteLine("Total : " + totalBook);

            
        }
        public void AddNewBook(Book book)
        {
            listOfBook[totalBook] = book;
                        
            Console.WriteLine("BOOK id  " + listOfBook[0].getBookId() + " added in Library");
            totalBook++;

        }
        public void DeleteBook(Book book)
        {
            
            for (int i = 0; i < totalBook; i++)
            {
                if (listOfBook[i].BookId == book.BookId)
                {
                    totalBook--;
                   
                }
                
                    
            }
            Console.WriteLine("deleted=>");
            Console.WriteLine(listOfBook[0].getBookName());

            
        }
        public void AddNewBookCopy(Book book,int copy)
        {
            book.BookCopy += copy;
            Console.WriteLine(copy + " New copy added  " + book.getBookId());
        }

    }
}
