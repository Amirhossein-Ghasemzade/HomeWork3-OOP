using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task1
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void BorrowBook(string title)
        {
            Book book = books.Find(b => b.Title == title);
            if (book != null && book.IsAvailable)
            {
                book.IsAvailable = false;
                Console.WriteLine($"The {title} Book Has Been Borrowed.");
            }
            else
            {
                Console.WriteLine("Book Not Found or Unavailable.");
            }
        }
        public void ReturnBook(string title)
        {
            Book book = books.Find(b => b.Title == title);
            if (book != null && !book.IsAvailable)
            {
                book.IsAvailable = true;
                Console.WriteLine($"The {title} Book Has Been Returned.");
            }
            else
            {
                Console.WriteLine("Book Not Found or Has Already Been Returned.");
            }
        }
        public void PrintBooks()
        {
            foreach (var b in books)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} : Available",
                b.Title, b.Author, b.ISBN, b.IsAvailable ? "Yes" : "No");
            }
        }
    }
}
