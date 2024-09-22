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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        Db2Project20Entities db = new Db2Project20Entities();


        void CategoryList()
        {
           
            dataGridView1.DataSource = db.TblCategory.ToList();  //dataGrid'e tabloyu listele
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CategoryList();
            MessageBox.Show("Listeleme İşlemi Yapıldı", "LİSTELENDİ", MessageBoxButtons.OK);

        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            TblCategory tblCategory = new TblCategory();              //yeni liste oluştur
            tblCategory.CategoryName =TxtCategoryName.Text;             //name text'ine yazılan metine tabloda CategoryName'e denk gelsin
            db.TblCategory.Add(tblCategory);                                //tabloya ekle
            db.SaveChanges();                                                   //kayıt
            MessageBox.Show("Ekleme İşlemi Yapıldı","EKLENDİ",MessageBoxButtons.OK);
            CategoryList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtCategoryId.Text);       //id'yi bir değişkene ata
            var value = db.TblCategory.Find(id);                    //tabloda id'yi bul onu değişkene ata
            db.TblCategory.Remove(value);                               //tablodan o id'ye sahip veriyi kaldır 
            db.SaveChanges();                                               //kayıt
            MessageBox.Show("Silme İşlemi Yapıldı", "SİLİNDİ", MessageBoxButtons.OK);
            CategoryList();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtCategoryId.Text);     //id'yi bir değişkene ata
            var value = db.TblCategory.Find(id);                //tabloda id'yi bul onu değişkene ata
            value.CategoryName=TxtCategoryName.Text;                //name text'ine yazılan metine tabloda CategoryName'e denk gelsin
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Yapıldı", "GÜNCELLENDİ", MessageBoxButtons.OK);
            CategoryList();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           var values = db.TblCategory.Where(x => x.CategoryName == TxtCategoryName.Text).ToList();         //bir değişken üretip ona değer veriliyor. değer şu=> textbox'dan alınan değeri categoryName sütunu ile eşit olanları sorgulayıp listeler
            dataGridView1.DataSource = values;
        }

        
    }
}
