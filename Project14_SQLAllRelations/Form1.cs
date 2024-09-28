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

namespace Project14_SQLAllRelations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=Kaan\\SQLEXPRESS; initial catalog=Db14Project20; integrated security=true");

        private void Form1_Load(object sender, EventArgs e)
        {

            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Teams", sqlConnection);
            SqlCommand command2 = new SqlCommand("SELECT * FROM Sponsors", sqlConnection);
            SqlCommand command3 = new SqlCommand("SELECT * FROM Players", sqlConnection);
            SqlCommand command4 = new SqlCommand("SELECT * FROM TeamSponsors", sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);   
            DataTable dataTable = new DataTable();                  
            adapter.Fill(dataTable);                                
            dataGridView1.DataSource = dataTable;
            

            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;
            


            SqlDataAdapter adapter3 = new SqlDataAdapter(command3);
            DataTable dataTable3 = new DataTable();
            adapter3.Fill(dataTable3);
            dataGridView3.DataSource = dataTable3;
            


            SqlDataAdapter adapter4 = new SqlDataAdapter(command4);
            DataTable dataTable4 = new DataTable();
            adapter4.Fill(dataTable4);
            dataGridView4.DataSource = dataTable4;
            sqlConnection.Close();
        }
    }
}
