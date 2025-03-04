﻿//Pedro Garcia
//COMP003A
//Johnathan Cruz
//Lecture Activity 3-2
namespace COMP003A.LectureActivity3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Iterative Statements Demo\n");

            // Prompt to put positive integer
            int num;
            Console.Write("Enter a positive integer to generate its multiplication table: ");
            num = int.Parse(Console.ReadLine());

            // Generate multiplication table for loop
            Console.WriteLine($"Multiplication Table for {num}:");

            // Loop that generates multiplication table
            // 1st statement: initializes loop variable i to 1
            // 2nd statement: specifies condition for loop to continue
            // 3rd statement: increments loop variable i by 1
            for (int i = 1; i <= 10; i++)
            {
                // shows multiplication table
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
            // Display table in reverse usin a while loop
            Console.WriteLine("\nReversed Multiplication Table:");
            int reverse = 10;

            // loop that generates multiplication table in reverse
            while (reverse > 0)
            {
                // Displays multiplication table in reverse
                Console.WriteLine($"{reverse} x {num} = {reverse * num}");

                // decrement reverse
                reverse--;
            }

            // Display fibonacci series using a do-while loop
            Console.WriteLine("\nFibonacci Series:");
            int firstNumber = 0, secondNumber = 1, nextNumber;// first two numbers
            Console.Write($"{firstNumber} {secondNumber} "); // display first two numbers
            int count = 2; // count starts at 2

            // loop that generates next ten numbers in the series
            do
            {
                nextNumber = firstNumber + secondNumber; // calculate next number
                Console.Write($"{nextNumber} "); // display next number
                firstNumber = secondNumber; // update first number
                secondNumber = nextNumber; // update second number
                count++; // increment count
            } while (count < 10); // loop until count reaches 10

            // create array of fruits | data structure preview
            string[] fruits = { "Apple", "Mango", "Orange", "Kiwi" };

            Console.WriteLine("\n");

            // displays each fruit using foreach loop
            Console.WriteLine("Your favorite fruits are:");

            // loop through each fruit in array
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }
        }
    }
}
