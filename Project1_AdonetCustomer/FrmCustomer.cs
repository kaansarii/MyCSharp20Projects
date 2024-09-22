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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Server=Kaan\\SQLEXPRESS; initial catalog=DbCustomer; integrated security=true");

        private void btnList_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            //SqlCommand command = new SqlCommand("SELECT * FROM TblCustomer", sqlConnection);  YA DA 
            SqlCommand command = new SqlCommand("SELECT CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CityName FROM TblCustomer INNER JOIN TblCity ON TblCity.CityId = TblCustomer.CustomerCity",sqlConnection); 
            SqlDataAdapter adapter = new SqlDataAdapter(command);   //verileri hafızaya alır,  köprü vazifesi görür
            DataTable dataTable = new DataTable();                  //bir tane tablo oluştur
            adapter.Fill(dataTable);                                //datable içine adapterden gelen veriyi  doldurma işlemi yapılıyor ,   dataGridView'e atmadan önce
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void BtnProsedur_Click(object sender, EventArgs e)
        {
            //veritabanında yazılan prosedür ile daha kolay yapılır
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("EXECUTE CustomerListWithCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);   //verileri hafızaya alır,  köprü vazifesi görür
            DataTable dataTable = new DataTable();                  //bir tane tablo oluştur
            adapter.Fill(dataTable);                                //datable içine adapterden gelen veriyi  doldurma işlemi yapılıyor ,   dataGridView'e atmadan önce
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }

        //combobox'a şehirleri getirme
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TblCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);   //verileri hafızaya alır,  köprü vazifesi görür
            DataTable dataTable = new DataTable();                  //bir tane tablo oluştur
            adapter.Fill(dataTable);                                //datable içine adapterden gelen veriyi  doldurma işlemi yapılıyor ,   dataGridView'e atmadan önce
            CmbCustomerCity.ValueMember = "CityId";  
            CmbCustomerCity.DisplayMember = "CityName";
            CmbCustomerCity.DataSource= dataTable;
           
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO TblCustomer (CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CustomerCity) VALUES (@customerName,@customerSurname,@customerBalance,@customerStatus,@customerCity)", sqlConnection);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@customerBalance",TxtCustomerBalance.Text);
            command.Parameters.AddWithValue("@customerCity", CmbCustomerCity.SelectedValue);

            if(RdbActive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", true);
            }
            if(RdbPassive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", false);
            }
            command.ExecuteNonQuery();  //save gibi düşünebiliriz
            sqlConnection.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM TblCustomer WHERE CustomerId=@customerId", sqlConnection);
            command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Silme İşlemi Başarılı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("UPDATE TblCustomer SET CustomerName=@customerName,CustomerSurname=@customerSurname,CustomerBalance=@customerBalance,CustomerStatus=@customerStatus,CustomerCity=@customerCity WHERE CustomerId=@customerId", sqlConnection);
            command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@customerBalance", TxtCustomerBalance.Text);
            command.Parameters.AddWithValue("@customerCity", CmbCustomerCity.SelectedValue);

            if (RdbActive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", true);
            }
            if (RdbPassive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", false);
            }
            command.ExecuteNonQuery();  //save gibi düşünebiliriz
            sqlConnection.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TblCUstomer WHERE CustomerName=@customerName", sqlConnection);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);   //verileri hafızaya alır,  köprü vazifesi görür
            DataTable dataTable = new DataTable();                  //bir tane tablo oluştur
            adapter.Fill(dataTable);                                //datable içine adapterden gelen veriyi  doldurma işlemi yapılıyor ,   dataGridView'e atmadan önce
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
            MessageBox.Show("Arama İşlemi Başarılı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
