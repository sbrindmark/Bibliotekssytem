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
            Console.WriteLine("Librarian Menu");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. View All Books");
            Console.WriteLine("5. Exit");
        } // kraftigt genererad med AI

        Books Books = new Books("The Great Gatsby", "F. Scott Fitzgerald", 123456);

        public void AddBook()
        {
            // Code to add a book
        }

        public void BorrowBook(Books bookToBorrow)
        {
            bookToBorrow.isBorrowed = true;
        }

        public void ReturnBook(Books bookToReturn)
        {
            bookToReturn.isBorrowed = false;
        }



    }
}
