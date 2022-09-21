using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50
{
    internal class GreedyAlgorithm
    {
        public static void Greedy()
        {
            Console.WriteLine("Valor: ");
            double c = double.Parse(Console.ReadLine()!);
            double change = c * 100;

            int coinCounter = 0;

            while (change > 0)
            {
                if (change >= 25)
                {
                    change = change - 25;
                    coinCounter++;
                }
                else if (change >= 10)
                {
                    change = change - 10;
                    coinCounter++;
                }
                else if (change >= 5)
                {
                    change = change - 5;
                    coinCounter++;
                }
                else if (change >= 1)
                {
                    change = change - 1;
                    coinCounter++;
                }

            }
            Console.WriteLine($"Moedas: {coinCounter}");
        }
    }
}
