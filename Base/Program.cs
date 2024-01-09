using System;

class Example
{
    public static void Main()
    {
        int playerChoice; // Variable to hold number

        ConsoleKeyInfo UserInput = Console.ReadKey(); // Get user input

        // We check input for a Digit
        if (char.IsDigit(UserInput.KeyChar))
        {
            playerChoice = int.Parse(UserInput.KeyChar.ToString()); // use Parse if it's a Digit

            Console.WriteLine(playerChoice);
            Console.ReadLine();

        }
    }
}