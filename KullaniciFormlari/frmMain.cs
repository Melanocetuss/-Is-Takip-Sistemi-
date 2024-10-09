using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IsTakipSistemi.Formlar;
using IsTakipSistemi.KullaniciFormlari;

namespace IsTakipSistemi.Kullanici_Formlari
{
    public partial class frmMain : Form
    {
        private Kullanici_Formlari.frmAktifGorevler frmAktifGorevler;
        private KullaniciFormlari.frmPasifGorevler frmPasifGorevler;
        private KullaniciFormlari.frmCagriListesi frmCagriListesi;
        public string mail;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAktifGorevler == null || frmAktifGorevler.IsDisposed)
            {
                frmAktifGorevler = new frmAktifGorevler();
                frmAktifGorevler.MdiParent = this;
                frmAktifGorevler.mail = mail;
                frmAktifGorevler.Show();
            }
        }

        private void btnTamamlananGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmPasifGorevler == null || frmPasifGorevler.IsDisposed) 
            {
                frmPasifGorevler = new frmPasifGorevler();
                frmPasifGorevler.MdiParent = this;
                frmPasifGorevler.Show();
            }
            
        }

        private void btnCagriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmCagriListesi == null || frmCagriListesi.IsDisposed) 
            {
                frmCagriListesi = new frmCagriListesi();
                frmCagriListesi .MdiParent = this;
                frmCagriListesi .Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = mail.ToString();
        }
    }
}
