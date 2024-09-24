using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Filtering.Helpers;
using IsTakipSistemi.Entity;

namespace IsTakipSistemi.Formlar
{
    public partial class frmAnasayfa : Form
    {
        Entity.DbisTakipEntities db = new Entity.DbisTakipEntities();
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            //Aktif Gorevler
            gridControl1.DataSource = (from x in db.tbl_Gorevler
                                       where x.GOREV_DURUM == true
                                       select new
                                       {                                         
                                           x.GOREV_ACIKLAMA,
                                           GorevAlan = x.tbl_Personeler.PERSONEL_ADI +" "+ x.tbl_Personeler.PERSONEL_SOYADI
                                       }).ToList();
                       
            //Bugunki Gorevler
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            gridControl2.DataSource = (from x in db.tbl_GorevDetaylar
                                       where x.TARIH == bugun    
                                       select new
                                       {
                                           GorevAdi = x.tbl_Gorevler.GOREV_ACIKLAMA,
                                           x.ACIKLAMA,
                                           x.TARIH                                   
                                       }).ToList();

            //Cagrilar
            gridControl3.DataSource = (from x in db.tbl_Cagri 
                                       where x.CAGRI_DURUM == true
                                       select new                                      
                                       {    
                                           x.tbl_Firmalar.FIRMA_ADI,
                                           x.KONU,
                                           x.TARIH,                                         
                                       }).ToList();
            //Fihrist Komutları
            gridControl4.DataSource = (from x in db.tbl_Firmalar 
                                       select new 
                                       {
                                           x.FIRMA_ADI,
                                           x.FIRMA_SEKTOR,
                                           x.FIRMA_TELEFON,
                                           x.FIRMA_MAIL
                                       }).ToList();
            //Grafik
            int aktifCagrilar = int.Parse(db.tbl_Cagri.Where(x=> x.CAGRI_DURUM == true).Count().ToString());
            int pasifCagrilar = int.Parse(db.tbl_Cagri.Where(x => x.CAGRI_DURUM == false).Count().ToString());
            
            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Çağrılar", aktifCagrilar);
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Çağrılar", pasifCagrilar);

        }
    }
}
