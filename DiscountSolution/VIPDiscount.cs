using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountSolution
{
    /// <summary>
    /// 花旗卡折扣
    /// </summary>
    public class VIPDiscount:Discount,IBonus
    {
        public int BonusPoint { get; set; }

        static VIPDiscount vip;
        public static VIPDiscount Create()
        {
            if (vip == null)
            {
                return vip = new VIPDiscount();
            }
            return vip;
        }
        public VIPDiscount()
        {
            DisplayDiscount = string.Empty;
        }
        public override double Calculate(double price)
        {
            switch (DisplayDiscount)
            {
                case "無":
                    return price;
                case "花旗卡5折，並可累積點數換贈品":
                    BonusPoint++;
                    return price * 0.5;
                default:
                    return price;
            }
        }
        public override string BonusCheck()
        {
            string display = string.Empty;
            if (BonusPoint < 8)
            {
                display = string.Format("花旗卡點數累積，集8點可以換獎品，目前點數有{0}點", this.BonusPoint);
                return display;
            }
            else
            {
                display = string.Format("目前點數有{0}點，換得草泥馬娃娃一隻", this.BonusPoint);
                this.BonusPoint -= 8;
                return display;
            }
            
        }
    }
}
