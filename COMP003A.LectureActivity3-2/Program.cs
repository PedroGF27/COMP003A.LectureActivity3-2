//Pedro Garcia
//COMP003A
//Johnathan Cruz
//Lecture Activity 3-1
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
            \// Display table in reverse usin a while loop
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

            Console.WriteLine("\nFib");
        }
    }
}
