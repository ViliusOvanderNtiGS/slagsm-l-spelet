using System;

namespace slagsmål
{
    class Program
    {
        static void Main(string[] args)
        {

            bool noreplay = false;
            string askrp = "";
            while (!noreplay)
            {

                string play1 = "Lukas";
                string play2 = "Vidar";
                Console.WriteLine(play1 + " och " + play2 + " blir satans sura på varandra.");
                Console.WriteLine("Ditt jobb är att titta på och trycka Enter några gånger.");
                Console.WriteLine("Nu börjar skiten.");
                Console.ReadLine();
                int hp1 = 200;
                int hp2 = 200;


                Random generator = new Random();
                // Random secondGenerator = new Random();

                while (hp1 >= 0 && hp2 >= 0)
                {
                    int dmg1 = generator.Next(1, 31);
                    int dmg2 = generator.Next(1, 31);
                    hp1 = hp1 - dmg1;
                    hp2 = hp2 - dmg2;

                    Console.WriteLine(play1 + " har nu " + hp1 + " helsa kavar.");
                    Console.WriteLine(play2 + " har nu " + hp2 + " helsa kavar.");
                    Console.ReadLine();

                    // if (hp1 < 0 || hp2 < 0)
                    // {
                    //     hp1 = 0;
                    //     hp2 = 0;
                    // }
                }

                if (hp1 > hp2)
                {
                    Console.WriteLine(play1 + " vann!");
                    Console.WriteLine(play2 + " luktar");
                }
                if (hp1 < hp2)
                {
                    Console.WriteLine(play2 + " vann!");
                    Console.WriteLine(play1 + " luktar");
                }
                if (hp1 == hp2)
                {
                    Console.WriteLine("Ingen vann");
                    Console.WriteLine("Båda luktar");
                }

                Console.WriteLine("Vill du spela igen");
                Console.WriteLine("Ja/Nej");
                askrp = Console.ReadLine();
                if (askrp == "ja" || askrp == "Ja")
                {
                    noreplay = false;
                    Console.Clear();
                }
                else if (askrp == "nej" || askrp == "Nej")
                {
                    noreplay = true;
                }

            }
            // Console.ReadLine();

        }
    }
}
