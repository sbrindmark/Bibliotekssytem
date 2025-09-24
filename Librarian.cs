using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssytem
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} av {Author} (ISBN: {ISBN})";
        }
    }

    public class Librarian : User
    {
        public override void ShowMenu()
        {
            Console.WriteLine("Bibliotekariens meny");
            Console.WriteLine("1. Lägg till bok");
            Console.WriteLine("2. Ta bort bok");
            Console.WriteLine("3. Sök efter bok");
            Console.WriteLine("4. Visa alla böcker");
            Console.WriteLine("5. Avsluta");
        } // kraftigt genererad med AI


        private List<Book> books = new List<Book>();
        public override void ShowMenu()
        {
            throw new NotImplementedException();
        }

        // Lägg till bok
        public void AddBook(Book book)
        {
            // Kontrollera om ISBN redan finns
            foreach (var b in books)
            {
                if (b.ISBN == book.ISBN)
                {
                    throw new ArgumentException($"En bok med ISBN {book.ISBN} finns redan i systemet.");
                }
            }

            books.Add(book);
            Console.WriteLine($"Boken \"{book.Title}\" har lagts till.");
        }

        // Lista alla böcker
        public void ListBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Inga böcker i biblioteket.");
                return;
            }

            Console.WriteLine("Böcker i biblioteket:");
            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}

