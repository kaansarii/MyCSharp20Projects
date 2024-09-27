using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_PostgreSQLToDolistApp
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localHost; port=5432; Database=DbProject10ToDoApp;userID=postgres;Password=123";


        void CategoryList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM categories order by CategoryId";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Categories ( CategoryName ) values (@categoryName)";
            using(var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@categoryName",txtBaslik.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori Eklendi");
                CategoryList();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIslemId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "delete from Categories where CategoryId=@categoryId";
            using(var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@categoryId", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori silindi");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIslemId.Text);
            string categoryName = txtBaslik.Text;

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update Categories Set CategoryName=@categoryName where CategoryId=@categoryId";
            using(var command = new NpgsqlCommand(query,connection))
            {
                command.Parameters.AddWithValue("@categoryId", id);
                command.Parameters.AddWithValue("@categoryName", categoryName);
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori güncellendi");
                CategoryList();
            }
            connection.Close();
        }

        private void btnIdGetir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIslemId.Text);
            using(var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "Select * From Categories Where CategoryId=@categoryId";
                using(var command = new NpgsqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@categoryId", id);
                    using(var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
