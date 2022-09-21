using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50
{
    internal class LuhnAlgorithm
    {
        public static void Luhn()
        {
            Console.WriteLine("Numero cartão: ");
            long card = long.Parse(Console.ReadLine()!);
            long lastNumber = 0;
            int cont = 0;
            long prod;
            long sumOther = 0;
            long sumProd = 0;

            while (card > 1)
            {

                lastNumber = card % 10;
                card = card / 10;
                cont++;

                if (cont % 2 == 0)
                {
                    prod = lastNumber * 2;
                    if (prod > 9)
                    {
                        sumProd = sumProd + (prod % 10) + (prod / 10);
                    }
                    else
                    {
                        sumProd = sumProd + prod;
                    }
                }
                else
                {
                    sumOther = sumOther + lastNumber;
                }
            }

            if ((sumProd + sumOther) % 10 == 0)
            {
                switch (lastNumber)
                {
                    case 3:
                        Console.WriteLine("American Express");
                        break;
                    case 4:
                        Console.WriteLine("Visa");
                        break;
                    case 5:
                        Console.WriteLine("Master Card");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
