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
    public partial class FrmGirisYap : Form
    {
        public FrmGirisYap()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            EF_UrunEntities db = new EF_UrunEntities();
            var sorgu = from x in db.Tbl_Adminler where x.KullaniciAdi == txtad.Text && x.Sifre == txtSifre.Text select x;
            if (sorgu.Any())
            {
                FrmAnaForm frmAnaForm = new FrmAnaForm();
                frmAnaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Bilgileri Girdiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
