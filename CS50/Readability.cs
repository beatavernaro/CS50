using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50
{
    internal class Readability
    {

        public static void Read()
        {
            Console.WriteLine("Digite o texto para avaliar: ");
            string text = Console.ReadLine()!;
            double words = 1;
            double sentence = 0;
            double letters = 0;
            text = text.Replace("'", "*");

            foreach (var letter in text)
            {
                if (letter.Equals(' '))
                {
                    words++;

                }
                else if (letter.Equals('.') || letter.Equals('!') || letter.Equals('?'))
                {
                    sentence++;

                }
                else if (letter.Equals('*'))
                {
                    continue;
                }
                else
                {
                    letters++;
                }
            }

            double l = (letters / words) * 100.00;
            double s = (sentence / words) * 100.00;
            double indice = (0.0588 * l) - (0.296 * s) - 15.8;

            double grade = Math.Round(indice);

            Console.WriteLine();
            if (grade < 1)
                Console.WriteLine("Before Grade 1");
            if (grade >= 16)
                Console.WriteLine("Grade 16+");
            else
                Console.WriteLine($"Grade {grade}");
        }
    }
}
