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
    public partial class SetDataTime : Form
    {
        public SetDataTime()
        {
            InitializeComponent();

            hours_txt_box.MaxLength = 2;
            minutes_txt_box.MaxLength = 2;

            

            
        }

        public void HideForm(){
            this.Hide();
        }
        
       Form1 form1 = new Form1();
        
       public static string interval = "";
       public static string hours = "";
       public static string minutes = "";
       public static bool IsselectedAm = false;
       public static bool IsselectedPm = false;
       public static string UpdatesConfig;
       public static string replaceStr="";

        private void Ok_btn_Click(object sender, EventArgs e)
        {

             hours = hours_txt_box.Text.ToString().Trim();
             minutes = minutes_txt_box.Text.ToString().Trim();

             if ((hours != null && hours != "") && (minutes != null && minutes != "") && (IsselectedAm || IsselectedPm))
             {

                 if (hours.Length == 1) {

                     hours = "0" + hours;
                 }

                 if (minutes.Length == 1) {

                     minutes = "0" + minutes;
                 }


               /*  try
                 {

                     UpdatesConfig = File.ReadAllText("E:/config.txt");

                     UpdatesConfig = UpdatesConfig.Replace("DISABLE", "ENABLE");
                     UpdatesConfig = UpdatesConfig.Replace((UpdatesConfig.Substring(UpdatesConfig.IndexOf("<HOURS>") + 7, (UpdatesConfig.IndexOf("</HOURS>") - UpdatesConfig.IndexOf("<HOURS>") - 7))), hours + "");
                     UpdatesConfig = UpdatesConfig.Replace((UpdatesConfig.Substring(UpdatesConfig.IndexOf("<MINUTES>") + 9, (UpdatesConfig.IndexOf("</MINUTES>") - UpdatesConfig.IndexOf("<MINUTES>") - 9))), minutes + "");
                     UpdatesConfig = UpdatesConfig.Replace((UpdatesConfig.Substring(UpdatesConfig.IndexOf("<INTERVAL>") + 10, (UpdatesConfig.IndexOf("</INTERVAL>") - UpdatesConfig.IndexOf("<INTERVAL>") - 10))), interval + "");

                     File.WriteAllText("E:/config.txt", UpdatesConfig);
                 }
                 catch (Exception ex) {
                     Debug.WriteLine("File can't write (Not set time in file) :" + ex);

                 }*/

                 String QueryStr;
                 OleDbCommand cmd;


                 try
                 {

                     SQL_SERVER.Set_Sql_Server_Conn();
                     SQL_SERVER.Open_Sql_Server_Conn();
                     //QueryStr = @"UPDATE Auto_EOD_Config SET AUTOEOD='ENABLE', HOURS='" + hours + "', MINUTES='" + minutes + "', INTERVAL='"+interval+"' WHERE ID=1";
                     QueryStr = @"UPDATE [Auto_EOD_Config] Set [AUTOEOD] = 'ENABLE', [HOURS]='"+hours+"', [MINUTES]='"+minutes+"', [INTERVAL]='"+interval+"' WHERE [ID]=1;";
                     SQL_SERVER.ExecuteNonQuery(QueryStr);
                    /* cmd = SQL_SERVER.Set_Sql_Server_Cmd(QueryStr);
                     cmd.Parameters.AddWithValue("@enable","ENABLE");
                     cmd.Parameters.AddWithValue("@hours",hours.ToString());
                     cmd.Parameters.AddWithValue("@minutes", minutes.ToString());
                     cmd.Parameters.AddWithValue("interval", interval.ToString());
                     cmd.Parameters.AddWithValue("@id",1);

                     cmd.ExecuteNonQuery();*/


                 }
                 catch (Exception ex)
                 {

                     Debug.WriteLine("Not Update data from Auto_EOD_Config table :" + ex);
                 }
               


                 

                 this.Hide();
                 //DB.IsGenerateEOD_report = false;
                 //DB.IsGeneratePIC_Cash_report = false;
               //  MessageBox.Show(hours+":"+minutes+":01"+" "+interval+" "+DateTime.Now.ToString("hh:mm:ss tt"));

                 Display.ShowMessageBox("your time seted " + hours + ":" + minutes + " " + interval, 5);
             }
             else {

                 Display.ShowMessageBox("Please set all fields",5);
             }

           // this.Hide();
            
            //form1.Auto_check.Checked = false;
            //form1.Auto_check.CheckedChanged += new EventHandler(CheckBox_Checked);

          //  form1.Auto_check_CheckedChanged(null,null);
            
            //CheckBox check = (CheckBox)this.form1.Controls["Auto_check"];

        }

        private void am_btn_Click(object sender, EventArgs e)
        {
            interval = am_btn.Text.ToString();
            am_btn.BackColor = Color.Yellow;
            pm_btn.BackColor = Color.White;
            IsselectedAm = true;
            IsselectedPm = false;
        }

        private void pm_btn_Click(object sender, EventArgs e)
        {
            interval = pm_btn.Text.ToString();
            pm_btn.BackColor = Color.Yellow;
            am_btn.BackColor = Color.White;
            IsselectedPm = true;
            IsselectedAm = false;


        }

        private void hours_txt_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetDataTime_Load(object sender, EventArgs e)
        {
          // this.Hide();
        }

      

       

       
        
    }
}
