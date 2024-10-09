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
    public partial class frmCagriAtama : Form
    {
        public int IdCagri;
        private DbisTakipEntities1 db = new DbisTakipEntities1();
        public frmCagriAtama()
        {
            InitializeComponent();
        }

        private void frmCagriAtama_Load(object sender, EventArgs e)
        {
            var personelVerileri = (from x in db.tbl_Personeler 
                                    select new 
                                    {
                                        x.ID_PERSONAl,
                                        AdSoyad = x.PERSONEL_ADI +" "+ x.PERSONEL_SOYADI
                                    }).ToList();
            
            cbxGorevAlanPer.Properties.ValueMember = "ID_PERSONAl";
            cbxGorevAlanPer.Properties.DisplayMember = "AdSoyad";
            cbxGorevAlanPer.Properties.DataSource = personelVerileri;


            txtCagriID.Text =IdCagri.ToString();
            txtCagriID.Enabled = false;

            var cagriID = db.tbl_Cagri.Find(IdCagri);
            txtKonu.Text = cagriID.KONU.ToString();
            txtTarih.Text = cagriID.TARIH.ToString();
            txtAciklama.Text = cagriID.ACIKLAMA;
            

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var gelenveri = db.tbl_Cagri.Find(IdCagri);
            gelenveri.KONU = txtKonu.Text;
            gelenveri.TARIH = DateTime.Parse(txtTarih.Text);
            gelenveri.ACIKLAMA = txtAciklama.Text;
            gelenveri.PERSONEL_ID = int.Parse(cbxGorevAlanPer.EditValue.ToString());
            db.SaveChanges();
        }
    }
}
