using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50
{
    internal class Caesar
    {
        public static void Cypher()
        {
            int cypherNumber = 0;
            char cypherLetter;

            Console.WriteLine("Digite o texto para cifrar: ");
            var text = Console.ReadLine()!;

            Console.WriteLine("Digite a chave: ");
            int key = int.Parse(Console.ReadLine()!);

            string cypherText = "";

            foreach (char letter in text)
            {
                int numberLetter = (int)letter;

                if (numberLetter >= 65 && numberLetter <= 90)
                {
                    numberLetter = numberLetter - 65;
                    cypherNumber = ((numberLetter + key) % 26) + 65;
                    cypherLetter = (char)cypherNumber;
                }
                else
                if (numberLetter >= 97 && numberLetter <= 122)
                {
                    numberLetter = numberLetter - 97;
                    cypherNumber = ((numberLetter + key) % 26) + 97;
                    cypherLetter = (char)cypherNumber;

                }
                else
                {
                    cypherLetter = letter;
                }

                cypherText += cypherLetter;
            }
            Console.WriteLine(cypherText);
        }
    }
}
