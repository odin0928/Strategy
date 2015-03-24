using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Custom;
using DiscountSolution;
using System.Runtime.InteropServices;
using System.Configuration;
namespace Homework01
{
    /// <summary>
    /// 作業：電影院售票
    ///需求如下：
    ///我們要幫電影院開發訂票系統，電影院有下面這些優惠方案：
    ///學生憑學生證可享受票價8折優惠。
    ///小朋友如果年齡在10周歲及以下的兒童3折，小學生與屁孩7折優惠。
    ///持花旗卡可以半價，並可累積點數，另外累積點數夠多，還可以換贈品。
    ///系統必須具有不修改現有程式就能更新折扣價格的彈性。
    ///票價的演算法需封裝成dll
    ///透過更新dll即可使用新的算法
    ///可以透過下拉式選單動態更換折扣算法。
    ///呼叫票價的方法可以透過設定檔完成。
    /// </summary>
    public partial class TicketSaleSytemWindow : Form
    {
        //票價由此載入App.config檔案
        private double ticketPrice = Properties.Settings.Default.TicketPrice;

        DiscountList discountList = new DiscountList();
        Discount discount = null;
        MovieTicket movieTicket;
        Customs VIP;
        Customs Student;
        Customs Chirdren;
        double TotalPrice { get; set; }
        List<string> subTotalString = new List<string>();
        public TicketSaleSytemWindow()
        {
            InitializeComponent();
            //宣告一個售票系統
            movieTicket = new MovieTicket();
            //宣告三種客戶
            VIP = new Customs("VIP");       
            Student = new Customs("學生");
            Chirdren = new Customs("屁孩");
            //加到表單供選擇
            comboBoxCustomList.Items.Add(VIP.身分);
            comboBoxCustomList.Items.Add(Student.身分);
            comboBoxCustomList.Items.Add(Chirdren.身分);

            if (comboBoxCustomList.Items.Count != 0) comboBoxCustomList.SelectedIndex = 0;

            List<string> DiscountSolutionList = new List<string>();

            DiscountSolutionList = discountList.GetDiscountSolutionList(Student.身分);
            foreach (string discount in DiscountSolutionList)
            {
                comboBoxStudentDiscountSolution.Items.Add(discount);
            }
            if (comboBoxStudentDiscountSolution.Items.Count != 0) comboBoxStudentDiscountSolution.SelectedIndex = 0;

            DiscountSolutionList.Clear();

            DiscountSolutionList = discountList.GetDiscountSolutionList(Chirdren.身分);
            foreach (string discount in DiscountSolutionList)
            {
                comboBoxChildrenDiscountSolution.Items.Add(discount);
            }

            if (comboBoxChildrenDiscountSolution.Items.Count != 0) comboBoxChildrenDiscountSolution.SelectedIndex = 0;

            DiscountSolutionList.Clear();

            DiscountSolutionList = discountList.GetDiscountSolutionList(VIP.身分);
            foreach (string discount in DiscountSolutionList)
            {
                comboBoxVIPDiscountSolution.Items.Add(discount);
            }

            if (comboBoxVIPDiscountSolution.Items.Count != 0) comboBoxVIPDiscountSolution.SelectedIndex = 0;
        }

        private void buttonCash_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string displayMessage;
            movieTicket.SetPrice(ticketPrice);
            
            double afterDiscountPrice;
            switch (comboBoxCustomList.SelectedItem.ToString())
            {
                case "VIP":
                    discount = VIPDiscount.Create();
                    discount.DisplayDiscount = comboBoxVIPDiscountSolution.SelectedItem.ToString();
                    break;
                case "學生":
                    discount = StudentDiscount.Create();
                    discount.DisplayDiscount = comboBoxStudentDiscountSolution.SelectedItem.ToString();
                    break;
                case "屁孩":
                    discount = ChildrenDiscount.Create();
                    discount.DisplayDiscount = comboBoxChildrenDiscountSolution.SelectedItem.ToString();
                    break;
                default:
                    break;
            }

            movieTicket.SetDiscount(discount);
            afterDiscountPrice = movieTicket.GetPrice() * (int)numericUpDownTicketNumber.Value;
            displayMessage = comboBoxCustomList.SelectedItem.ToString() + "票" + " 原價每張" + ticketPrice + "元" + "," + "共" + numericUpDownTicketNumber.Value.ToString() + "張" + "," + "特價" + afterDiscountPrice.ToString() + "元\n";
            subTotalString.Add(displayMessage);
            TotalPrice += afterDiscountPrice;
            foreach (string s in subTotalString)
            {
                richTextBox1.Text += s;
            }
            richTextBox1.Text += "總計" + TotalPrice.ToString() + "元\n";
            richTextBox1.Text += discount.BonusCheck() + "\n";

        }

        private void comboBoxCustomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxCustomList.SelectedItem.ToString())
            {
                case "成人":
                    comboBoxStudentDiscountSolution.Enabled = false;
                    comboBoxChildrenDiscountSolution.Enabled = false;
                    break;
                case "學生":
                    comboBoxStudentDiscountSolution.Enabled = true;
                    comboBoxChildrenDiscountSolution.Enabled = false;
                    break;
                case "屁孩":
                    comboBoxChildrenDiscountSolution.Enabled = true;
                    comboBoxStudentDiscountSolution.Enabled = false;
                    break;
            }
        }
    }
}
