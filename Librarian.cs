using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssytem
{
    public class Librarian : User
    {
        public override void ShowMenu(List<Books> parameterList)
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
                       AddBook(parameterList);
                        break;
                    case "2":
                        RemoveBook();
                        break;
                    case "3":
                        SearchBook(parameterList);
                        break;
                    case "4":
                        ListBooks(parameterList);
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

        // Lägg till bok
        public void AddBook(List<Books> book1)
        {
            books = book1;

            string titel = ReadNonEmptyInput("Ange titel: ");
            string author = ReadNonEmptyInput("Ange författare: ");
            string isbn = ReadNonEmptyInput("Ange ISBN: ");

            Books book = new Books(titel, author, isbn);

            // Kontrollera om ISBN redan finns
            foreach (Books b in books)
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

        public void RemoveBook()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Det finns inga böcker att ta bort.");
                return;
            }

            Console.WriteLine("Böcker i biblioteket:");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i].ToString()}");
            }

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

