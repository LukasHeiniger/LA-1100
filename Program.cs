

namespace Zahlenratespiel
{

    class Ratespiel
    {
        //Zahlsp = Zahl des Spieler
        static void Main(string[] args)
        {

            int Gewonnen = 0;
            int randomCeiling = 100;

        start:
        
            Random Zahl = new Random();
            
            int randomzahl = Zahl.Next(0, randomCeiling);

            int Anzahlversüche = 0;
            int Zahlsp;
            Console.WriteLine(randomzahl);
            Console.Write("Bitte geben sie ihren Namen ein: ");
            string Name = (Console.ReadLine());
            Console.WriteLine(Name);

            do
            {
                Console.WriteLine("Geben sie bitte eine Zahl zwischen 0-" + randomCeiling + " ein: ");
                Zahlsp = Convert.ToInt32(Console.ReadLine());
                try
                {


                    if (Zahlsp < 0 || Zahlsp > randomCeiling)
                    {
                        Console.WriteLine("Bitte gib doch eine Zahl zwischen 0 und " + randomCeiling + " ein");
                        throw new Exception();

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());


                }

                if (Zahlsp > randomzahl)
                {
                    Console.WriteLine("Die Zahl ist kleiner als deine getippte Zahl");

                }

                if (Zahlsp < randomzahl)
                {

                    Console.WriteLine("Die Zahl ist grösser als deine getippte Zahl");

                }

                Anzahlversüche = Anzahlversüche + 1;


            } while (randomzahl != Zahlsp);


            if (randomzahl == Zahlsp)
            {
                Console.WriteLine("Du hast gewonnen " + Name + " ich wusste, dass du das schaffst, die Zahl war.: " + randomzahl + " und du hast dafür " + Anzahlversüche +
              " versuche gebraucht. Du hast schon " + Gewonnen + " gewonnen");

            }


            if (Anzahlversüche < 4)
            {
                Console.WriteLine("Du warst sehr gut.");
            }
            else
            {
                Console.WriteLine("Nächstes mal bist du besser.");
            }


            if (Gewonnen == 2)
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


        }  

   
    }


}













































