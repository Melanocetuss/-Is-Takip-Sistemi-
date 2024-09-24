using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmDepartmanlar : Form
    {
        public frmDepartmanlar()
        {
            InitializeComponent();
        }
        
        private Entity.DbisTakipEntities db = new DbisTakipEntities();
        
        //crud --> create read update delete
        void departmanListele()
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
            departmanListele();
        }

        private void btnDepListele_Click(object sender, EventArgs e)
        {
            departmanListele();
        }

        private void btnDepEkle_Click(object sender, EventArgs e)
        {
            tbl_Departmanlar t = new tbl_Departmanlar();
            t.DEPARTMAN_ADI = txtDepAdi.Text;
            db.tbl_Departmanlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman Başarıyla Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            departmanListele();
        }

        private void btnDepSil_Click(object sender, EventArgs e)
        {
            int x= int.Parse(txtDepID.Text);
            var deger = db.tbl_Departmanlar.Find(x);
            db.tbl_Departmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            departmanListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtDepID.Text = gridView1.GetFocusedRowCellValue("ID_DEPARTMAN")?.ToString() ?? string.Empty;
            txtDepAdi.Text = gridView1.GetFocusedRowCellValue("DEPARTMAN_ADI")?.ToString() ?? string.Empty;
        }

        private void btnDepGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtDepID.Text);
            var deger = db.tbl_Departmanlar.Find(x);
            deger.DEPARTMAN_ADI = txtDepAdi.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            departmanListele();
        }
    }
}
