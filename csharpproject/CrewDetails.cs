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
    public partial class CrewDetails : Form
    {
        public CrewDetails()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-UGA2DH8\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from crewInformation", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView_crew.DataSource = dataTable;
            connection.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-UGA2DH8\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from crewInformation where CrewID='" + txt_crewid.Text + "'", connection);
            int check = sqlCommand.ExecuteNonQuery();
            connection.Close();
            if (check > 0)
            {
                MessageBox.Show("Crew Deleted successfully");
            }
        }
    }
}
