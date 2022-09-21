using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50
{
    internal class Plurality
    {

        public static void Vote()
        {
            var candidates = new string[] { "Alice", "Bob", "Charlie" };
            var votes = new int[3];
            

            Console.Write("Voters: ");
            var numberVoters = int.Parse(Console.ReadLine()!);
            
            int i = 0;
            while(i < numberVoters){
                Console.Write("Vote: ");
                var vote = Console.ReadLine()!;

                for (int j = 0; j < 3; j++)
                {
                    
                    if (candidates[j].ToUpper() == vote.ToUpper())
                    {
                        votes[j]++;
                    }
                }
                i++;
            }

            Console.WriteLine(candidates[Array.IndexOf(votes, votes.Max())]);

        }
    }
}
