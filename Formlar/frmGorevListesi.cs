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
    public partial class frmGorevListesi : Form
    {
        public frmGorevListesi()
        {
            InitializeComponent();
        }

        private Entity.DbisTakipEntities db = new Entity.DbisTakipEntities();

        private void gorevListele()
        {
            gridControl1.DataSource = (from x in db.tbl_Gorevler
                                       select new
                                       {
                                           x.GOREV_ACIKLAMA,
                                           x.GOREV_TARIH
                                       }).ToList();

            lblTopDep.Text = db.tbl_Departmanlar.Count().ToString();
            lblAktifGorevler.Text = db.tbl_Gorevler.Count(x => x.GOREV_DURUM == true).ToString();
            lblPasifGorevler.Text = db.tbl_Gorevler.Count(x => x.GOREV_DURUM == false).ToString();
        }
        private void frmGorevListesi_Load(object sender, EventArgs e)
        {
            gorevListele();
            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(lblAktifGorevler.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(lblPasifGorevler.Text));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gorevListele();
        }
    }
}
