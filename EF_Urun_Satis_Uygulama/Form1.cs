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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EF_UrunEntities db = new EF_UrunEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.Tbl_Kategoriler.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Tbl_Kategoriler t = new Tbl_Kategoriler();
            t.Ad = txtad.Text;
            db.Tbl_Kategoriler.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtıd.Text);
            var ktgr = db.Tbl_Kategoriler.Find(x);
            db.Tbl_Kategoriler.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtıd.Text);
            var ktgr = db.Tbl_Kategoriler.Find(x);
            ktgr.Ad = txtad.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
