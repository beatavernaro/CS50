using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50
{
    internal class LabLlama
    {
        public static void Llama()
        {
            int init;
            int final;
            do
            {
                Console.Write("Digite a população inicial: ");
                init = int.Parse(Console.ReadLine()!);
            } while (init < 9);

            do
            {
                Console.Write("Digite a população final: ");
                final = int.Parse(Console.ReadLine()!);
            } while (final < init);

            int pop = init;
            int cont = 0;

            while (pop < final)
            {
                pop = pop + (pop / 3) - (pop / 4);
                cont++;
            }

            Console.WriteLine($"Year: {cont}");
        }

    }
}
