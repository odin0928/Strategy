using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountSolution
{
    /// <summary>
    /// 學生折扣
    /// </summary>
    public class StudentDiscount : Discount
    {
        static StudentDiscount student;
        public static StudentDiscount Create()
        {
            if (student == null)
            {
                return student = new StudentDiscount();
            }
            return student;
        }
        public StudentDiscount()
        {
            DisplayDiscount = string.Empty;
        }
        public override double Calculate(double price)
        {
            switch (DisplayDiscount)
            {
                case "無":
                    return price;
                case "學生證8折":
                    return price * 0.8;
                default:
                    return price;
            }
        }

        public override string BonusCheck()
        {
            return "沒有紅利";
        }
    }
}
