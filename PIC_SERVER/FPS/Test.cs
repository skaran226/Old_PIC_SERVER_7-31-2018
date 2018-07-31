using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FPS
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        string sPassId = "";
        string sPassTime = "";
        int iPassPicNum;
        int iPassPumpNum;
        string sPassAmount = "";


        string sPurchage = "";
        string sPrice = "";
        string sVolume = "";
        string sPassGrade = "";
        string sPassChage = "";
        string sPassCompletedTime = "";
        string sPassShowTime = "";

        private void button1_Click(object sender, EventArgs e)
        {
            sPassId = DateTime.Now.ToString("yyMMddHHmmss") + new Random().Next(0, 10);
            sPassTime = DateTime.Now.ToString("yyMMddHHmmss");
            iPassPumpNum = new Random().Next(1, 8);
            iPassPicNum = new Random().Next(1, 8);

            DB.CreateTransaction(sPassId, sPassTime, iPassPicNum, iPassPumpNum);

            MessageBox.Show("Success Create transaction");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
            sPassAmount = new Random().Next(10, 100).ToString();
            DB.AuthorizeTransaction(sPassId, sPassAmount, sPassTime);

            MessageBox.Show("Success Authorization");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sPurchage = new Random().Next(20, 80).ToString();
            int amt = Convert.ToInt32(sPassAmount);
            int purchage = Convert.ToInt32(sPurchage);

            

            sPassChage = (amt - purchage).ToString();
            sPurchage = String.Format("{0:0.00}", sPurchage);
            sPassChage = String.Format("{0:0.00}", sPassChage);
            sPrice = "20";
            sVolume = (new Random().Next(7,14)/1000).ToString();
            sPassGrade = new Random().Next(1, 4).ToString();
            sPassCompletedTime = DateTime.Now.ToString("yyMMddHHmmss");
            sPassShowTime = DateTime.Now.ToString();

            //MessageBox.Show("Success Complete Transaction");

            if (purchage < amt)
            {
                DB.CompleteTransaction(sPassId, sPurchage, sPrice, sVolume, sPassGrade, sPassChage, sPassCompletedTime, sPassShowTime);
               // this.Hide();
                MessageBox.Show("Success ");
            }
            else {

                MessageBox.Show("error purchage amount greater then amt");
            }
           
           // MessageBox.Show("Success ");
        }
    }
}
