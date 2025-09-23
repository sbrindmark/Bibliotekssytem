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
            Console.WriteLine("Bibliotekariens meny");
            Console.WriteLine("1. Lägg till bok");
            Console.WriteLine("2. Ta bort bok");
            Console.WriteLine("3. Sök efter bok");
            Console.WriteLine("4. Visa alla böcker");
            Console.WriteLine("5. Avsluta");
        } // kraftigt genererad med AI

        public void AddBook()
        {
            // Code to add a book
        }


    }
}
