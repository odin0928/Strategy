using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountSolution
{
    /// <summary>
    /// 小孩折扣
    /// </summary>
    public class ChildrenDiscount:Discount
    {
        static ChildrenDiscount children;
        public static ChildrenDiscount Create()
        {
            if (children == null)
            {
                return children = new ChildrenDiscount();
            }
            return children;
        }
        public ChildrenDiscount()
        {
            DisplayDiscount = string.Empty;
        }
        public override double Calculate(double price)
        {
            switch (DisplayDiscount)
            {
                case "無":
                    return price;
                case "10周歲及以下的兒童3折":
                    return price * 0.3;
                case "小學生與屁孩7折":
                    return price * 0.7;
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
