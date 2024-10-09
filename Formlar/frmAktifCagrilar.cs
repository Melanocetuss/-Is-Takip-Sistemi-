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
    public partial class frmAktifCagrilar : Form
    {
        private DbisTakipEntities1 db = new DbisTakipEntities1();

        public frmAktifCagrilar()
        {
            InitializeComponent();
        }
        
        private void frmAktifCagrilar_Load(object sender, EventArgs e)
        {
            var deger = (from x in db.tbl_Cagri 
                         where x.CAGRI_DURUM == true
                         select new 
                         {
                             x.ID_CAGRI,
                             x.tbl_Firmalar.FIRMA_ADI,
                             x.tbl_Firmalar.FIRMA_TELEFON,
                             x.KONU,
                             x.ACIKLAMA,
                             x.tbl_Personeler.PERSONEL_ADI
                         }).ToList();
            gridControl1.DataSource = deger;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmCagriAtama frm = new frmCagriAtama();
            frm.IdCagri = int.Parse(gridView1.GetFocusedRowCellValue("ID_CAGRI").ToString());
            frm.Show();
        }
    }
}
