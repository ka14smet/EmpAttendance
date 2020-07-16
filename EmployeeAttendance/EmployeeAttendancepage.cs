using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeAtendance
{
    public partial class EmployeeAttendancepage : Form
    {
        public EmployeeAttendancepage()
        {
            InitializeComponent();
        }

        private void EmployeeAttendancepage_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HRPRPDC;Initial Catalog=EmployeeAtttendance;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[AttendaceReport]
           ([EmployeeName]
           ,[Date and Time]
           ,[Status])
     VALUES
           ('"+ comboBox2.Text + "','"+dateTimePicker1.Text+"', '"+comboBox1.Text+"')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            Application.Exit();
            //reading

        }
    }
}
