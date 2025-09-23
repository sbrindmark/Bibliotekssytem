namespace Bibliotekssytem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Librarian librarian = new Librarian();

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

                if (input == "0")
                {
                    Console.WriteLine("Avslutar programmet...");
                    break;
                }

                switch (input)
                {
                    case "1":
                        librarian.ShowMenu();
                        break;
                    case "2":
                        LantagareMeny();
                        break;
                    default:
                        Console.WriteLine("Felaktigt val, försök igen.");
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                        Console.ReadKey();
                        break;
                }

                Console.ReadLine();
            }
        }

        static void LantagareMeny()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Låntagare-meny:");
                Console.WriteLine("1. Funktion från person 2");
                Console.WriteLine("2. Funktion från person 3");
                Console.WriteLine("3. Funktion från person 4");
                Console.WriteLine("0. Tillbaka");
                Console.Write("Ditt val: ");
                string input = Console.ReadLine();

                if (input == "0") break;

                switch (input)
                {
                    case "1":
                        Person2Metod();
                        break;
                    case "2":
                        Person3Metod();
                        break;
                    case "3":
                        Person4Metod();
                        break;
                    default:
                        Console.WriteLine("Felaktigt val, försök igen.");
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Byt ut dessa mot riktiga metoder från person 2–4
        static void Person2Metod()
        {
            Console.WriteLine("Person 2:s metod körs...");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
        }

        static void Person3Metod()
        {
            Console.WriteLine("Person 3:s metod körs...");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
        }

        static void Person4Metod()
        {
            Console.WriteLine("Person 4:s metod körs...");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
        }
    }
}
