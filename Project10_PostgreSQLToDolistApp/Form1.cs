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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localHost; port=5432; Database=DbProject10ToDoApp;userID=postgres;Password=123";

        void ToDoList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM todolists order by ToDoListId";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        void CategoryList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Categories";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "CategoryId";
            cmbKategori.DataSource = dataTable;
            connection.Close();
        }
        private void btnKategoriListesi_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            ToDoList(); 
        }

        private void btnTumListe_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "SELECT todolistid, title, description, status, priority, categoryname from todolists  inner join categories on todolists.categoryid=categories.categoryid";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToDoList();
            CategoryList();
        }


        private void btnOlustur_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(cmbKategori.SelectedValue.ToString());
            string description = txtAciklama.Text;
            string priority = txtOncelik.Text;
            string title  = txtBaslik.Text;
            bool status = false;

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into todolists ( title, description, status, priority, categoryid) values (@title, @description,B'1',  @priority, @categoryid)";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                //command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@categoryid", categoryId);

                command.ExecuteNonQuery();
                MessageBox.Show("Eklendi");
                ToDoList();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIslemId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "delete from ToDoLists where ToDoListId=@todolistId";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@todolistId", id);
                command.ExecuteNonQuery();
                MessageBox.Show("silindi");
            }
            ToDoList();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtIslemId.Text);
            int categoryId = int.Parse(cmbKategori.SelectedValue.ToString());
            string description = txtAciklama.Text;
            string priority = txtOncelik.Text;
            string title = txtBaslik.Text;

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update ToDoLists Set title =@title , description = @description, priority = @priority where ToDoListId=@todolistId";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@todolistId", id);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                //command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@categoryid", categoryId);
                
                command.ExecuteNonQuery();
                MessageBox.Show("güncellendi");
                CategoryList();
            }
            connection.Close();
            ToDoList();

        }

        private void btnTamamlananlar_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM todolists where status='1'";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void btnDevamEdenler_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM todolists where status='0'";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
    }
}
 