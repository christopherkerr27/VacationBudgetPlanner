using System;

namespace VacationBudgetPlanner2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vaction Budget Planner Application!");
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}! Where would you like to travel, Jamaica or Mexico?");
            var destination = Console.ReadLine();
            Console.WriteLine($"How many days would you like to be in {destination}?");
            var daysSpent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much spending money will you have?");
            var spendingMoney = Convert.ToDouble(Console.ReadLine());
            var moneyPerDay = spendingMoney / daysSpent;
            Console.WriteLine($"Hey {userName}, you are going to {destination} for {daysSpent} days with {spendingMoney} for spending money. You can spend {moneyPerDay} per day.");

        }
    }
}
