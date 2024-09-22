using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_EntityFrameworkDbFirstProduct
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        Db2Project20Entities db = new Db2Project20Entities();

        //listelem fonk.
        void ProductList()
        {
            dataGridView1.DataSource = db.TblProduct.ToList();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TblProduct tblProduct = new TblProduct();               //yeni bir nesne üretimi
            tblProduct.ProductPrice = decimal.Parse(TxtProductPrice.Text);  
            tblProduct.ProductStock = int.Parse(TxtProductStock.Text);
            tblProduct.ProductName = TxtProductName.Text;
            tblProduct.CategoryId = int.Parse(CmbProductCategory.SelectedValue.ToString());
            db.TblProduct.Add(tblProduct);      //değerleri tabloya ekleme işlemi
            db.SaveChanges();                       //kaydetme
            ProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = db.TblProduct.Find(int.Parse(TxtProductId.Text));       //bir değişken üretip ona değer veriliyor.  değer şu=>product tablosunda arama yapıp id arıyor
            db.TblProduct.Remove(value);                                            //product tablosunda girilen id'ye ait veriyi sil  
            db.SaveChanges();                                                            //kaydetme
            ProductList();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = db.TblCategory.ToList();                               //bir değişken üretip ona değer veriliyor.  değer şu=>category tablosunu listeliyor.
            CmbProductCategory.DisplayMember = "CategoryName";                      //combox'daki verilerin isimleri (gözüken)
            CmbProductCategory.ValueMember = "CategoryId";                              //combox'daki verilerin id'leri
            CmbProductCategory.DataSource = values;                                         //combox'da göster
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var value = db.TblProduct.Find(int.Parse(TxtProductId.Text));           //bir değişken üretip ona değer veriliyor.  değer şu=>product tablosunda arama yapıp id arıyor
            value.ProductPrice = decimal.Parse(TxtProductPrice.Text);
            value.ProductStock = int.Parse(TxtProductStock.Text);
            value.ProductName = TxtProductName.Text;
            value.CategoryId = int.Parse(CmbProductCategory.SelectedValue.ToString());
            db.SaveChanges();
            ProductList();
        }

        private void BtnProductListWithCategory_Click(object sender, EventArgs e)
        {
            //burada bir birleştirme işlemi yapıldı
            //Product tablosundaki categoryid yerine Category tablosundaki categorid yazılması sağlandı.
            var values = db.TblProduct
                .Join(db.TblCategory,
                product => product.CategoryId,
                category => category.CategoryId,
                (product, category) => new
                {
                    //burada tablolara gelecek verileri eşleştirme yapılıyor
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    ProductPrice = product.ProductPrice,
                    ProductStock = product.ProductStock,
                    CategoryId = category.CategoryId,   
                    CategoryName = category.CategoryName,
                })
                .ToList();
            dataGridView1.DataSource = values;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = db.TblProduct.Where(x => x.ProductName == TxtProductName.Text).ToList();     //bir değişken üretip ona değer veriliyor. değer şu=> textbox'dan alınan değeri productName sütunu ile eşit olanları sorgulayıp listeler
            dataGridView1.DataSource = values;
        }
    }
}
