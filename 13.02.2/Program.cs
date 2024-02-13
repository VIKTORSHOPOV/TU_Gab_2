using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double roses = 7.89, tulips = 5.89, orchids = 45.32, arrangement = 5, holidayPrice = 1.15;
            bool SpringorSummer;
            int numberRoses, numberTulips, orchidsCount, totalFlowers = 0;
            Console.WriteLine("Enter the number of red roses:");
            numberRoses = int.Parse(Console.ReadLine());
            totalFlowers += numberRoses;
            Console.WriteLine("Enter the number of tulips:");
            numberTulips = int.Parse(Console.ReadLine());
            totalFlowers += numberTulips;
            Console.WriteLine("Enter the number of orchids:");
            orchidsCount = int.Parse(Console.ReadLine());
            totalFlowers += orchidsCount;
            SpringorSummer = IsSpringOrSummer();
            double priceBefore = (numberRoses * roses) + (numberTulips * tulips) + (orchidsCount * orchids) + arrangement;
            priceBefore *= holidayPrice;
            double priceAfter = ApplyDiscounts(priceBefore, numberRoses, numberTulips, totalFlowers, SpringorSummer);
            DisplayReceipt(numberRoses, numberTulips, orchidsCount, roses, tulips, orchids, arrangement, priceAfter);
        }

        static double ApplyDiscounts(double priceBefore, int numberRoses, int numberTulips, int totalFlowers, bool SpringorSummer)
        {
            if (SpringorSummer && numberTulips >= 3) priceBefore -= priceBefore * 0.05;
            if (SpringorSummer && numberRoses >= 12) priceBefore -= priceBefore * 0.10;
            if (totalFlowers > 22) priceBefore -= priceBefore * 0.23;
            return priceBefore;
        }

        static bool IsSpringOrSummer() => DateTime.Now.Month >= 3 && DateTime.Now.Month <= 8;

        static void DisplayReceipt(int roses, int tulips, int orchids, double rosesCount, double tulipsCount, double orchidsCount, double arrangment, double totalaPrice)
        {
            Console.WriteLine("╔═════════════════════════════════════════╗");
            Console.WriteLine("║                 Receipt                 ║");
            Console.WriteLine("╠═════════════════════════════════════════╣");
            Console.WriteLine($"║ Red Roses:        {roses,-4} x {rosesCount,-10:F2} BGN ║");
            Console.WriteLine($"║ Tulips:           {tulips,-4} x {tulipsCount,-10:F2} BGN ║");
            Console.WriteLine($"║ Orchids:          {orchids,-4} x {orchidsCount,-10:F2} BGN ║");
            Console.WriteLine($"║ Arrangement Price:      {arrangment,-10:F2}  BGN ║");
            Console.WriteLine($"║ Total Price:            {totalaPrice,-10:F2}  BGN ║");
            Console.WriteLine("╚═════════════════════════════════════════╝");
        }
    }
}
