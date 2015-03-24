using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Custom;
namespace DiscountSolution
{
    public class DiscountList
    {
        
        public DiscountList()
        {
            
        }

        /// <summary>
        /// 取得折扣方式清單，有新的優惠時，從此處修訂優惠項目名稱，在到對應的優惠對象類別中加入對應的計算方式
        /// </summary>
        /// <param name="custom"></param>
        /// <returns></returns>
        public List<string> GetDiscountSolutionList(string custom)
        {
            List<string> DiscountStringList = new List<string>();
            switch (custom)
            {
                case "VIP":
                    DiscountStringList.Add("無");
                    DiscountStringList.Add("花旗卡5折，並可累積點數換贈品");
                    break;
                case "學生":
                    DiscountStringList.Add("無");
                    DiscountStringList.Add("學生證8折");
                    break;
                case "屁孩":
                    DiscountStringList.Add("無");
                    DiscountStringList.Add("10周歲及以下的兒童3折");
                    DiscountStringList.Add("小學生與屁孩7折");
                    break;
            }
            return DiscountStringList;
        }
    }
}
