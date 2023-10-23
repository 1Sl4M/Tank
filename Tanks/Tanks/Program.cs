using ClassLibrary1.WordOfTanks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class Program
    {
        static void Main()
        {
            Tank[] t34 = new Tank[5];
            Tank[] pantherTanks = new Tank[5];

            for (int i = 0; i < 5; i++)
            {
                t34[i] = new Tank("T-34");
                pantherTanks[i] = new Tank("Panther");
            }

            for (int i = 0; i < 5; i++)
            {
                bool t34Wins = t34[i] ^ pantherTanks[i];

                if (t34Wins)
                {
                    Console.WriteLine($"Battle {i + 1}: T-34 wins against Panther");
                }
                else
                {
                    Console.WriteLine($"Battle {i + 1}: Panther wins against T-34");
                }
                Console.ReadLine();
            }
        }
    }
}
