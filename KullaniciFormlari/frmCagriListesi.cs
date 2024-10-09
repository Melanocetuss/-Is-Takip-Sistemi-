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
    public partial class frmCagriListesi : Form
    {
        Entity.DbisTakipEntities1 db = new Entity.DbisTakipEntities1 ();
        public int ID;
        frmCagriDetay frmCagriDetay;
        public frmCagriListesi()
        {
            InitializeComponent();
        }

        private void frmCagriListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.tbl_Cagri 
                                       where x.CAGRI_DURUM == true
                                       select new 
                                       {
                                           x.ID_CAGRI,
                                           cagridanSorumluPersonel = x.tbl_Personeler.PERSONEL_ADI+" "+x.tbl_Personeler.PERSONEL_SOYADI,
                                           x.tbl_Firmalar.FIRMA_ADI,
                                           x.tbl_Firmalar.FIRMA_TELEFON,
                                           x.tbl_Firmalar.FIRMA_MAIL,
                                           x.ACIKLAMA
                                       }).ToList();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (frmCagriDetay == null || frmCagriDetay.IsDisposed) 
            {
                frmCagriDetay = new frmCagriDetay();
                frmCagriDetay.ID = int.Parse(gridView1.GetFocusedRowCellValue("ID_CAGRI").ToString());
                frmCagriDetay.Show();
            }
            
        }
    }
}
