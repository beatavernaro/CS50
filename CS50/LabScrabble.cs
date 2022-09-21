using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50
{
    internal class LabScrabble
    {
        public static void Scrabble()
        {
            Console.Write("Player 1: ");
            var player1 = Console.ReadLine()!;
            Console.Write("Player 2: ");
            var player2 = Console.ReadLine()!;

            int score1 = ComputeScore(player1.ToUpper());
            int score2 = ComputeScore(player2.ToUpper());
            if (score1 > score2)
                Console.WriteLine("Player 1 wins!");
            else
                Console.WriteLine("Player 2 wins!");

        }

        public static int ComputeScore(string word)
        {
            int[] point = new int[] { 1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3, 1, 1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10 };
            int score = 0;
            foreach (var letter in word)
            {
                var letterAlpha = (int)letter;
                letterAlpha = letterAlpha - 65;

                for (int i = 0; i < point.Length; i++)
                {
                    if (letterAlpha == i)
                    {
                        score = score + point[i];
                    }
                }
            }
            return score;
        }
    }
}
