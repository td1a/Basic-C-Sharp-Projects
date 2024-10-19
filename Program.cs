using System;

namespace ShippingApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //all input needs to be numbers. introduce try block
            bool complete = false;
            while (!complete)
            {
                try
                {
                    Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
                    Console.WriteLine("What is the weight of the package (in kg)?");
                    string input1 = Console.ReadLine();
                    int weight = Convert.ToInt32(input1);
                    //If the weight is greater than 50, display the error message and end program
                    if (weight > 50)
                    {
                        Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                        return;
                    }

                    //Prompt user to enter width, height and length of package
                    Console.WriteLine("Please note: the sum of width, height and length of the package should not exceed 100cm");
                    Console.WriteLine("What is the width of the package (in cm)?");
                    string input2 = Console.ReadLine();
                    int width = Convert.ToInt32(input2);

                    Console.WriteLine("What is the height of the package (in cm)?");
                    string input3 = Console.ReadLine();
                    int height = Convert.ToInt32(input3);

                    Console.WriteLine("What is the length of the package (in cm)?");
                    string input4 = Console.ReadLine();
                    int length = Convert.ToInt32(input4);

                    //If the dimensions total greater than 50, display the error message and end program
                    int whl = width + height + length;
                    if (whl > 100)
                    {
                        Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                        return;
                    }

                    //calculate the volume times weight and then divide by 1000 is th quote
                    float quote = (width * height * length * weight) / 1000;

                    //display quote to user in dollar amount
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "\nThank you!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a integer number.");
                }
                finally
                {
                    complete = true;
                }
            }
        }

    }
}
