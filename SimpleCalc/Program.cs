using System;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user for input
            Console.WriteLine("This program is a simple calculator. You can enter 2 numbers and add, subtract, multiply, or divide them.");
            Console.WriteLine("Please enter the first number:");

            //obtain first number from the user and turn it from string to integer
            string numFirstStr = Console.ReadLine();
            int numFirstInt = int.Parse(numFirstStr);
            Console.WriteLine("The first number is " + numFirstInt + ". Please enter the second number:");

            //obtain second number from the user and turn it from string to integer
            string numSecStr = Console.ReadLine();
            int numSecInt = int.Parse(numSecStr);
            Console.WriteLine("The numbers are " + numFirstInt + " and " + numSecInt + ".");
            Console.WriteLine("Would you like to add, subtract, multiply, or divide?");

            //obtain desired mathematical operation the user and set a placeholder value to the equation's output
            string mathOperation = Console.ReadLine();
            int numFinalInt = 0;

            //math
            if (mathOperation == "add")
            {
                numFinalInt = numFirstInt + numSecInt;
            }
            else if (mathOperation == "subtract")
            {
                numFinalInt = numFirstInt - numSecInt;
            }
            else if (mathOperation == "multiply")
            {
                numFinalInt = numFirstInt * numSecInt;
            }
            else if (mathOperation == "divide")
            {
                numFinalInt = numFirstInt / numSecInt;
            }
            else
            {
                Console.WriteLine("Error!");
            }

            //display the answer to the equation and keep the window open until further user input
            Console.WriteLine("Your final number is: " + numFinalInt);
            Console.ReadLine();

        }
    }
}
