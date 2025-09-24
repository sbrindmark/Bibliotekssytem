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
                Console.WriteLine("\nBibliotekariens meny");
                Console.WriteLine("1. Lägg till bok");
                Console.WriteLine("2. Ta bort bok");
                Console.WriteLine("3. Sök efter bok");
                Console.WriteLine("4. Visa alla böcker");
                Console.WriteLine("5. Avsluta");
                // kraftigt genererad med AI
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                       AddBook();
                        break;
                    case "2":
                        //remove book
                        break;
                    case "3":
                        SearchBook();
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
                if (running)
                {
                    Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } 
        }

        private List<Books> books = new List<Books>();

        //Hjälpfunktion för att validera text från användaren
        private string ReadNonEmptyInput(string prompt)
        {
            string input;
            do
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    Console.WriteLine("Fältet får inte vara tomt. ");
            } while (string.IsNullOrEmpty(input));
            return input;
        }

        // Lägg till bok
        public void AddBook()
        {
            string titel = ReadNonEmptyInput("Ange titel: ");
            string author = ReadNonEmptyInput("Ange författare: ");
            string isbn = ReadNonEmptyInput("Ange ISBN: ");

            var book = new Books(titel, author, isbn);

            // Kontrollera om ISBN redan finns
            foreach (var b in books)
            {
                if (b.ISBN == book.ISBN)
                {
                    Console.WriteLine($"En bok med ISBN {book.ISBN} finns redan i systemet.");
                    return;
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

        // Sök efter bok
        public void SearchBook()
        {
            string searchTerm = ReadNonEmptyInput("Ange titel eller författare att söka efter: ");
            var foundBooks = books.Where(b => b.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
                                           || b.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundBooks.Count == 0)
            {
                Console.WriteLine("Ingen bok matchar din sökning.");
            }
            else
            {
                Console.WriteLine("Matchande böcker:");
                foreach (var book in foundBooks)
                {
                    Console.WriteLine(book.ToString());
                }
            }
        }
    }
}

