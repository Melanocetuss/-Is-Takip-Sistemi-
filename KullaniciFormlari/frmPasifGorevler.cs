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
    public partial class frmPasifGorevler : Form
    {
        private DbisTakipEntities1 db = new DbisTakipEntities1 ();
        public string mail;
        public frmPasifGorevler()
        {
            InitializeComponent();
        }

        private void frmPasifGorevler_Load(object sender, EventArgs e)
        {
            var personelID = db.tbl_Personeler.Where(x => x.PERSONEL_MAIL == mail).Select(x => x.ID_PERSONAl).FirstOrDefault();
            var deger = (from x in db.tbl_Gorevler
                         where x.GOREV_ALAN == personelID && x.GOREV_DURUM == false
                         select new
                         {
                             x.ID_GOREV,
                             x.GOREV_ACIKLAMA,
                             x.GOREV_TARIH
                         }).ToList();
            gridControl1.DataSource = deger;
        }
    }
}
