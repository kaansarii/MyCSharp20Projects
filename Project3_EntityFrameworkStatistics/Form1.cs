using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_EntityFrameworkStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Db3Project20Entities db = new Db3Project20Entities();
        private void Form1_Load(object sender, EventArgs e)
        {
            //toplam kategori sayısı
            int categoryCount = db.TblCategory.Count();
            LblCategoryCount.Text = categoryCount.ToString();

            //toplam ürün sayısı
            int productCount = db.TblProduct.Count();
            LblProductCount.Text = productCount.ToString();

            //toplam müşteri sayısı
            int customerCount = db.TblCustomer.Count();
            LblCustomerCount.Text = customerCount.ToString();

            //toplam sipariş sayısı
            int orderCount = db.TblOrder.Count();
            LblOrderCount.Text = orderCount.ToString();

            //toplam stok sayısı
            //sum komutu buluduğu sütunu toplar
            var totalProductStockCount = db.TblProduct.Sum(x => x.ProductStock);
            LblTotalProductStockCount.Text = totalProductStockCount.ToString();

            //ortalama ürün fiyatı
            //average komutu bulunduğu sütunun ortalamasını alır
            var avarageProductPrice = db.TblProduct.Average(x => x.ProductPrice);
            LblProductAvaragePrice.Text = avarageProductPrice.ToString();


            //toplam meyve sayısı
            //where şartı ile product tablosuna ulaşıp o tablodaki categoryid=1 olanlar seçiliyor sum ile de toplamları alınıyor.
            var totalProductCountByCategoryIsFruit = db.TblProduct.Where(x => x.CategoryId == 1).Sum(y => y.ProductStock);
            LblProductCountByCategoryIsFruit.Text = totalProductCountByCategoryIsFruit.ToString();


            //gazoz isimli ürünün toplam işlem hacmini bulma
            //bir değişken tanımlayıp o değişkene atama, atanan değer şu=> product tablosuna gel ismi gazoz olanı bul, gaozun stoğunu seç
            var totalPriceByProductNameIsGazozGetStock = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(x => x.ProductStock).FirstOrDefault();
            //bir değişken tanımlayıp o değişkene atama, atanan değer şu=> product tablosuna gel ismi gazoz olanı bul, gaozun ücretini seç
            var totalPriceByProductNameIsGazozGetUnitPrice = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(x => x.ProductPrice).FirstOrDefault();
            //ikisini çarp
            var totalPriceByProductNameIsGazoz = totalPriceByProductNameIsGazozGetStock * totalPriceByProductNameIsGazozGetUnitPrice;
            LblTotalPriceByProductNameIsGazoz.Text = totalPriceByProductNameIsGazoz.ToString();


            //stok sayısı 100'den küçükler
            //bir değişken tanımlayıp o değişkene atama, atana değer şu product tablosuna gel stoğu 110'ün altındakiler kaç adetse toplamını ver
            var productCountByStockCountSmallerThen100 = db.TblProduct.Where(x => x.ProductStock <100 ).Count();
            LblStockSmallerThen100.Text = productCountByStockCountSmallerThen100.ToString();



            //kategorisi sebze ve durumu aktif(true) olan ürün stok toplamı
            //bir değişken tanımlayıp o değişkene atama,
            //atanan değer şu product tablosuna gel oradan categoryide çek, ama bize isim lazım olduğu için == kullanıp isme ulaşılmalı, category tablosunda sorgu yazıp categoryname'i sebze olanı alıp id'sini seç.
            //ikinci şart olan drumunu kontrol et ve toplamını ver
            var productStockCountByCategoryNameIsSebzeAndStatusIsTrue = db.TblProduct.Where(x => x.CategoryId==(db.TblCategory.Where(t => t.CategoryName == "Sebze").Select(w => w.CategoryId).FirstOrDefault())  && x.ProductStatus == true ).Sum(y => y.ProductStock);
            LblProductByCategorySebzeAndStatusTrue.Text = productStockCountByCategoryNameIsSebzeAndStatusIsTrue.ToString();



            //Türkiye'den yapılan siparişler
            //SQL ile
            var orderCountFromTurkiye = db.Database.SqlQuery<int>("SELECT COUNT(*) FROM TblOrder WHERE CustomerId IN (SELECT CustomerId FROM TblCustomer WHERE CustomerCountry='Türkiye')").FirstOrDefault();
            LblOrderCountFromTurkiyeBySQL.Text = orderCountFromTurkiye.ToString();



            //Türkiye'den yapılan siparişler
            //Entity Framework ile
            var turkishCustomerIds=db.TblCustomer.Where(x => x.CustomerCountry == "Türkiye")
                                                 .Select(y => y.CustomerId)
                                                 .ToList();
            var orderCountFromTurkiyeWithEF = db.TblOrder.Count(z => turkishCustomerIds.Contains(z.CustomerId.Value));
            LblOrderCountFromTurkiyeByEF.Text = orderCountFromTurkiyeWithEF.ToString();



            
            //Siparişler içerisinde kategorisi meyve olan ürünleri toplam satış fiyatı
            //SQL ile
            var orderTotalPriceByCategoryIsMeyveBySQL = db.Database.SqlQuery<decimal>("SELECT SUM(o.TotalPrice) FROM TblOrder o JOIN TblProduct p ON o.ProductId=p.ProductId JOIN TblCategory c ON p.CategoryId=c.CategoryId WHERE c.CategoryName = 'Meyve'").FirstOrDefault();
            LblOrderTotalPriceByCategoryIsMeyveBySQL.Text = orderTotalPriceByCategoryIsMeyveBySQL.ToString();



            //Siparişler içerisinde kategorisi meyve olan ürünleri toplam satış fiyatı
            //Entity Framework ile
            var orderTotalPriceByCategoryIsMeyveByEF =  (from o in db.TblOrder
                                                         join p in db.TblProduct on o.ProductId equals p.ProductId
                                                         join c in db.TblCategory on p.CategoryId equals c.CategoryId
                                                         where c.CategoryName == "Meyve"
                                                         select o.TotalPrice).Sum();
            labelLblOrderTotalPriceByCategoryIsMeyveByEF.Text = orderTotalPriceByCategoryIsMeyveByEF.ToString();






            //en son eklenen ürünün adı
            var endAddProduct = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.ProductName).FirstOrDefault();
            LblEndAddProduct.Text = endAddProduct.ToString();




            //en son eklenen ürünün Kategorisi
            var endAddProductCategoryId = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.CategoryId).FirstOrDefault();
            var endAddProductCategoryName = db.TblCategory.Where(x => x.CategoryId == endAddProductCategoryId).Select(y => y.CategoryName).FirstOrDefault();
            LblEndAddProductCategory.Text = endAddProductCategoryName.ToString();




            //aktif ürün sayısı
            var activeProduct = db.TblProduct.Where(x => x.ProductStatus == true).Count();
            LblActiveProduct.Text = activeProduct.ToString();


            //toplam kola kazanç tutarı
            var totalkola = db.TblProduct.Where(x =>x.ProductName =="Kola").Select(y => y.ProductStock).FirstOrDefault();
            var kolaMale = db.TblProduct.Where(x => x.ProductName == "Kola").Select(y => y.ProductPrice).FirstOrDefault();
            var totalKolaSale = totalkola * kolaMale;
            LblTotalKolaSale.Text = totalKolaSale.ToString();



            //son siparişi veren müşteri adı-soyadı
            //LblLastOrderCustomerName
            var lastOrderCustomerId = db.TblOrder.OrderByDescending(x => x.OrdeId).Select(y => y.CustomerId).FirstOrDefault();
            var lastOrderCustomer = db.TblCustomer.Where(x => x.CustomerId == lastOrderCustomerId).Select( y => y.CustomerName).FirstOrDefault();
            LblLastOrderCustomerName.Text = lastOrderCustomer.ToString();


            //farklı ülke sayısı
            var countryDifferentCount = db.TblCustomer.Select(x => x.CustomerCountry).Distinct().Count();
            LblCountryDifferent.Text = countryDifferentCount.ToString();



        }


    }
}
