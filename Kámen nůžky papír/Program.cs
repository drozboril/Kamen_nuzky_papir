using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kámen_nůžky_papír
{
    class Program
    {
        static void Main(string[] args)
        {
            int bot = 0;
            int hrac = 0;
            Console.WriteLine("1 = kámen\n2 = nůžky\n3 = papír");
            int vstup = int.Parse(Console.ReadLine());

            if (vstup < 1 || vstup > 3)
            {
                Console.WriteLine("Neplatný vstup");
                Console.ReadLine();
            }
            else while (hrac != 5 && bot != 5)
            {
                Random rand = new Random();
                int r = rand.Next(1, 4);
                
                if (vstup == 1 && r == 2 || vstup == 2 && r == 3 || vstup == 3 && r == 1)
                {
                    hrac++;
                    Console.WriteLine("Vyhrál(a) jste\nVy: {0}\nPC:{1}", hrac, bot);
                    Console.ReadLine();
                }
                else if (vstup == 1 && r == 3 || vstup == 2 && r == 1 || vstup == 3 && r == 2)
                {
                    bot++;
                    Console.WriteLine("Prohrál(a) jste\nVy: {0}\nPC:{1}", hrac, bot);
                    Console.ReadLine();
                }
                if (vstup == r)
                {
                    hrac++;
                    bot++;
                    Console.WriteLine("Remíza\nVy: {0}\nPC:{1}", hrac, bot);
                    Console.ReadLine();
                }
            }
        }
    }
}