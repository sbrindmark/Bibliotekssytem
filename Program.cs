namespace Bibliotekssytem
{
    internal class Program
    {
        // Programmet startar här
        static void Main(string[] args)
        {
            // Skapar instanser av bibliotekarie och låntagare
            Librarian librarian = new Librarian();
            Borrower borrower = new Borrower();
            // Lista med böcker som delas mellan användartyper
            List<Books> books = new List<Books>();

            // Huvudloopen för programmet
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till Bibliotekssystemet!");
                Console.WriteLine("Välj användartyp:");
                Console.WriteLine("1. Bibliotekarie");
                Console.WriteLine("2. Låntagare");
                Console.WriteLine("0. Avsluta");
                Console.Write("Ditt val: ");
                string input = Console.ReadLine();

                // Avslutar programmet om användaren väljer 0
                if (input == "0")
                {
                    Console.WriteLine("Avslutar programmet...");
                    break;
                }

                // Hanterar användarens val av roll
                switch (input)
                {
                    case "1":
                        librarian.ShowMenu(books); // Bibliotekariens meny
                        break;
                    case "2":
                        borrower.ShowMenu(books); // Låntagarens meny
                        break;
                    default:
                        Console.WriteLine("Felaktigt val, försök igen.");
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                        Console.ReadKey();
                        break;
                }

                Console.ReadLine(); // Väntar på användaren innan nästa varv
            }
        }
    }
}
