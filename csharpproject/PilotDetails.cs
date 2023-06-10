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
    public partial class PilotDetails : Form
    {
        public PilotDetails()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-UGA2DH8\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from pilotInformation", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView_pilot.DataSource = dataTable;
            connection.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-UGA2DH8\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from pilotInformation where ID='" + txt_pilotid.Text + "'", connection);
            int check = sqlCommand.ExecuteNonQuery();
            connection.Close();
            if (check > 0)
            {
                MessageBox.Show("Pilot Deleted successfully");
            }
        }
    }
}
