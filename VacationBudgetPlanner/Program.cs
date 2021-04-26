using System;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the vacation budget planner app.");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, What country would you like to travel to: Singapore or Bali?");
        }
    }
}
