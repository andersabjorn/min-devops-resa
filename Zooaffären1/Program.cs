using System.ComponentModel.DataAnnotations;
using Zooaffäer;

namespace Zooaffären1
{
    class Program
    {
        private static Hanteraren _hanteraren = new Hanteraren();
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Zooaffären!");
            bool isRunning = true;

            while (isRunning)
            {
                VisaMeny();
                    string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        UI_VisaAllaDjur();
                        break;
                    case "2":
                        UI_AddAnimal();
                        break;
                    case "3":
                        UI_RemoveAnimal();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val! Försök igen (1-4)");
                        break;
                }
                if (isRunning)
                {
                    Console.WriteLine("\nTryck enter för att fortsätta");
                    Console.ReadKey();

                }
            }

        }
        private static void VisaMeny()
        {
            Console.Clear();
            Console.WriteLine("=== Meny ===");
            Console.WriteLine("1. Visa alla djur");
            Console.WriteLine("2. Lägg till djur");
            Console.WriteLine("3. Ta bort djur");
            Console.WriteLine("4. Avsluta");
            Console.Write("Ditt val: ");
        }
        private static void UI_VisaAllaDjur()
        {
            Console.WriteLine("==== Alla djur i butiken ====");
            var lista = _hanteraren._lista;


            if (lista.Count == 0)
            {
                Console.WriteLine("Det finns inga djur registrerade");
                return;;
            }

            foreach (var djur in lista)
            {
                Console.WriteLine($"ID: {djur.Id}, Art: {djur.Species} Namn: {djur.Name} Pris: {djur.Price}");
            }
        }

        private static void UI_AddAnimal()
        {
            Console.WriteLine("---- Lägg till nytt djur ----");

            int id;
            while (true)
            {
                Console.WriteLine("Ange id (nummer)");
                if (int.TryParse(Console.ReadLine(), out id))
                {
                    break;
                }
                Console.WriteLine("Fel! ID mÅste vara ett nummer");
            }
            Console.Write("Ange ett namn: ");
            string name = Console.ReadLine();

            Console.Write("Ange art (ex. Lejon) ");
            string species = Console.ReadLine();

            Console.Write("Ange ett pris(t. ex 5500)");
            string price = Console.ReadLine();

            int age = 0;
            string isAvalible = "true";


            Animal nyttDjur = new Animal(id, name, species, age, price, isAvalible);
            _hanteraren.AddAnimal(nyttDjur);
            Console.WriteLine($"\nKlart! {name} är tillagd!");
        }

        private static void UI_RemoveAnimal()
        {
            Console.WriteLine("--- Ta bort djur ---");

            int id;
            while (true)
            {
                Console.WriteLine("Ange djurets ID du vill ta bort: ");
                if (int.TryParse(Console.ReadLine(), out id))
                {
                    break;
                }
                Console.WriteLine("Fel! Måste vara ett ID nummer");
            }

            bool lyckades = _hanteraren.DeleteAnimal(id);

            if (lyckades)
            {
                Console.WriteLine("Djuret har tagits bort");
            }
            else
            {
                Console.WriteLine("Fel! Kunde inte hitta något djur med det ID:et");
            }
        }
    }
}

