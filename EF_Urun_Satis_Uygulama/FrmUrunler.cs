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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        EF_UrunEntities db = new EF_UrunEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = (from x in db.Tbl_Urunler
                                        select new
                                        {
                                            x.UrunId,
                                            x.UrunAd,
                                            x.Marka,
                                            x.Stok,
                                            x.Fiyat,
                                            x.Tbl_Kategoriler.Ad,
                                            x.Durum
                                        }).ToList();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {

            Tbl_Urunler t = new Tbl_Urunler();
            t.UrunAd = txtAd.Text;
            t.Marka = txtmarka.Text;
            t.Stok = short.Parse(txtstok.Text);
            t.Kategori = int.Parse(cmbkategori.SelectedValue.ToString());
            t.Fiyat = decimal.Parse(txtfiyat.Text);
            t.Durum = true;
            db.Tbl_Urunler.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtıd.Text);
            var urun = db.Tbl_Urunler.Find(x);
            db.Tbl_Urunler.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtıd.Text);
            var urun = db.Tbl_Urunler.Find(x);
            urun.UrunAd = txtAd.Text;
            urun.Stok = short.Parse(txtstok.Text);
            urun.Marka = txtmarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategoriler
                               select new
                               {
                                   x.Id,
                                   x.Ad
                               }
                               ).ToList();

            cmbkategori.ValueMember = "Id";
            cmbkategori.DisplayMember = "Ad";
            cmbkategori.DataSource = kategoriler;


        }
    }
}
