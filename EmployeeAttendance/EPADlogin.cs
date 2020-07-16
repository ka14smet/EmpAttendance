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
    public partial class EPADlogin : Form
    {
        public EPADlogin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( textBox1.Text=="Admin" && textBox2.Text=="Admin@123")
            {
                this.Hide();
                AdminAtenndanceReport aar = new AdminAtenndanceReport();
                aar.Show();
            }
            else
            {
                MessageBox.Show("invalid Username and Password...!", "error" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox3.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HRPRPDC;Initial Catalog=EmployeeAtttendance;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
                  FROM[dbo].[Employeelogin] where EmployeeUserName = '"+textBox3.Text+"' and EmployeePassword = '"+textBox4.Text+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count==1)
            {
                this.Hide();
                EmployeeAttendancepage eap = new EmployeeAttendancepage();
                eap.Show();
            }
            else
            {
                MessageBox.Show("invalid username and password...!","Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                button3_Click(sender, e);
            }


        }

        private void EPADlogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
