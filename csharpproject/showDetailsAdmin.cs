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

namespace csharpproject
{
    public partial class showDetailsAdmin : Form
    {
        public showDetailsAdmin()
        {
            InitializeComponent();
        }

        private void btn_shw_details_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-UGA2DH8\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from passengersDetails", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            showDetailsGrid.DataSource = dataTable;
            connection.Close();
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-UGA2DH8\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from passengersDetails where PassportID='" + txt_passportid.Text + "'", connection);
            int check = sqlCommand.ExecuteNonQuery();
            connection.Close();
            if (check > 0)
            {
                MessageBox.Show("Passenger Deleted successfully");
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            
        }

        private void ticketCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TicketCategory().Show();
            this.Hide();
        }

        private void provideScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminScheduleProvide().Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminLogin().Show();
            this.Hide();
        }
    }
}
