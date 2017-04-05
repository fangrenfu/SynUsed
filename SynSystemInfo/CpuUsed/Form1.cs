using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Data;
using System.Data.SqlClient;
namespace CpuUsed
{
    public partial class Form1 : Form
    {
        SystemInfo systeminfo = new SystemInfo();
        SqlConnection con = new SqlConnection();
        SqlCommand command = new SqlCommand();
        bool btick = false;
      
        public Form1()
        {
            InitializeComponent();
            GetIP Obj = new GetIP();
            tbIp.Text = Obj.getLocalIP();
            con.ConnectionString = "server=172.18.0.41;database=logdb;uid=sa;pwd=comefirstfangrenfu@0";
            command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            con.Open();
            command.CommandText = "insert into server(ip) select @serverip where not exists (select * from server where ip=@serverip)";
            command.Parameters.Add("@serverip", SqlDbType.VarChar);
            command.Parameters["@serverip"].Value = tbIp.Text;
            command.ExecuteNonQuery();
            command.CommandText = "update server set cpu=@cpu,memory=@memory,date=getdate() where ip=@serverip";
            command.Parameters.Clear();
            command.Parameters.Add("@cpu", SqlDbType.Decimal);
            command.Parameters.Add("@memory", SqlDbType.Decimal);
            command.Parameters.Add("@serverip", SqlDbType.VarChar);
            con.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            btick=!btick;
            timer.Enabled = btick;
            button1.Text=btick==false?"开始":"结束";

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tbCPU.Text = (Math.Round(systeminfo.CpuLoad,1)).ToString();
            tbMemory.Text = (Math.Round((100-100.0*systeminfo.MemoryAvailable / systeminfo.PhysicalMemory),1)).ToString();
            con.Open();
            command.Parameters["@cpu"].Value = tbCPU.Text;
            command.Parameters["@memory"].Value = tbMemory.Text;
            command.Parameters["@serverip"].Value = tbIp.Text;
            command.ExecuteNonQuery();
            con.Close();
        }

        
    }
   
}
