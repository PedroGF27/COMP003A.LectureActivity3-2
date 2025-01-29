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

            int num;
            Console.Write("Enter a positive integer to generate its multiplication table: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication Table for {num}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }

            Console.WriteLine("\nReversed Multiplication Table:");
            int reverse = 10;
        }
    }
}
