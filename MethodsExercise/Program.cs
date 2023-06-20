using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)


        {
            int sum1 = Sums(2, 4); //extra excercise
            Console.WriteLine("Sum of 2 and 4: " + sum1);
            int sum2 = Sums(2, 4, 6);
            Console.WriteLine("Sum of 2,4 and 6: "+ sum2);
            int sum3 = Sums(1, 1, 1, 1, 1);
            Console.WriteLine("Sum of 1,1,1,1 and 1: "+  sum3);



            int answer1 = Add(6, 7);  //excercise 2
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
        public static int Sums(params int[] nums) // extra excercise
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }
        

    }
}


    