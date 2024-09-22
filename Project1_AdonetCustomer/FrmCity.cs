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

namespace Project1_AdonetCustomer
{
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Server=Kaan\\SQLEXPRESS; initial catalog=DbCustomer; integrated security=true");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TblCity",sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);   //verileri hafızaya alır,  köprü vazifesi görür
            DataTable dataTable = new DataTable();                  //bir tane tablo oluştur
            adapter.Fill(dataTable);                                //datable içine adapterden gelen veriyi  doldurma işlemi yapılıyor ,   dataGridView'e atmadan önce
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO TblCity (CityName, CityCountry) VALUES (@CityName,@CityCountry)", sqlConnection);
            command.Parameters.AddWithValue("@CityName", txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry",txtCityCountry.Text);
            command.ExecuteNonQuery();  //save gibi düşünebiliriz
            sqlConnection.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı", "UYARI",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM TblCity WHERE CityId=@cityId",sqlConnection);
            command.Parameters.AddWithValue("@cityId",txtCityId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Silme İşlemi Başarılı","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("UPDATE TblCity SET CityName=@cityName,CityCountry=@cityCountry WHERE CityId=@cityId", sqlConnection);
            command.Parameters.AddWithValue("@cityId", txtCityId.Text);
            command.Parameters.AddWithValue("@cityName",txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry",txtCityCountry.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TblCity WHERE CityName=@cityName", sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);   //verileri hafızaya alır,  köprü vazifesi görür
            DataTable dataTable = new DataTable();                  //bir tane tablo oluştur
            adapter.Fill(dataTable);                                //datable içine adapterden gelen veriyi  doldurma işlemi yapılıyor ,   dataGridView'e atmadan önce
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
            MessageBox.Show("Arama İşlemi Başarılı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
