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
    public partial class frmPasifCagrilar : Form
    {
        private DbisTakipEntities1 db = new DbisTakipEntities1 ();
        public frmPasifCagrilar()
        {
            InitializeComponent();
        }

        private void frmPasifCagrilar_Load(object sender, EventArgs e)
        {
            var deger = (from x in db.tbl_Cagri
                         where x.CAGRI_DURUM == false
                         select new
                         {
                             x.ID_CAGRI,
                             x.tbl_Firmalar.FIRMA_ADI,
                             x.tbl_Firmalar.FIRMA_TELEFON,
                             x.KONU,
                             x.ACIKLAMA,
                         }).ToList();
            gridControl1.DataSource = deger;
        }
    }
}
