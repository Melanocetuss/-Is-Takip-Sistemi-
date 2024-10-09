using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using IsTakipSistemi.Entity;

namespace IsTakipSistemi.Formlar
{
    public partial class frmDepartmanListesi : Form
    {
        public frmDepartmanListesi()
        {
            InitializeComponent();
        }
        
        private Entity.DbisTakipEntities1 db = new DbisTakipEntities1();
        
        public void departmanListele()
        {
            var degerler = (from x in db.tbl_Departmanlar select new 
            { 
                x.ID_DEPARTMAN,
                x.DEPARTMAN_ADI
            }).ToList();                                                                                                                                                  
            gridControl1.DataSource = degerler;
        }
        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {
            db.tbl_Departmanlar.Load();
            bindingSource1.DataSource = db.tbl_Departmanlar.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void departmanSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
