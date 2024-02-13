using System;

namespace _13._02
{
    internal class P
    {
        static void Main(string[] args)
        {
            double vip = 497.54, normal = 245.80;
            Console.Write("Enter the number of people in the group: ");
            int peopleCount = int.Parse(Console.ReadLine()), transport = peopleCount >= 1 && peopleCount <= 4 ? 75 : peopleCount >= 5 && peopleCount <= 9 ? 60 : peopleCount >= 10 && peopleCount <= 24 ? 50 : peopleCount >= 25 && peopleCount <= 49 ? 40 : 25;
            Console.Write("Enter the budget: ");
            double budget = double.Parse(Console.ReadLine()), leftBudget = budget * (1 - transport / 100.0);
            double costTickets;
            Console.Write("Enter the ticket category (VIP/Normal): ");
            string ticketType = Console.ReadLine().ToLower();
            if (ticketType == "vip") costTickets = vip * peopleCount;
            else if (ticketType == "normal") costTickets = normal * peopleCount;
            else { Console.WriteLine("Invalid ticket category."); return; }
            if (leftBudget >= costTickets) Console.WriteLine("You can buy the tickets! Enjoy the concert!");
            else Console.WriteLine($"You don't have enough money for the tickets. You need an additional {costTickets - leftBudget:F2} BGN.");
        }
    }
}
