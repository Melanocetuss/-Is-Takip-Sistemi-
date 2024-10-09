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

namespace IsTakipSistemi.Kullanici_Formlari
{
    public partial class frmAktifGorevler : Form
    {
        private DbisTakipEntities1 db = new DbisTakipEntities1();
        public string mail;
        public frmAktifGorevler()
        {
            InitializeComponent();
        }

        private void frmAktifGorevler_Load(object sender, EventArgs e)
        {
            var personelId = db.tbl_Personeler.Where(x=> x.PERSONEL_MAIL == mail).Select(x=> x.ID_PERSONAl).FirstOrDefault();
            var deger = (from x in db.tbl_Gorevler
                         where x.GOREV_ALAN == personelId && x.GOREV_DURUM == true 
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
