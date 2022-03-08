using System;

namespace MethodsExerciseConsole
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is the name of your cat?");
            string userCatName = Console.ReadLine();

            Console.WriteLine("What color is your cat?");
            string userCatColor = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}, he was {age} years old.");
            Console.WriteLine($"He had a {userCatColor} cat named {userCatName}.");
            Console.WriteLine($"{userName} loved to pet {userCatName}. But {userCatName} didn't like it.");

            Console.WriteLine("give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"the sum is: {sum}");


            Console.WriteLine("give me a number to add");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"the product is: {product}");

        }
        public static int Sum(int num1, int num2)
        {

            return num1 + num2;



        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}

