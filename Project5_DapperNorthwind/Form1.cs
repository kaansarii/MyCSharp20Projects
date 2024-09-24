using Dapper;
using Project5_DapperNorthwind.Dtos.CategoryDtos;
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

namespace Project5_DapperNorthwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=Kaan\\SQLEXPRESS; initial catalog=Db5Project20; integrated security=true");

        private async void btnCategoryList_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Categories";
            var values = await connection.QueryAsync<ResultCategoryDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Categories (CategoryName, Description) VALUES (@p1, @p2)";
            var parameteres = new DynamicParameters();
            parameteres.Add("@p1",txtCategoryName.Text);
            parameteres.Add("@p2", txtCategoryDescp.Text);
            await connection.ExecuteAsync(query,parameteres); 
        }

        private async void btnCategoryRemove_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Categories WHERE CategoryId = @categoryId";
            var parameteres = new DynamicParameters();
            parameteres.Add("@categoryId",txtCategoryId.Text);
            await connection.ExecuteAsync(query,parameteres); 
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Categories SET CategoryName=@categoryName, Description=@description WHERE CategoryId=@categoryId";
            var parameteres = new DynamicParameters();
            parameteres.Add("@categoryName", txtCategoryName.Text);
            parameteres.Add("@description", txtCategoryDescp.Text);
            parameteres.Add("@categoryId", txtCategoryId.Text);
            await connection.ExecuteAsync(query,parameteres);

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //kategori sayısı
            string query = "SELECT COUNT(*) FROM Categories";
            var categoryCount = await connection.ExecuteScalarAsync<int>(query);
            label5.Text = "Toplam Kategori Sayısı: " + categoryCount;


            //ürün sayısı
            string query2 = "SELECT COUNT(*) FROM Products";
            var productCount = await connection.ExecuteScalarAsync<int>(query2);
            label6.Text = "Toplam ürün Sayısı: "+productCount;


            //ortalama ürün stok sayısı
            string query3 = "SELECT AVG(UnitsInStock) FROM Products";
            var avgProductStock = await connection.ExecuteScalarAsync<int>(query3);
            label7.Text = "Ortalama ürün Sayısı: " + avgProductStock;


            //deniz ürünleri toplam fiyatı
            string query4 = "SELECT SUM(UnitPrice) FROM Products WHERE CategoryId=(SELECT CategoryId FROM Categories WHERE CategoryName='SeaFood')";
            var totalSeaFoodPrice = await connection.ExecuteScalarAsync<decimal>(query4);
            label8.Text = "Deniz Ürünleri Toplam Fiyatı: "+totalSeaFoodPrice;


        }
    }
}
