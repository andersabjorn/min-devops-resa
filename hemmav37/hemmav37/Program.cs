using System;

namespace TypeConversionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är basen?");
            string baseText = Console.ReadLine();

            int userBase;
            try
            {
                userBase = Convert.ToInt32(baseText);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ogiltig bas – använd heltal!");
                Console.ReadKey(); 
                return; 
            }
            Console.WriteLine("Vad är höjden?");
            string heightText = Console.ReadLine();
        
            int userHeight;
            try
            {
                userHeight = Convert.ToInt32(heightText);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ogiltig höjd – använd heltal!");
                Console.ReadKey(); 
                return;
            }
            double area = (userBase * userHeight) / 2.0; 
            Console.WriteLine($"Arean är {area:F1} kvadratenheter");
            Console.WriteLine($"Beräkning: {userBase} * {userHeight} / 2 = {area}");

            Console.ReadKey();
        }

    }
}
