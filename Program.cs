using System;
using FSPG;


/////////////////////////////////////////////////////////////////////////////
// TODO:    BEFORE YOU WRITE ANY CODE: 
//          Read the Instructions.pdf file.
//          Run the example.exe to see how this program will behave.
//          Read through all of the TODOs. This will give you an overview
//          of how the program will be put together.

namespace Practice
{
    class Program
    {
        static string[] Greetings = { "Hello there!", "Welcome to the practice!", "Hi, user!",
                                "Hey, I am a program.", "You're running the best program ever!" };

        static void Main(string[] args)
        {
            // TODO: Display a random string from the Greetings array.
            var rand1 = new Random();
            int randString = rand1.Next(0, 4);
            Console.WriteLine(Greetings[randString]);
            Console.ReadLine();
            Console.Clear();

            // TODO: Ask the user for a positive number and then print the square of that number.
            //       Make sure your progarm does not crash if the user enters bad input.
            //       Make sure the user can keep entering input until they enter good input.
            Console.Write("Please enter a positive integer:  ");

            double userInput = Double.Parse(Console.ReadLine());
            
            if (userInput <= 0)
            {
                Console.WriteLine("Please make sure the integer is greater than 0\n" + "Enter a positive number:  ");

                userInput = Double.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nYour number is :  " + userInput);
            Console.ReadLine();
            Console.Clear();

            // TODO: Create an array of doubles. Use a random number (in the range of 3 to 6) for the size.
            //       For each element of the array, ask the user to enter a value and store
            //       it in the array. The input does not have to be error checked.
            double[] array1 = new double[6];
            Console.WriteLine("Please enter 6 numbers to fill an array");
            for (int i = 0; i < 6; i++)
            {
                array1[i] = Double.Parse(Console.ReadLine());
            }

            var rand2 = new Random();
            int randArray = rand2.Next(0,5);

            int randArrayPicker = randArray--;
            

            Console.WriteLine("The number " + randArrayPicker + " spot in the array is:  " + array1[randArray]);
            // TODO: Call the FindAverage method passing in the array of doubles and display
            //       the return value to the screen.

            Console.WriteLine("The average of this array is:  " + FindAverage(array1));

                Console.ReadLine();
        }

        // TODO: Write a method called FindAverage that takes an array of doubles and returns a double
        //       Don't forget to mark the method as static.

        // TODO: In the FindAverage method compute the average (the sum of all values divided by the number of values)
        //       of the values in the array parameter and return it.
        static double FindAverage(double[] array1)
        {
            double sum = 0;
            for (int i = 0; i < 6; i++)
            {
                sum += array1[i];
            }
            double average = sum / 6;
            return average;

            


        }
    }
}
