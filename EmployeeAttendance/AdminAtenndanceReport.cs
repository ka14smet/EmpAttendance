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
    public partial class AdminAtenndanceReport : Form
    {
        public AdminAtenndanceReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HRPRPDC;Initial Catalog=EmployeeAtttendance;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select*from[dbo].[AttendaceReport]",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["EmployeeName"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Date and Time"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Employee Status"].ToString();

           }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HRPRPDC;Initial Catalog=EmployeeAtttendance;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select*from[dbo].[AttendaceReport]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void AdminAtenndanceReport_Load(object sender, EventArgs e)
        {
      
        }
    }
}
