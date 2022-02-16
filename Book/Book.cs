using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        string bookName;
        string bookAuthor;
        string bookId;
        string bookType;
        int bookCopy;
        public Book()
        {

        }
        public Book(string bookName,string bookAuthor,string bookId,string bookType,int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }
        public void setBookName(string bookName)
        {
            this.bookName = bookName;
        }
        public void setBookAuthor(string bookAuthor)
        {
            this.bookAuthor = bookAuthor;
        }
        public void setBookId(string bookId)
        {
            this.bookId = bookId;
        }
        public void setBookType(string bookType)
        {
            this.bookType = bookType;
        }
        public void setBookCopy(int bookCopy)
        {
            this.bookCopy = bookCopy;
        }

        public string getBookName()
        {
            return bookName;
        }
        public string getBookAuthor()
        {
            return bookAuthor;
        }
        public string getBookId()
        {
            return bookId;
        }
        public string getBookType()
        {
            return bookType;
        }
        public int getBookCopy()
        {
            return bookCopy;
        }
        public string BookName { set; get; }
        public string BookAuthor{set;get;}
        public string BookId{set;get;}
        public string BookType { set; get; }
        public int BookCopy { set; get; }

        public void ShowInfo()
        {
            Console.WriteLine("BookName :" + getBookName());
            Console.WriteLine("BookAuthor :" + getBookAuthor());
            Console.WriteLine("BookId : " + getBookId());
            Console.WriteLine("BookType :" + getBookType());
            Console.WriteLine("BookCopy :" + getBookCopy()+"\n");
            
        }
        public void AddBookCopy(int x)
        {

            x= x+bookCopy ;
            Console.WriteLine("Added Copy Of Book ");
            Console.WriteLine("Copy Of Book :" + x);
            

          
        }
        public static int bookCount;
        
        public static int showTotalBook()
        {
            
            return ++bookCount;
            
        }


    }
}
