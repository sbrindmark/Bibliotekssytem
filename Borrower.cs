using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssytem
{
    // Låntagare, ärver från User
    public class Borrower : User
    {
        // Visar låntagarens meny och hanterar val
        public override void ShowMenu(List<Books> parameterList)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nLåntagares meny");
                Console.WriteLine("1. Sök bok");
                Console.WriteLine("2. Visa alla böcker");
                Console.WriteLine("3. Låna bok");
                Console.WriteLine("4. Lämna tillbaka bok");
                Console.WriteLine("5. Bakåt");
                
                var input = Console.ReadLine();

                // Hanterar användarens val
                switch (input)
                {
                    case "1":
                        SearchBook(parameterList); // Sök efter bok
                        break;
                    case "2":
                        ListBooks(parameterList); // Visa alla böcker
                        break;
                    case "3":
                        BorrowBook(parameterList); // Låna bok
                        break;
                    case "4":
                        ReturnBook(parameterList); // Lämna tillbaka bok
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

        // Lista över böcker som låntagaren har lånat (används ej direkt i menyn)
        public List<Books> borrowedBooks = new List<Books>();

        // Hanterar utlåning av bok
        public void BorrowBook(List<Books> books)
        {
            ListBooks(books); // Visa alla böcker
            Console.Write("Vilken bok vill du låna? ");
            if (!int.TryParse(Console.ReadLine(), out int borrowId))
            {
                Console.WriteLine("Ogiltigt bok-ID");
                return;
            }
            Console.Write("Ange ditt användar-ID: ");
            if (!int.TryParse(Console.ReadLine(), out int borrowUserId))
            {
                Console.WriteLine("Ogiltigt användar-ID");
                return;
            }

            var bookToBorrow = books.FirstOrDefault(b => b.Id == borrowId);
            if (bookToBorrow != null && !bookToBorrow.IsBorrowed)
            {
                bookToBorrow.IsBorrowed = true;
                bookToBorrow.BorrowedByUserId = borrowUserId;
                Console.WriteLine($"Du har lånat boken '{bookToBorrow.Title}'.");
            }
            else
            {
                Console.WriteLine("Boken hittades inte eller är redan utlånad.");
            }
        }

        // Hanterar återlämning av bok
        public void ReturnBook(List<Books> books)
        {
            ListBooks(books);
            Console.Write("Ange bok-ID att lämna tillbaka: ");
            if (!int.TryParse(Console.ReadLine(), out int returnId))
            {
                Console.WriteLine("Ogiltigt bok-ID");
                return;
            }
            Console.Write("Ange ditt användar-ID: ");
            if (!int.TryParse(Console.ReadLine(), out int returnUserId))
            {
                Console.WriteLine("Ogiltigt användar-ID");
                return;
            }

            var bookToReturn = books.FirstOrDefault(b => b.Id == returnId);
            if (bookToReturn != null && bookToReturn.IsBorrowed && bookToReturn.BorrowedByUserId == returnUserId)
            {
                bookToReturn.IsBorrowed = false;
                bookToReturn.BorrowedByUserId = null;
                Console.WriteLine($"Du har lämnat tillbaka boken '{bookToReturn.Title}'.");
            }
            else
            {
                Console.WriteLine("Ogiltig retur – kontrollera bok-ID och användar-ID.");
            }
        }
       

    }
}
