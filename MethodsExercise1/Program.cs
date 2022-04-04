using System;

namespace MethodsExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine("What is your favorite food to eat?");
            var food = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Your name is {name}! You're wearing your favorite {color} {band} shirt. " +
                $"You're on your way to get {food} for dinner later. You see a {color} {animal} along the way!");



        }
    }
}
