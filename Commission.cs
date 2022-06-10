using System;
using System.Collections.Generic;
using System.Text;

namespace SalesCommissionCalculator
{
    class Commission
    {
        private const decimal ITEM1 = 239.9M;
        private const decimal ITEM2 = 129.75M;
        private const decimal ITEM3 = 99.95M;
        private const decimal ITEM4 = 350.89M;
        private const decimal WEEKLY_PAY = 200.00M;
        private const decimal PERCENTAGE = 0.09M;
  

        public Commission(int item1Sold, int item2Sold, int item3Sold, int item4Sold)
        {
            Item1Sold = item1Sold;
            Item2Sold = item1Sold;
            Item3Sold = item1Sold;
            Item4Sold = item1Sold;
        }

        public int Item1Sold { get; set; }
        public int Item2Sold { get; set; }
        public int Item3Sold { get; set; }
        public int Item4Sold { get; set; }

        public decimal GetTotalSales()
        {
            return ITEM1 * Item1Sold + ITEM2 * Item2Sold + ITEM3 * Item3Sold + ITEM4 * Item4Sold;
        }

        public decimal CommissionRate()
        {
            return GetTotalSales() * PERCENTAGE + WEEKLY_PAY;
        }
    }
}
