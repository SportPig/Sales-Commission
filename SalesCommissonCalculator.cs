using System;

namespace SalesCommissionCalculator
{
    class SalesCommisionCalculator
    {
        static void Main(string[] args)
        {
            int item1Sold = 0;
            int item2Sold = 0;
            int item3Sold = 0;
            int item4Sold = 0;

            Console.WriteLine("Sales Commission Calculator");
            Console.WriteLine("============================");


            //input-input
            Console.WriteLine("Enter total of item 1 sold");
            item1Sold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter total of item 2 sold");
            item2Sold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter total of item 3 sold");
            item3Sold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter total of item 4 sold");
            item4Sold = Convert.ToInt32(Console.ReadLine());

            Commission cs = new Commission(item1Sold, item2Sold, item3Sold, item4Sold);
            Console.WriteLine("============================");
            Console.WriteLine("");

            //total sales
            Console.WriteLine($"Total Items Sold for the week = {item1Sold + item2Sold + item3Sold + item4Sold}");
            Console.WriteLine("Total Sales for the week = {0:C}", cs.GetTotalSales());
            Console.WriteLine("");
            Console.WriteLine("===============================");
            Console.WriteLine("");

            //total earnings
            Console.WriteLine("Total Earnings (Weekly Pay ($200) + Commission)  = {0:C}", cs.CommissionRate());
            Console.ReadLine();
        }

    }
}
