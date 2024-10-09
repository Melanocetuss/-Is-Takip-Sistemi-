using DevExpress.XtraEditors;
using IsTakipSistemi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipSistemi.KullaniciFormlari
{
    public partial class frmCagriDetay : Form
    {
        public int ID;
        public frmCagriDetay()
        {
            InitializeComponent();
        }
        private Entity.DbisTakipEntities1 db = new Entity.DbisTakipEntities1();
        private void frmCagriDetay_Load(object sender, EventArgs e)
        {
            txtCagriID.Enabled = false;
            txtCagriID.Text = ID.ToString();
            string tarih = DateTime.Now.ToShortDateString();
            string saat = DateTime.Now.ToShortTimeString();
            txtTarih.Text = tarih;
            txtSaat.Text = saat;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tbl_CagriDetay t = new tbl_CagriDetay();

            t.CAGRI_ID = int.Parse(txtCagriID.Text);
            t.Tarih = DateTime.Parse(txtTarih.Text);
            t.Saat = txtSaat.Text;
            t.ACIKLAMA = txtAciklama.Text;
            db.tbl_CagriDetay.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Başarıyla Çağrıya Detay eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
