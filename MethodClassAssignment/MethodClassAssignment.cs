using System;

namespace MethodClass
{
    class Program
    {

        /*Perform these actions and create a console app that includes the following:

        Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. */


        // Create a class. In that class, create a void method that takes two integers as parameters.
        // Have the method do a math operation on the first integer and display the second integer to the screen.
        public class Calculation
        {
            public int Adding(int a, int b)
            {
                int sum = a + b;
                Console.WriteLine("The second operand is: {0}", b);
                return sum;
            }
        }
        // In the Main() method of the console app, instantiate the class.
        static void Main(string[] args)

        {
        //Call the method in the class, specifying the parameters by name.
            var calc = new Calculation();
            int x = 5, y = 8;

         //       Call the method in the class, passing in two numbers.
            int result = calc.Adding(x, y);
         // expected result = 13, display second operand y = 8

            Console.WriteLine(result);

        }
    }
}
