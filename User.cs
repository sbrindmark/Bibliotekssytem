using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssytem
{
    // Abstrakt basklass för användare (bibliotekarie/låntagare)
    public abstract class User
    {
        public List<Books> books = new List<Books>(); // Lista med böcker

        // Abstrakt metod för att visa meny, måste implementeras av subklasser
        public abstract void ShowMenu(List<Books> parameterList);

        // Hjälpfunktion för att läsa in och validera text från användaren (skapat med AI)
        public string ReadNonEmptyInput(string prompt)
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

        // Hjälpfunktion för att läsa in och validera numerisk text (ISBN) (skapat med AI)
        public string ReadNumericInput(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input) || !ulong.TryParse(input, out _))
                    Console.WriteLine("ISBN får endast innehålla siffror och får inte vara tomt.");
            } while (string.IsNullOrWhiteSpace(input) || !ulong.TryParse(input, out _));
            return input;
        }

        // Sök efter bok i listan
        public void SearchBook(List<Books> book1)
        {
            books = book1;
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
                foreach (Books book in foundBooks)
                {
                    Console.WriteLine(book.ToString());
                }
            }
        }

        // Visar alla böcker i listan
        public void ListBooks(List<Books> book1)
        {
            books = book1;

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
