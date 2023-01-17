using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    class Dice
    {
        public void DiceRolls (int rolls)
        {
            int[] randomDiceRolls = new int[11]; // Array of 12 spots
            Random rnd = new Random(); // Calling Random "package"
            for (int j = 0; j < rolls; j++) // Generating dice rolls based on what the prompt was 
            {
               int dieNum1 = rnd.Next(1, 7);
               int dieNum2 = rnd.Next(1, 7);

                randomDiceRolls[dieNum1 + dieNum2 - 2]++; //  Storing it into the array
            }
            Console.WriteLine(" ");
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rolls);
            for (int i = 0; i < 11; i++)

            {
                double percentage = (randomDiceRolls[i] / (double)rolls) * 100; // Calculating the percentage

                Console.Write(i + 2 + ": "); // Printing 2-12

                for (int e = 0; e < percentage; e++) 
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

        }
    }
}
