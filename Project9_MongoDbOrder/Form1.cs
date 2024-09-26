using Project9_MongoDbOrder.Entities;
using Project9_MongoDbOrder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9_MongoDbOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OrderOperation orderOperation = new OrderOperation();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                City = txtSehir.Text,
                CustomerName = txtMusteriAdi.Text,
                District = txtIlce.Text,
                TotalPrice = decimal.Parse(txtToplamFiyat.Text),
            };
            orderOperation.AddOrder(order);
            MessageBox.Show("Ekleme İşlemi Yapıldı.");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<Order> orders = orderOperation.GetAllOrders();
            dataGridView1.DataSource = orders;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string orderId = txtSiparisId.Text;
            orderOperation.DeleteOrder(orderId);
            MessageBox.Show("Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string id = txtSiparisId.Text;
            var updateOrder = new Order
            {
                City = txtSehir.Text,
                CustomerName = txtMusteriAdi.Text,
                District = txtIlce.Text,
                OrderId = id,
                TotalPrice = decimal.Parse(txtToplamFiyat.Text),
            };
            orderOperation.UpdateOrder(updateOrder);
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            string id =txtSiparisId.Text;
            Order orders = orderOperation.GetOrderById(id);
            dataGridView1.DataSource = new List<Order> { orders };
        }
    }
}
