using System.Security.Cryptography.X509Certificates;

namespace Anders_Åbjörn_slutuppgift
{
    public class Program
    {
        //Här startar vi en ny lista
        public static List<Lager> _lista = new List<Lager>();

        static void Main(string[] args)
        {
            Console.WriteLine("--- Välkommer till lagerhanteraren ---");
            // Så länge isRunning är sann så körs menyn
            bool isRunning = true;
            //Lägger en loop så att menyn kan köras
            while (isRunning)
            {
                //LÄgger console clear så att menyn är ren hela tiden
                Console.Clear();
                //Lägger in valen i menyn så att användaren kan välja steg
                Console.WriteLine("1. Lägg till produkt");
                Console.WriteLine("2. Visa alla produkter");
                Console.WriteLine("3. Ta bort produkt");
                Console.WriteLine("4. Avsluta");
                //Lägger en string som jag döper till choice så att valet användaren gör spars
                string choice = Console.ReadLine();
                // Läggger en swish så att användarens val läggs rätt
                switch (choice)
                {
                    //Här lägger jag olika val i switchen
                    case "1":
                        UI_AddProdukt();
                        break;
                    case "2":
                        UI_VisaAllaProdukter();
                        break;
                    case "3":
                        UI_TaBortProdukt();
                        break;
                    case "4":
                        UI_Avsluta();
                        isRunning = false;
                        break;
                    default:
                        break;
                }

            }

        }
        public static void UI_AddProdukt()
        {
            // Här lägger jag in de val användaren behöver göra för att fylla på listan på rätt sätt
            Console.WriteLine("--- Lägg till produkt ---");
            Console.WriteLine();
            // Jag väljer att det ska läggas till ett id-nummer som första del
            Console.WriteLine("Skriv ett id på produkten, ex. (123): ");
            // lägger en bool som jag sedan fångar upp felaktiga inmatningar med .TryParse
            bool produktId = int.TryParse(Console.ReadLine(), out int id);
            // Sedan ska användaren fylla i vilken produkt
            Console.WriteLine("Skriv ett namn på produkten");
            // Använder mig av en string då och namnger den namnProdukt för enkelheten
            string namnProdukt = Console.ReadLine();
            //Vill få in vad för produkttyp det är som ska lagerföras
            Console.WriteLine("Skriv vad produkten har för typ: ");
            string produktTyp = Console.ReadLine();
            // Vill även få med vad det är för pris på produkten
            Console.WriteLine("Skriv vad produkten har för pris: ");
            // Här gör jag likadant att jag fångar med .TryParse
            bool produktPris = int.TryParse(Console.ReadLine(), out int pris);
            
            /*Allt fungerar när jag tar bort den här raden nedan
             Inget blir ju adderat till listan eftesom jag inte gör rätt.
            Jag har suttit i en timme och försökt kommit på det
            provat punkt. provat allt. Men minnet sviker mig.
            */

           Lager lager = new Lager (id, namnProdukt, produktTyp, pris);
           //Jag vet att det är ett ord jag missar...
            
            
            // Här vill jag fånga upp evebtuella felslagningar med sant eller falskt
            if (id == 0 || namnProdukt == "" || produktTyp == "" || pris == 0)
            {
                // Det här meddelandet visas om användaren matar in felaktiga val, exempel en bokstav där det ska vara ett tal
                Console.WriteLine("Fel inmatning, försök igen genom att trycka enter");
            }
            // Om alla användarens val går igenom så skickas det hit
            else
            {
                //Här skrivs ut vilken produkt som blir tillaggd till lsitan
                Console.WriteLine($"Du har lagt till {produktTyp} i listan");
                // här lägger vi in produkten till _lisa med Add och tar då det i från namnet lager
                _lista.Add(lager);

            }
            // Vill att menyn ska stanna tills användaren trycker flr att komma vidare till nästa steg
            Console.ReadLine();

        }
        // Här ska alla produkter visas i en lista
        public static void UI_VisaAllaProdukter()
        {
            // Gör en mini-meny vilket gör att användaren får en klar bild av hur det ska se ut
            Console.WriteLine("--- Visa alla produkter ---");
            Console.WriteLine();
            // lägger en foreach loop som skagå igenom listan och få ut alla produket
            foreach (var lager in _lista)
            {
                bool visaAlla = int.TryParse(Console.ReadLine(), out int id);
                // Här skriver jag ett meddelande som ska visa lagret.
                Console.WriteLine($"Här är alla produkter:{lager.Id} ");

            }
            Console.ReadLine();

        }
        public static void UI_TaBortProdukt()
        {
            // HÄr ska vi ta bort en produkt vill då att användaren ska skriva id
            Console.WriteLine("Skriv id på produkt du vill ta bort");
            // Vill då fånga upp eventuella felslagningar då det behöver vara en siffra
            bool removeProdukt = int.TryParse(Console.ReadLine(), out int id);
            // Här använder jag FirstOrDefault vilket gör det mer krashsäkert
            // Kollar även och jämför id
            Lager lager = _lista.FirstOrDefault(x => x.Id == id);

            // Här vill jag göra en ny koll så att användaren slår in rätt innan produkten tas bprt
            // kollar om id 
            if (removeProdukt == null)
            {
                //Användaren får det här meddelandet om id inte finns
                Console.WriteLine("Id finns inte, tryck enter för att försöka igen");
            }
            //Om id hittas så skickas användarens val hit och bekröftar då valet
            else
            {
                // Användaren får en validering av att produkten är borttagen
                Console.WriteLine("Produkten är borttagen ");
                //Använder .Remove för att ta bort produkten som är döpt till lager
                _lista.Remove(lager);
            }
            Console.ReadLine();
        }

        //Gör avsluta så att användaren kan stänga ner programmet med enter
        public static void UI_Avsluta()
        {
            Console.WriteLine("Tryck enter för att avsluta...");
            Console.ReadKey();
        }
    }
}

/* Jag har kommenterat alla rader för att jag ska rubber ducka mig själv ur paniken
 * MEn det har inte fungerat för jag har kommit på allt annat som jag strävat med
 * men jag får inte till Lager lager = _lager raden.
 * Har suttit med den i en timme och försökt men minnet sviker mig.
 * Det jobbiga är att jag vet att det troligtvis är ett ord som jag missat som 
 * gör att allt inte fungerar.*/