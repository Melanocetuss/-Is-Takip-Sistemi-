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

namespace IsTakipSistemi.Formlar
{
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private Entity.DbisTakipEntities db = new Entity.DbisTakipEntities();
        private void btnPerEkle_Click(object sender, EventArgs e)
        {
            tbl_Personeler t = new tbl_Personeler();
            t.PERSONEL_ADI = txtPerAdi.Text;
            t.PERSONEL_SOYADI = txtPerSoyadi.Text;
            t.PERSONEL_MAIL = txtPerMail.Text;
            t.PERSONEL_TELEFON = txtPerTel.Text;
            t.DEPARTMAN = int.Parse(cbxDepartmanlar.EditValue.ToString());
            t.DURUM = true;
            db.tbl_Personeler.Add(t);
            db.SaveChanges();

            XtraMessageBox.Show("Yeni Personel Kaydi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPerSil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(txtPerID.Text);
            var deger = db.tbl_Personeler.Find(x);
            deger.DURUM = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personel Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            var departmanlar = (from x in db.tbl_Departmanlar
                                select new
                                {
                                    x.ID_DEPARTMAN,
                                    x.DEPARTMAN_ADI
                                }).ToList();

            cbxDepartmanlar.Properties.ValueMember = "ID_DEPARTMAN";
            cbxDepartmanlar.Properties.DisplayMember = "DEPARTMAN_ADI";
            cbxDepartmanlar.Properties.DataSource = departmanlar;
        }
    }
}
