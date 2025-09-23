using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssytem
{
    public class Books : ISearchable
    {
        string title, author;
        int isbn;
        public bool isBorrowed;

        public Books(string title, string author, int isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            isBorrowed = false;
        }

        public void Search(string keyWord)
        {

        }
    }

    // Din nya Book-klass
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(int id, string title)
        {
            Id = id;
            Title = title;
            IsBorrowed = false;
        }

        public override string ToString()
        {
            return $"{Id}. {Title} - {(IsBorrowed ? "Utlånad" : "Tillgänglig")}";
        }
    }

    // Din nya Library-klass
    public class Library
    {
        private List<Book> books = new List<Book>();

        public Library()
        {
            // Några böcker att börja med
            books.Add(new Book(1, "1984"));
            books.Add(new Book(2, "Sagan om Ringen"));
            books.Add(new Book(3, "Harry Potter och De Vises Sten"));
        }

        public void ListBooks()
        {
            Console.WriteLine("\nBöcker i biblioteket:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void BorrowBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Fel: Boken finns inte.");
                return;
            }

            if (book.IsBorrowed)
            {
                Console.WriteLine("Fel: Boken är redan utlånad.");
            }
            else
            {
                book.IsBorrowed = true;
                Console.WriteLine($"Du har lånat boken: {book.Title}");
            }
        }

        public void ReturnBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Fel: Boken finns inte.");
                return;
            }

            if (!book.IsBorrowed)
            {
                Console.WriteLine("Fel: Boken är inte utlånad.");
            }
            else
            {
                book.IsBorrowed = false;
                Console.WriteLine($"Du har lämnat tillbaka boken: {book.Title}");
            }
        }
    }
}
