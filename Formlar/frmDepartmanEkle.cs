using DevExpress.XtraEditors;
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
    public partial class frmDepartmanEkle : Form
    {        
        private Entity.DbisTakipEntities1 db = new DbisTakipEntities1();
        public frmDepartmanEkle()
        {
            InitializeComponent();
        }

        private void btnDepEkle_Click(object sender, EventArgs e)
        {
            tbl_Departmanlar t = new tbl_Departmanlar();
            t.DEPARTMAN_ADI = txtDepAdi.Text;
            db.tbl_Departmanlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);           
        }

        private void btnDepSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtDepID.Text);
            var deger = db.tbl_Departmanlar.Find(x);
            db.tbl_Departmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
