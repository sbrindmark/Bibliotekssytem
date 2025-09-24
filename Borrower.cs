using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssytem
{
    public class Borrower : User
    {
        
        public override void ShowMenu()
        {
            bool running = true;
            while (running)

            Console.WriteLine("Borrower Menu");
            Console.WriteLine("1. Search Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Exit");
            // kraftigt genererad med AI
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    // Sök efter bok
                    break;
                case "2":
                    //ListBooks(); - ###hittar metoden då den är definierad i en annan klass.####
                    break;
                case "3":
                    //Låna bok
                    break;
                case "4":
                    //Lämna tillbaka bok
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }
        } 

        public List<Books> borrowedBooks = new List<Books>();

        public void BorrowBook(Books bookToBorrow)
        {
           // bookToBorrow.isBorrowed = true;

        }

        public void ReturnBook(Books bookToReturn)
        {
           // bookToReturn.isBorrowed = false;
        }

    }
}
