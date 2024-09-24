using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IsTakipSistemi.Entity;
using System.Data.Entity;
namespace IsTakipSistemi.Formlar
{
    public partial class frmGorevDetay : Form
    {
        private Entity.DbisTakipEntities db = new Entity.DbisTakipEntities();
        public frmGorevDetay()
        {
            InitializeComponent();
        }

        private void frmGorevDetay_Load(object sender, EventArgs e)
        {
            db.tbl_GorevDetaylar.Load();
            bindingSource1.DataSource = db.tbl_GorevDetaylar.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();   
        }

        private void görevDetaySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}