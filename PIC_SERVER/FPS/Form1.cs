using System;
using System.Collections.Generic;
using System.Text;

using System.IO.Ports;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Management;
using System.Data.OleDb;
using System.Drawing;
using System.Data.SqlClient;
using System.Data.Sql;

namespace FPS
{
    public partial class Form1 : Form
    {
        delegate void SetLabelTextCallback(Label lbPassLabel, string sPassText);
        delegate void SetLabelVisibleCallback(Label lbPassLabel, bool bVisible);
        delegate void SetButtonTextCallback(Button btPassButton, string sPassText);
        delegate void SetButtonColorCallback(Button btPassButton, Color cPassColor);
        delegate void SetButtonVisibleCallback(Button btPassButton, bool bVisible);
        delegate void SetTextBoxTextCallback(TextBox tbPassTextBox, string sPassText);
        delegate void SetTextBoxVisibleCallback(TextBox tbPassTextBox, bool bVisible);

        delegate void SetCheckBoxVisibleCallback(CheckBox checkBox, bool bVisible);


        /*used up and down variables*/
       public static int i = 1;
       public static int s = 1; 


        public Form1()
        {
            //Cursor.Hide();

            InitializeComponent();
            //Config_AutoEOD();
            EnableDisableUpDown();

           // new SetDataTime().HideForm();


                

        }



        public void EnableDisableUpDown(){

            if (this.button1.Text == "")
            {

                this.up_btn.Visible = false;
                this.down_btn.Visible = false;
            }
            else
            {
                this.up_btn.Visible = true;
                this.down_btn.Visible = true;
                Display.SelectButton(1);
            }


            
        
        }

        public void DisableAllUpDown() {

            this.up_btn.Visible = false;
            this.down_btn.Visible = false;
        }

        public void SetLableText(Label lbPassLabel, string sPassText)
        {
            if (lbPassLabel.InvokeRequired)
            {
                SetLabelTextCallback d = new SetLabelTextCallback(SetLableText);
                this.Invoke(d, new object[] { lbPassLabel, sPassText });
            }
            else
            {
                lbPassLabel.Text = sPassText;
            }
        }

        public void SetButtonText(Button btPassButton, string sPassText)
        {
            if (btPassButton.InvokeRequired)
            {
                SetButtonTextCallback d = new SetButtonTextCallback(SetButtonText);
                this.Invoke(d, new object[] { btPassButton, sPassText });
            }
            else
            {
                btPassButton.Text = sPassText;

            }
        }

        public void SetButtonColor(Button btPassButton, Color cPassColor)
        {
            if (btPassButton.InvokeRequired)
            {
                SetButtonColorCallback d = new SetButtonColorCallback(SetButtonColor);
                this.Invoke(d, new object[] { btPassButton, cPassColor });
            }
            else
            {
                
                    btPassButton.BackColor = cPassColor;
                    btPassButton.FlatAppearance.MouseOverBackColor = cPassColor;


                
                
            }
        }

        public void SetButtonVisible(Button btPassButton, bool bVisible)
        {
            if (btPassButton.InvokeRequired)
            {
                SetButtonVisibleCallback d = new SetButtonVisibleCallback(SetButtonVisible);
                this.Invoke(d, new object[] { btPassButton, bVisible });
            }
            else
            {
                btPassButton.Visible = bVisible;
            }
        }

        public void SetTextBoxVisible(TextBox tbPassTextBox, bool bVisible)
        {
            if (tbPassTextBox.InvokeRequired)
            {
                SetTextBoxVisibleCallback d = new SetTextBoxVisibleCallback(SetTextBoxVisible);
                this.Invoke(d, new object[] { tbPassTextBox, bVisible });
            }
            else
            {
                tbPassTextBox.Visible = bVisible;
            }
        }

        public void SetLabelVisible(Label lbPassLabel, bool bVisible)
        {
            if (lbPassLabel.InvokeRequired)
            {
                SetLabelVisibleCallback d = new SetLabelVisibleCallback(SetLabelVisible);
                this.Invoke(d, new object[] { lbPassLabel, bVisible });
            }
            else
            {
                lbPassLabel.Visible = bVisible;
            }
        }
        /*####################### added SetCheckBoxVisible ###################*/
        public void SetCheckBoxVisible(CheckBox checkbox, bool bVisible)
        {
            if (checkbox.InvokeRequired)
            {
                SetCheckBoxVisibleCallback d = new SetCheckBoxVisibleCallback(SetCheckBoxVisible);
                this.Invoke(d, new object[] { checkbox, bVisible });
            }
            else
            {
                checkbox.Visible = bVisible;
            }
        }


        public void SetTextBoxText(TextBox tbPassTextBox, string sPassText)
        {
            if (tbPassTextBox.InvokeRequired)
            {
                SetTextBoxTextCallback d = new SetTextBoxTextCallback(SetTextBoxText);
                this.Invoke(d, new object[] { tbPassTextBox, sPassText });
            }
            else
            {
                tbPassTextBox.Text = sPassText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.button1.Text != "")
            {
                Display.SelectButton(1);

                
                //this.button1.BackColor = Color.Yellow;
                //this.button1.FlatAppearance.MouseOverBackColor = Color.Yellow;
            }

            /********set up down indexing*************/
            Form1.s = 1;
            Form1.i = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.Text != "")
            {
                Display.SelectButton(2);
            }
            Form1.s = 2;
            Form1.i = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.button3.Text != "")
            {
                Display.SelectButton(3);
            }
            Form1.s = 3;
            Form1.i = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.button4.Text != "")
            {
                Display.SelectButton(4);
            }
            Form1.s = 4;
            Form1.i = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.button5.Text != "")
            {
                Display.SelectButton(5);
            }
            Form1.s = 5;
            Form1.i = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.button6.Text != "")
            {
                Display.SelectButton(6);
            }
            Form1.s = 6;
            Form1.i = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.button7.Text != "")
            {
                Display.SelectButton(7);
            }
            Form1.s = 7;
            Form1.i = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.button8.Text != "")
            {
                Display.SelectButton(8);
            }
            Form1.s = 8;
            Form1.i = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.button9.Text != "")
            {
                Display.SelectButton(9);
            }
            Form1.s = 9;
            Form1.i = 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.button10.Text != "")
            {
                Display.SelectButton(10);
            }
            Form1.s = 10;
            Form1.i = 1;
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            if(Display.iButtonSelected > 0)
            {
                if (Display.iView == 1)
                {
                    if (Display.lColors[Display.iButtonSelected - 1] == Color.Orange)
                    {
                        TRAN_MGR.TRANs[Display.iButtonSelected - 1].Print();
                        //TRAN.CompletedTRANs[Display.iButtonSelected - 1].Print();
                    }
                }
                else if (Display.iView == 2)
                {
                    DB.PrintReceipt(Display.iButtonSelected - 1);
                }
                else if (Display.iView == 3)
                {
                    DB.PrintEodReport(Display.iButtonSelected - 1);
                }
                else if (Display.iView == 4)
                {
                    DB.PrintCashReport(Display.iButtonSelected - 1);
                }
            }
        }

        private void btPending_Click(object sender, EventArgs e)
        {
            Form1.s = 1;
            Form1.i = 1;

            Display.ChangeView(1);
            EnableDisableUpDown();
        }

        private void btCompleted_Click(object sender, EventArgs e)
        {
            Form1.s = 1;
            Form1.i = 1;

           new Transactions_View().Show();
           //new Test().Show();
          //  DB.UpdateCompletedTransView();
           /* Display.ChangeView(2);
            
            EnableDisableUpDown();*/

        }

        private void btEOD_Click(object sender, EventArgs e)
        {
            Form1.s = 1;
            Form1.i = 1;

            Display.ChangeView(3);
            EnableDisableUpDown();

            
        }

        private void btCash_Click(object sender, EventArgs e)
        {
            Form1.s = 1;
            Form1.i = 1;

            Display.ChangeView(4);
            EnableDisableUpDown();
            //Display.SelectButton(1);
            
        }

        private void btStatus_Click(object sender, EventArgs e)
        {
            
            Display.ChangeView(5);
            EnableDisableUpDown();
        }

        private void btConfigure_Click(object sender, EventArgs e)
        {
            //Display.ChangeView(6);
           // new Validate().btn_Validate_Click(null, null);
            //EnableDisableUpDown();
            
            new Validate().Show();
            //DisableAllUpDown();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Process p = null;
            try
            {
                string targetDir;
                targetDir = string.Format(@"D:\");
                p = new Process();
                p.StartInfo.WorkingDirectory = targetDir;
                p.StartInfo.FileName = "RunMe.bat";
                p.Start();
            }
            catch
            {
                Display.ShowMessageBox("Error", 3);
            }
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            Display.ShowMessageBox("Are you sure?\n\n", 10, 2);
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            if (Display.iView == 3)
            {
                Display.ShowMessageBox("Are you sure?\n\n", 10, 1);
            }
            else if (Display.iView == 4)
            {
                Display.ShowMessageBox("Are you sure?\n\n", 10, 1);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start("control.exe", "date/time");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("SAVE CONFIG");

            int iPic, iPump, iCash, iBills, iGrade1, iGrade2, iGrade3, iGrade4;
            string sHeader, sFooter;

            try
            {
                iPic = Convert.ToInt16(Display.screen1.tbPicNum.Text);
                if (iPic >= 1 && iPic <= 8)
                {
                    FileAccess.sSettings = FileAccess.sSettings.Replace("<PICNUM>" + Convert.ToString(CenCom.iPicCount), "<PICNUM>" + iPic);
                }
                iPump = Convert.ToInt16(Display.screen1.tbPumpNum.Text);
                if (iPump >= 1 && iPump <= 36)
                {
                    FileAccess.sSettings = FileAccess.sSettings.Replace("<PUMPNUM>" + Convert.ToString(CenCom.iPumpCount), "<PUMPNUM>" + iPump);
                }
                iCash = Convert.ToInt16(Display.screen1.tbMaxCash.Text);
                if (iCash >= 20 && iPump <= 200)
                {
                    FileAccess.sSettings = FileAccess.sSettings.Replace("<MAXCASH>" + Convert.ToString(CenCom.iMaxCash), "<MAXCASH>" + iCash);
                }
                iBills = Convert.ToInt16(Display.screen1.tbMaxBills.Text);
                if (iBills >= 10 && iBills <= 100)
                {
                    FileAccess.sSettings = FileAccess.sSettings.Replace("<MAXBILLS>" + Convert.ToString(CenCom.iMaxBills), "<MAXBILLS>" + iBills);
                }
            }
            catch
            {

                Debug.WriteLine("Invalid String to Convert");
            }

            FileAccess.sSettings = FileAccess.sSettings.Replace("<HEADER>" + Printer.sHeader, "<HEADER>" + Display.screen1.tbHeader.Text);
            FileAccess.sSettings = FileAccess.sSettings.Replace("<FOOTER>" + Printer.sFooter, "<FOOTER>" + Display.screen1.tbFooter.Text);

            Display.GetConfig();

            File.WriteAllText("settings.txt", FileAccess.sSettings);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Display.GetConfig();
        }

        private void btDateTime_Click(object sender, EventArgs e)
        {
            Process.Start("control.exe", "date/time");
        }

        private void btSave_Click_1(object sender, EventArgs e)
        {
            Debug.WriteLine("SAVE CONFIG");

            int iPic, iPump, iCash, iBills, iGrade1, iGrade2, iGrade3, iGrade4;
            string sHeader, sFooter;

            try
            {
                iPic = Convert.ToInt16(Display.screen1.tbPicNum.Text);
                if (iPic >= 1 && iPic <= 8)
                {
                    FileAccess.sSettings = FileAccess.sSettings.Replace("<PICNUM>" + Convert.ToString(CenCom.iPicCount), "<PICNUM>" + iPic);
                }
                iPump = Convert.ToInt16(Display.screen1.tbPumpNum.Text);
                if (iPump >= 1 && iPump <= 36)
                {
                    FileAccess.sSettings = FileAccess.sSettings.Replace("<PUMPNUM>" + Convert.ToString(CenCom.iPumpCount), "<PUMPNUM>" + iPump);
                }
                iCash = Convert.ToInt16(Display.screen1.tbMaxCash.Text);
                if (iCash >= 20 && iPump <= 200)
                {
                    FileAccess.sSettings = FileAccess.sSettings.Replace("<MAXCASH>" + Convert.ToString(CenCom.iMaxCash), "<MAXCASH>" + iCash);
                }
                iBills = Convert.ToInt16(Display.screen1.tbMaxBills.Text);
                if (iBills >= 10 && iBills <= 100)
                {
                    FileAccess.sSettings = FileAccess.sSettings.Replace("<MAXBILLS>" + Convert.ToString(CenCom.iMaxBills), "<MAXBILLS>" + iBills);
                }
            }
            catch
            {

                Debug.WriteLine("Invalid String to Convert");
            }

            FileAccess.sSettings = FileAccess.sSettings.Replace("<HEADER>" + Printer.sHeader, "<HEADER>" + Display.screen1.tbHeader.Text);
            FileAccess.sSettings = FileAccess.sSettings.Replace("<FOOTER>" + Printer.sFooter, "<FOOTER>" + Display.screen1.tbFooter.Text);

            Display.GetConfig();
        }

        private void btCancel_Click_1(object sender, EventArgs e)
        {
            Display.GetConfig();
        }

        private void btShutDown_Click(object sender, EventArgs e)
        {
            Display.ShowMessageBox("Are you sure?\n\n", 10, 3);
        }

        private void btPageUp_Click(object sender, EventArgs e)
        {
            int iButtonIndex;
            int iTranIndex;

            DB.iPage++;

            iButtonIndex = 0;
            for (iTranIndex = (10 * (DB.iPage - 1)); iTranIndex < (10 * DB.iPage); iTranIndex++)
            {
                if (iTranIndex < DB.lCompletedTrans.Count)
                {
                    iButtonIndex++;
                    Display.UpdateButtonText(iButtonIndex, "PUMP: " + DB.lCompletedTrans[iTranIndex].sPump + " @ " + DB.lCompletedTrans[iTranIndex].sShowTime + "\nPAID: $" + DB.lCompletedTrans[iTranIndex].sDeposit + "  CHANGE: $" + DB.lCompletedTrans[iTranIndex].sChange);
                }
            }

            if (DB.lCompletedTrans.Count <= 10 * DB.iPage)
            {
                Display.screen1.SetButtonVisible(Display.screen1.btPageUp, false);
            }

            if (DB.iPage == 2)
            {
                Display.screen1.SetButtonVisible(Display.screen1.btPageDown, true);
            }
        }

        private void btLoggingSFC_Click(object sender, EventArgs e)
        {
            if (CenCom.iLoggingSFC == 0)
            {
                CenCom.iLoggingSFC = 1;
                Display.screen1.SetButtonText(Display.screen1.btLoggingSFC, "LOGGING\nSFC - ON");
                Display.screen1.SetButtonColor(Display.screen1.btLoggingSFC, Color.Green);
            }
            else
            {
                CenCom.iLoggingSFC = 0;
                Display.screen1.SetButtonText(Display.screen1.btLoggingSFC, "LOGGING\nSFC - OFF");
                Display.screen1.SetButtonColor(Display.screen1.btLoggingSFC, Color.White);
            }
        }

        private void btPageDown_Click(object sender, EventArgs e)
        {
            int iButtonIndex;
            int iTranIndex;

            DB.iPage--;

            iButtonIndex = 0;
            for (iTranIndex = (10 * (DB.iPage - 1)); iTranIndex < (10 * DB.iPage); iTranIndex++)
            {
                if (iTranIndex < DB.lCompletedTrans.Count)
                {
                    iButtonIndex++;
                    Display.UpdateButtonText(iButtonIndex, "PUMP: " + DB.lCompletedTrans[iTranIndex].sPump + " @ " + DB.lCompletedTrans[iTranIndex].sShowTime + "\nPAID: $" + DB.lCompletedTrans[iTranIndex].sDeposit + "  CHANGE: $" + DB.lCompletedTrans[iTranIndex].sChange);
                }
            }

            if (DB.lCompletedTrans.Count > 10 * DB.iPage)
            {
                Display.screen1.SetButtonVisible(Display.screen1.btPageUp, true);
            }

            if (DB.iPage == 1)
            {
                Display.screen1.SetButtonVisible(Display.screen1.btPageDown, false);
            }
        }

        private void btLoggingPIC_Click(object sender, EventArgs e)
        {
            if (CenCom.iLoggingPIC == 0)
            {
                CenCom.iLoggingPIC = 1;
                Display.screen1.SetButtonText(Display.screen1.btLoggingPIC, "LOGGING\nPIC - ON");
                Display.screen1.SetButtonColor(Display.screen1.btLoggingPIC, Color.Green);
            }
            else
            {
                CenCom.iLoggingPIC = 0;
                Display.screen1.SetButtonText(Display.screen1.btLoggingPIC, "LOGGING\nPIC - OFF");
                Display.screen1.SetButtonColor(Display.screen1.btLoggingPIC, Color.White);
            }
        }

        private void btDownloadLogs_Click(object sender, EventArgs e)
        {
            FileAccess.CopyLogs();
            Display.ShowMessageBox("Copy Success", 3);
        }

        private void btDownloadReports_Click(object sender, EventArgs e)
        {
            FileAccess.CopyReports();
            Display.ShowMessageBox("Copy Success", 3);
        }

        private void btDownloadData_Click(object sender, EventArgs e)
        {
            FileAccess.CopyData();
            Display.ShowMessageBox("Copy Success", 3);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            if (Display.iButtonSelected > 0)
            {
                Display.ShowMessageBox("Are you sure?\n\n", 10, 4);
            }
        }

        public void Auto_check_CheckedChanged(object sender, EventArgs e)
        {
            //Auto_check.Checked = true;
            if (Auto_check.Checked )
            {

                Auto_check.Text = "set";
                Auto_check.ForeColor = Color.Green;



                new SetDataTime().Show(); // open the Set date time form




            }
            else {
                
                Auto_check.Text = "unset";
                Auto_check.ForeColor = Color.Red;

                DB.IsGenerateEOD_report = false;  // auto generate report off

               /* try {

                    string UpdatesConfig = File.ReadAllText("E:/config.txt");

                    string replaceStr = UpdatesConfig.Replace("ENABLE", "DISABLE");

                    File.WriteAllText("E:/config.txt", replaceStr);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("File can't write :" + ex);

                }*/

                String QueryStr;
                OleDbCommand cmd;


                try
                {

                    SQL_SERVER.Set_Sql_Server_Conn();
                    SQL_SERVER.Open_Sql_Server_Conn();
                    QueryStr = "UPDATE [Auto_EOD_Config] SET [AUTOEOD]='DISABLE' where [ID]=1";
                    SQL_SERVER.ExecuteNonQuery(QueryStr);
                  
                }
                catch (Exception ex)
                {

                    Debug.WriteLine("Not Update data from Auto_EOD_Config table :" + ex);
                }


              
                //UpdatesConfig.Replace(UpdatesConfig.Substring(UpdatesConfig.IndexOf("<AUTOEOD>") + 9, (UpdatesConfig.IndexOf("</AUTOEOD>") - UpdatesConfig.IndexOf("<AUTOEOD>") - 9)),""

                Display.ShowMessageBox("Off Automatic Day Close", 4);
                
            }
        }
        
        private void up_btn_Click(object sender, EventArgs e)
        {


                s -= i;

                if (s < 1)
                {
                    s = 1;
                    this.up_btn.Enabled = false;
                }

                if (s <= 10 && s > 0)
                {
                    Display.SelectButton(s);
                    this.down_btn.Enabled = true;
                    //MessageBox.Show(s + "");
                }
                else if (s == 1)
                {
                    //MessageBox.Show(s + "");
                    this.up_btn.Enabled = false;
                }
                else
                {

                    this.up_btn.Enabled = false;
                }
            
            

        }

        private void down_btn_Click(object sender, EventArgs e)
        {
           

            

                s += i;

                if (s > 10)
                {
                    s = 10;
                    this.down_btn.Enabled = false;
                }
                if (s <=10 && s > 0)
                {
                    Display.SelectButton(s);
                    this.up_btn.Enabled = true;
                    //MessageBox.Show(s + "");
                }
                else if (s == 10)
                {

                    //MessageBox.Show(s + "");
                    this.down_btn.Enabled = false;
                }
                else {
                    this.down_btn.Enabled = false;
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          Config_AutoEOD();
         // new TRAN(1, 2, 3, "1238765", "11").Authorize("1238765", 40);

           /* TRAN_MGR.Create(2,2,"12352563423","1234020");
            TRAN t1 = new TRAN(0, 2, 2, "12352563423", "123416");
           t1.Authorize("12352563423", 60);
           t1.SalesReport("1", "14", "40", "20");

           TRAN_MGR.Create(3, 3, "12352563423", "1234022");
           TRAN t2 = new TRAN(1, 3, 3, "12352563423", "1234022");
           t2.Authorize("12352563423", 60);
           t2.SalesReport("1", "14", "40", "20");*/


           
           //t1.Print();
           
           //t1.Print();
           //Display.UpdateButtonList();*/
            
            
          //new SetDataTime().Hide();
            //new SetDataTime().HideForm();
        }
       public static string sConfig, EODStatus="",HOURS="",MINUTES="",INTERVAL="";
        private void Config_AutoEOD()
        {
            //throw new NotImplementedException();

            //FileAccess.ReadSettings();
            String QueryStr;
            OleDbCommand cmd;
            OleDbDataReader dbr;


            try
            {


                QueryStr = "select *from Auto_EOD_Config";
                SQL_SERVER.Set_Sql_Server_Conn();
                SQL_SERVER.Open_Sql_Server_Conn();

                cmd = SQL_SERVER.Set_Sql_Server_Cmd(QueryStr);
                dbr = cmd.ExecuteReader();

                if (dbr.HasRows)
                {

                    while (dbr.Read())
                    {

                        EODStatus = dbr["AUTOEOD"].ToString();
                        HOURS = dbr["HOURS"].ToString();
                        MINUTES = dbr["MINUTES"].ToString();
                        INTERVAL = dbr["INTERVAL"].ToString();
                    }
                    cmd.Dispose();
                    dbr.Dispose();

                }
                else
                {

                    Debug.WriteLine("Don't read data from Auto_EOD_Config table");

                }
            }
            catch (Exception ex) {

                Debug.WriteLine("Don't read data from Auto_EOD_Config table :"+ex);
            }
        
            



           

           

           /* sConfig = File.ReadAllText("E:/config.txt");
            EODStatus = sConfig.Substring(sConfig.IndexOf("<AUTOEOD>") + 9, (sConfig.IndexOf("</AUTOEOD>") - sConfig.IndexOf("<AUTOEOD>") - 9));
            HOURS = sConfig.Substring(sConfig.IndexOf("<HOURS>") + 7, (sConfig.IndexOf("</HOURS>") - sConfig.IndexOf("<HOURS>") - 7));
            MINUTES = sConfig.Substring(sConfig.IndexOf("<MINUTES>") + 9, (sConfig.IndexOf("</MINUTES>") - sConfig.IndexOf("<MINUTES>") - 9));
            INTERVAL = sConfig.Substring(sConfig.IndexOf("<INTERVAL>") + 10, (sConfig.IndexOf("</INTERVAL>") - sConfig.IndexOf("<INTERVAL>") - 10)) ;*/



            // MessageBox.Show(EODStatus + "");


            if (EODStatus == "ENABLE" && HOURS!="" && MINUTES!="" && INTERVAL!="")
            {
                
               Auto_check.Checked = true;
               
                
                //this.Show();
            }






        }

    }

    static class ExtendForm
    {
        delegate void MyHideCallback(Form form);
        delegate void MyShowCallback(Form form);

        public static void HideThis(this Form form)
        {
            try
            {
                if (form.InvokeRequired)
                {
                    MyHideCallback d = new MyHideCallback(HideThis);
                    form.Invoke(d, new object[] { form });
                }
                else
                {
                    form.Hide();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public static void ShowThis(this Form form)
        {
            try
            {
                if (form.InvokeRequired)
                {
                    MyShowCallback d = new MyShowCallback(ShowThis);
                    form.Invoke(d, new object[] { form });
                }
                else
                {
                    //Form.ActiveForm.ActiveMdiChild.HideThis();
                    form.Show();
                    form.BringToFront();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
