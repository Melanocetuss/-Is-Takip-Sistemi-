using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IsTakipSistemi.Entity;

namespace IsTakipSistemi.Formlar
{
    public partial class frmGorevEkle : Form
    {
        public frmGorevEkle()
        {
            InitializeComponent();
        }

        private Entity.DbisTakipEntities db = new DbisTakipEntities();

        private void frmGorevEkle_Load(object sender, EventArgs e)
        {
            var personel = (from x in db.tbl_Personeler
                            where x.DURUM == true
                                select new
                                {
                                    x.ID_PERSONAl,
                                    AdSoyad = x.PERSONEL_ADI +" "+ x.PERSONEL_SOYADI,                                   
                                }).ToList();
          
            cbxGorevAlan.Properties.ValueMember = "ID_PERSONAl";
            cbxGorevAlan.Properties.DisplayMember = "AdSoyad";
            cbxGorevAlan.Properties.DataSource = personel.ToList();


        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tbl_Gorevler t = new tbl_Gorevler();

            t.GOREV_VEREN = int.Parse(txtGorevVeren.Text);
            t.GOREV_ALAN = int.Parse(cbxGorevAlan.EditValue.ToString());
            t.GOREV_TARIH = DateTime.Parse(txtTarih.Text);
            t.GOREV_ACIKLAMA = txtAciklama.Text;
            t.GOREV_DURUM = true; //checkbox icin hazirlicam

            db.tbl_Gorevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Görev Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

       
    }
}
