using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    internal class Program

    {
        static void Main(string[] args)
        {
            //Henrik Rydén SUT22.

            bool loopbool = true;
            while (loopbool == true)
            {
                Console.WriteLine("Välj svårighetsgrad!  Lätt [1] - Medel [2] - Svår [3]");
                // felhantering utifall användaren skulle skriva något annat än 1,2 eller 3.
                if (!int.TryParse(Console.ReadLine(), out int userInput))
                {
                    Console.WriteLine(" Fel, du måste använda en siffra. Använd valfri tangent för att börja om!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                if (userInput > 3)
                // felhantering utifall användaren skulle skriva något annat än 1,2 eller 3.
                {
                    Console.WriteLine(" Fel, Talet är för högt. Använd valfri tangent för att börja om!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                int number = 0;
                switch (userInput)
                {  // de tre olika cases som kallar på olika metoder för svårighetsgrad.
                    case 1:
                        userInput = 1;
                        number = Easy();
                        Console.Clear();
                        Console.WriteLine("Du valde Lätt. Jag tänker på ett nummer, kan du gissa vilket? - du får fem försök!");
                        Console.WriteLine("Gissa på en siffra mellan 1 och 5!");
                        break;
                    case 2:
                        userInput = 2;
                        number = Medium();
                        Console.Clear();
                        Console.WriteLine("Du valde medel. Jag tänker på ett nummer, kan du gissa vilket? - du får fem försök!");
                        Console.WriteLine("Gissa på en siffra mellan 1 och 10!");
                        break;
                    case 3:
                        userInput = 3;
                        number = Hard();
                        Console.Clear();
                        Console.WriteLine("Du valde Svår. Jag tänker på ett nummer, kan du gissa vilket? - du får fem försök!");
                        Console.WriteLine("Gissa på en siffra mellan 1 och 20!");
                        break;
                }
                // loopar fem gånger så du har fem försök på dig.
                for (int i = 0; i < 5; i++)
                    if (!int.TryParse(Console.ReadLine(), out int guess))
                    {
                        Console.WriteLine("Du måste välja en siffra!");
                        continue;
                    }
                    else
                    {
                        if (guess == number)
                        {
                            Console.WriteLine("WOHO! du gjorde det!");
                            return;
                        }
                        else if (guess < number)
                        {
                            Console.WriteLine(" Tyvärr du gissade för lågt.");
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("Tyvärr du gissade för högt.");
                        }
                    }
                {
                    Console.WriteLine("Du lyckade tyvärr inte på fem försök. - Bättre lycka nästa gång!");
                    return;
                }
            }
        }
        // Metoder som jag kallar på i main metoden för att bestämma svårighetsgrad.
        public static int Easy()
        {
            Random random = new Random();
            int number1 = random.Next(1, 5);
            return number1;
        }
        public static int Medium()
        {
            Random random = new Random();
            int number1 = random.Next(1, 10);
            return number1;
        }
        public static int Hard()
        {
            Random random = new Random();
            int number1 = random.Next(1, 20);
            return number1;
        }

    }
}





