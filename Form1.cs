using IsTakipSistemi.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipSistemi
{
    public partial class IsTakipUygulamasi : Form
    {
        private Formlar.frmDepartmanlar frmDep;
        private Formlar.frmPersoneller frmPer;
        private Formlar.frmGorevListesi frmGorL;
        private Formlar.frmGorevEkle frmGorevEkle;
        private Formlar.frmPersonelIstatistikleri frmPerI;
        private Formlar.frmGorevDetay frmGorevDetay;
        private Formlar.frmAnasayfa frmAnasayfa;
        public IsTakipUygulamasi()
        {
            InitializeComponent();
        }

        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmDep == null || frmDep.IsDisposed)
            {
                frmDep = new Formlar.frmDepartmanlar();
                frmDep.MdiParent = this;
                frmDep.Show();
            }            
        }

        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmPer == null || frmPer.IsDisposed)
            {
                frmPer = new Formlar.frmPersoneller();
                frmPer.MdiParent = this;
                frmPer.Show();
            }
            
        }

        private void btnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGorL == null || frmGorL.IsDisposed)
            {
                frmGorL = new Formlar.frmGorevListesi();
                frmGorL.MdiParent = this;
                frmGorL.Show();
            }          
        }

        private void btnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {  
           if(frmGorevDetay == null || frmGorevDetay.IsDisposed)
            {
                frmGorevDetay = new Formlar.frmGorevDetay();
                frmGorevDetay.Show();
            }
                       
        }
        
        private void btnGorevEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmGorevEkle == null || frmGorevEkle.IsDisposed)
            {
                frmGorevEkle = new Formlar.frmGorevEkle();
                frmGorevEkle.Show();
            }           
        }

        private void btnPersonelIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmPerI == null || frmPerI.IsDisposed)
            {
                frmPerI = new frmPersonelIstatistikleri();
                frmPerI.MdiParent = this;
                frmPerI.Show();
            }
            
        }
        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmAnasayfa == null || frmAnasayfa.IsDisposed)
            {
                frmAnasayfa = new frmAnasayfa();
                frmAnasayfa.MdiParent = this;
                frmAnasayfa.Show();
            }
        }
    }
}
