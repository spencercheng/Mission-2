using System;

namespace Mission_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice D = new Dice(); // Instantation

            Console.WriteLine("Welcome to the dice throwing simulator!"); 
            Console.Write("How many dice rolls would you like to simulate?"); // Prompts
            int diceRolls = Convert.ToInt32(Console.ReadLine()); // Asking them to enter number


            D.DiceRolls(diceRolls); // Calling class

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }
    }
}
