using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscountSolution;
namespace Homework01
{
    /// <summary>
    /// 售票系統
    /// </summary>
    class MovieTicket
    {
        Discount NowDisocunt;
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public void SetDiscount(Discount discount)
        {
            NowDisocunt = discount;
            Price = NowDisocunt.Calculate(price);
        }
        public void SetPrice(double price)
        {
            Price = price;
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}
