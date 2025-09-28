using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssytem
{
    // Librarian ärver från User och hanterar bibliotekariens funktioner
    public class Librarian : User
    {
        // Visar bibliotekariens meny och hanterar val
        public override void ShowMenu(List<Books> parameterList)
        {
            bool running = true;
            while (running)
            {
                // Meny för bibliotekarien
                Console.WriteLine("\nBibliotekariens meny");
                Console.WriteLine("1. Lägg till bok");
                Console.WriteLine("2. Ta bort bok");
                Console.WriteLine("3. Sök efter bok");
                Console.WriteLine("4. Visa alla böcker");
                Console.WriteLine("5. Bakåt");

                var input = Console.ReadLine();

                // Hanterar användarens val
                switch (input)
                {
                    case "1":
                        AddBook(parameterList); // Lägg till en ny bok
                        break;
                    case "2":
                        RemoveBook(); // Ta bort en bok
                        break;
                    case "3":
                        SearchBook(parameterList); // Sök efter bok
                        break;
                    case "4":
                        ListBooks(parameterList); // Visa alla böcker
                        break;
                    case "5":
                        running = false; // Avsluta menyn
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
                // Pausar och rensar konsolen mellan val
                if (running)
                {
                    Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        // Lägger till en ny bok i listan
        public void AddBook(List<Books> book1)
        {
            books = book1; // Synkroniserar med den aktuella boklistan

            // Hämtar och validerar titel, författare och ISBN från användaren
            string titel = ReadNonEmptyInput("Ange titel: ");
            string author = ReadNonEmptyInput("Ange författare: ");
            string isbn = ReadNumericInput("Ange ISBN: ");

            // Skapar ett unikt Id för den nya boken
            int newId = books.Count > 0 ? books.Max(b => b.Id) + 1 : 1;

            Books book = new Books(newId, titel, author, isbn);

            // Kontrollerar om ISBN redan finns i systemet
            foreach (Books b in books)
            {
                if (b.ISBN == book.ISBN)
                {
                    Console.WriteLine($"En bok med ISBN {book.ISBN} finns redan i systemet.");
                    return;
                }
            }
            // Lägger till boken i listan
            books.Add(book);
            Console.WriteLine($"Boken \"{book.Title}\" har lagts till.");
        }

        // Tar bort en bok från listan
        public void RemoveBook()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Det finns inga böcker att ta bort.");
                return;
            }

            // Visar alla böcker med index
            Console.WriteLine("Böcker i biblioteket:");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i].ToString()}");
            }

            // Frågar användaren vilken bok som ska tas bort
            Console.Write("Ange numret på boken du vill ta bort: ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= books.Count)
            {
                var removedBook = books[choice - 1];
                books.RemoveAt(choice - 1);
                Console.WriteLine($"Boken \"{removedBook.Title}\" har tagits bort.");
            }
            else
            {
                Console.WriteLine("Ogiltigt val.");
            }
        }
    }
}

