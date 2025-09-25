using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssytem
{
    public abstract class User
    {
        public abstract void ShowMenu();

        //Hjälpfunktion för att validera text från användaren
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

        // Sök efter bok
        public void SearchBook(Librarian librarian)
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
