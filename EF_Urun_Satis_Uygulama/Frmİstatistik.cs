using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Urun_Satis_Uygulama
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        EF_UrunEntities db = new EF_UrunEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_Kategoriler.Count().ToString();
            label5.Text = db.Tbl_Urunler.Count().ToString();
            label7.Text = db.Tbl_Musteriler.Count(x => x.Durum == true).ToString();
            label9.Text = db.Tbl_Musteriler.Count(x => x.Durum == false).ToString();
            label3.Text = db.Tbl_Urunler.Sum(x => x.Stok).ToString();
            label17.Text = db.Tbl_Satislar.Sum(x => x.Fiyat).ToString() + "TL";
            label11.Text = (from x in db.Tbl_Urunler orderby x.Fiyat descending select x.UrunAd).FirstOrDefault();
            label13.Text= (from x in db.Tbl_Urunler orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault();
            label15.Text = db.Tbl_Urunler.Count(x => x.Kategori == 1).ToString();
            label21.Text = db.Tbl_Urunler.Count(x => x.UrunAd == "Buzdolabı").ToString();
            label23.Text = (from x in db.Tbl_Musteriler select x.Sehir).Distinct().Count().ToString();
            label19.Text = db.Markagetir().FirstOrDefault();
        }
    }
}
