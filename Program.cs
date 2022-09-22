

using System.ComponentModel;

namespace Zahlenratespiel
{
    

    class Ratespiel 
    {
        //Zahlsp = Zahl des Spieler
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            int Gewonnen = 0;
            int randomCeiling = 100;
            Console.Write("Bitte geben sie ihren Namen ein: ");
            string Name = (Console.ReadLine());

        start:
        
            Random Zahl = new Random();
            int randomzahl = Zahl.Next(0, randomCeiling);
            Console.ForegroundColor = ConsoleColor.Blue;
            int Anzahlversüche = 0;
            int Zahlsp = 0;
            
            space();

            do
            {
                try
                { 
                Console.WriteLine("Geben sie bitte eine Zahl zwischen 0-" + randomCeiling + " ein: ");
                Zahlsp = Convert.ToInt32(Console.ReadLine());
                space();
                
                

                    if (Zahlsp < 0 || Zahlsp > randomCeiling)
                    {
                        Console.WriteLine("Bitte gib doch eine Zahl zwischen 0 und " + randomCeiling + " ein");
                        throw new Exception();
                    }

                }
                catch 
                {
                    Console.WriteLine("Fehlerhafte Eingabe");
                    space();
                    continue;

                }

                if (Zahlsp > randomzahl)
                {
                    Console.WriteLine("Die Zahl ist kleiner als deine getippte Zahl");
                    space();
                }

                if (Zahlsp < randomzahl)
                {

                    Console.WriteLine("Die Zahl ist grösser als deine getippte Zahl");
                    space();
                }

                Anzahlversüche = Anzahlversüche + 1;

            } while (randomzahl != Zahlsp);


            if (randomzahl == Zahlsp)
            {
                Console.WriteLine("Du hast gewonnen " + Name + " ich wusste, dass du das schaffst, die Zahl war.: " + randomzahl + " und du hast dafür " + Anzahlversüche +
              " versuche gebraucht. Du hast schon " + Gewonnen + " gewonnen");
                space();
            }

            if (Anzahlversüche < 4)
            {
                Console.WriteLine("Du warst sehr gut.");
                space();
            }   
            else
            {
                Console.WriteLine("Nächstes mal bist du besser.");
                space();
            }

            if (Gewonnen > 2)
            {
                Console.WriteLine("Möchten sie den Hardcore Modus spielen Ja/1 Nein/2");
                int entscheidung = Convert.ToInt32(Console.ReadLine());

                if (entscheidung == 1)
                {
                    Console.WriteLine("Sie können nun ihre eigene Zahl festlegen von 0 bis x ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    randomCeiling = x;
                }
               
            }
            Console.WriteLine("Möchten sie nochmal spielen Ja (1) Nein (2)");
            int replay = Convert.ToInt32(Console.ReadLine());


            if (replay == 1)
            {
                Gewonnen = Gewonnen + 1;
                goto start;

            }
            else
            {
                Environment.Exit(0);

           
            
            }

            void space()
            {
                Console.WriteLine();
            }
        }  
    }
}












































