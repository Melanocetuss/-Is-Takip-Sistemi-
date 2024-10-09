using DevExpress.Utils;
using DevExpress.XtraEditors;
using IsTakipSistemi.Entity;
using IsTakipSistemi.Kullanici_Formlari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipSistemi.Login
{
    public partial class frmLogin : Form
    {
        private DbisTakipEntities1 db = new DbisTakipEntities1 ();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 109, 109, 109);
            panel2.BackColor = Color.FromArgb(100, 109, 109, 109);
        }
        private void txtMail_Click(object sender, EventArgs e)
        {
            txtMail.BackColor = Color.White;
            txtSifre.BackColor = Color.Black;
            panel2.BackColor = Color.FromArgb(80, 30, 144, 255);
            panel3.BackColor = Color.FromArgb(100, 109, 109, 109);
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            txtSifre.BackColor = Color.White;
            txtMail.BackColor = Color.Black;
            panel3.BackColor = Color.FromArgb(80, 30, 144, 255);
            panel2.BackColor = Color.FromArgb(100, 109, 109, 109);
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdminGir_Click(object sender, EventArgs e)
        {
            var adminDeger = db.tbl_ADMIN.Where(x => x.KULLANICI_ADI == txtMail.Text && x.SIFRE == txtSifre.Text).FirstOrDefault();
            if(adminDeger != null)
            {
                IsTakipSistemi.IsTakipUygulamasi frm = new IsTakipUygulamasi();
                frm.Show();
                this.Hide();
            }
            else 
            {
                XtraMessageBox.Show("Şifre Veya Mail Yanlış", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPerGir_Click(object sender, EventArgs e)
        {
            var personelDeger = db.tbl_Personeler.Where(x => x.PERSONEL_MAIL == txtMail.Text && x.SIFRE == txtSifre.Text).FirstOrDefault();
            if (personelDeger != null)
            {
                Kullanici_Formlari.frmMain frm = new frmMain();
                frm.mail = txtMail.Text;
                frm.Show();
                this.Hide();

            }
            else
            {
                XtraMessageBox.Show("Şifre Veya Mail Yanlış", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
