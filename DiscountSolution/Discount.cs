using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountSolution
{
    /// <summary>
    /// 折扣抽象類別
    /// </summary>
    public abstract class Discount:IBonus
    {
        public string DisplayDiscount { get; set; }
        public abstract double Calculate(double price);
        public abstract string BonusCheck();

    }
}
