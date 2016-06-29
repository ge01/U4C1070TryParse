using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4C1070TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  the following code attempts to add two numbers. 
            If either of the two numbers cannot be parsed then 
            the message "You did not enter valid numbers!" 
            is displayed.*/

            // get first number
            Console.Write("Enter the first number:");
            var firstNum = 0;
            var firstNumIsNumber = int.TryParse(Console.ReadLine(), out firstNum);

            // get second number
            Console.Write("Enter the second number:");
            var secondNum = 0;
            var secondNumIsNumber = int.TryParse(Console.ReadLine(), out secondNum);

            // display result
            if (firstNumIsNumber && secondNumIsNumber)
            {
                var result = firstNum + secondNum;
                Console.WriteLine("The result is " + result.ToString());
            }
            else
            {
                Console.WriteLine("You did not enter valid numbers!");
            }

            // pause
            Console.ReadLine();
        }
    }
}
