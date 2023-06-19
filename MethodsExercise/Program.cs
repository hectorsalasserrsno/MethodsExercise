using System.Diagnostics.CodeAnalysis;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
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
    }
}
