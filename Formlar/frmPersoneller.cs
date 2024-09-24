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
    public partial class frmPersoneller : Form
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }

        private Entity.DbisTakipEntities db = new Entity.DbisTakipEntities();
        void personelListele()
        {
            var degerler = (from x in db.tbl_Personeler
                            where x.DURUM == true
                            select new
                            {
                                x.ID_PERSONAl,
                                x.PERSONEL_ADI,
                                x.PERSONEL_SOYADI,
                                x.PERSONEL_MAIL,
                                x.PERSONEL_TELEFON,
                                x.tbl_Departmanlar.DEPARTMAN_ADI, //ayn isimde baska column varsa gibi abc=x.tbl_Departmanlar.adi ornek bu                               
                            });
            gridControl1.DataSource = degerler.ToList();
        }
        private void frmPersoneller_Load(object sender, EventArgs e)
        {
            personelListele();

            var departmanlar = (from x in db.tbl_Departmanlar select new 
            {
                x.ID_DEPARTMAN,
                x.DEPARTMAN_ADI
            }).ToList(); 

            cbxDepartmanlar.Properties.ValueMember = "ID_DEPARTMAN";
            cbxDepartmanlar.Properties.DisplayMember = "DEPARTMAN_ADI";
            cbxDepartmanlar.Properties.DataSource = departmanlar;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtPerID.Text = gridView1.GetFocusedRowCellValue("ID_PERSONAl")?.ToString() ?? string.Empty;
            txtPerAdi.Text = gridView1.GetFocusedRowCellValue("PERSONEL_ADI")?.ToString() ?? string.Empty;
            txtPerSoyadi.Text = gridView1.GetFocusedRowCellValue("PERSONEL_SOYADI")?.ToString() ?? string.Empty;
            txtPerMail.Text = gridView1.GetFocusedRowCellValue("PERSONEL_MAIL")?.ToString() ?? string.Empty;
            txtPerTel.Text = gridView1.GetFocusedRowCellValue("PERSONEL_TELEFON")?.ToString() ?? string.Empty;
            /*cbxDepartmanlar.Text = gridView1.GetFocusedRowCellValue("ID_DEPARTMAN")?.ToString() ?? string.Empty;*/ //calismadi duzelt
        }

        private void btnPerListele_Click(object sender, EventArgs e)
        {
            personelListele();
        }

        private void btnPerEkle_Click(object sender, EventArgs e)
        {
            tbl_Personeler t = new tbl_Personeler();
            t.PERSONEL_ADI = txtPerAdi.Text;
            t.PERSONEL_SOYADI = txtPerSoyadi.Text;
            t.PERSONEL_MAIL = txtPerMail.Text;
            t.PERSONEL_TELEFON = txtPerTel.Text;
            t.DEPARTMAN = int.Parse(cbxDepartmanlar.EditValue.ToString());
            t.DURUM=true;
            db.tbl_Personeler.Add(t);
            db.SaveChanges();

            XtraMessageBox.Show("Yeni Personel Kaydi Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            personelListele();
        }

        private void btnPerSil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(txtPerID.Text);
            var deger = db.tbl_Personeler.Find(x);
            deger.DURUM = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personel Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListele();
        }

        private void btnPerGuncelle_Click(object sender, EventArgs e)
        {
            int x= int.Parse(txtPerID.Text);
            var deger = db.tbl_Personeler.Find(x);
            deger.PERSONEL_ADI = txtPerAdi.Text;
            deger.PERSONEL_SOYADI = txtPerSoyadi.Text;
            deger.PERSONEL_MAIL = txtPerMail.Text;
            deger.PERSONEL_TELEFON = txtPerTel.Text;
            deger.DEPARTMAN = int.Parse(cbxDepartmanlar.EditValue.ToString()); 
            db.SaveChanges();
            XtraMessageBox.Show("Personel Başarılı Şekilde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListele();
        }
    }
}
