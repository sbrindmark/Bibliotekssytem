using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssytem
{
    public class Librarian : User
    {
        public override void ShowMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Bibliotekariens meny");
                Console.WriteLine("1. Lägg till bok");
                Console.WriteLine("2. Ta bort bok");
                Console.WriteLine("3. Sök efter bok");
                Console.WriteLine("4. Visa alla böcker");
                Console.WriteLine("5. Avsluta");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                       // AddBook();
                        break;
                    case "2":
                        //remove book
                        break;
                    case "3":
                        //Sök efter bok
                        break;
                    case "4":
                        ListBooks();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val.");
                            break;
                }
            } // kraftigt genererad med AI
        }

        private List<Books> books = new List<Books>();

        // Lägg till bok
        public void AddBook(Books book)
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

