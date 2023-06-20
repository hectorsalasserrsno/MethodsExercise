using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int answer1 = Add(6, 7);  //excercise 1
            Console.WriteLine(answer1);
            int answer2 = Subtract(9, 7);
            Console.WriteLine(answer2);
            int answer3 = Multiply(63, 7);
            Console.WriteLine(answer3);
            int answer4 = Division(60, 5);
            Console.WriteLine(answer4);


            //exercise 1
            Console.WriteLine("what is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("what is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine("what is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("what is your favorite band?");
            var band = Console.ReadLine();
            Console.WriteLine($"Hello my name is {name}, when I went to africa there was a big {animal} on the road, the weird thing is that it was {color}, then it run to eat me, but I was saved by a helicopter driven by {band} singer");
        }

        // excercise 2
        public static int Add(int num1, int num2)
        {
            return num1 + num2;

        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;

        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;

        }
        public static int Division(int num1, int num2)
        {
            return num1 / num2;

        }
        
    }
}


    