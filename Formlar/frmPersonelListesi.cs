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
using IsTakipSistemi.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IsTakipSistemi.Formlar
{
    public partial class frmPersonelListesi : Form
    {
        public frmPersonelListesi()
        {
            InitializeComponent();
        }

        private Entity.DbisTakipEntities1 db = new Entity.DbisTakipEntities1();
        void personelListele()
        {
            try
            {
                var personeller = (from p in db.tbl_Personeler
                                   join d in db.tbl_Departmanlar on p.DEPARTMAN equals d.ID_DEPARTMAN
                                   where p.DURUM == true
                                   select new
                                   {
                                       p.ID_PERSONAl,     
                                       p.PERSONEL_ADI,
                                       p.PERSONEL_SOYADI,
                                       p.PERSONEL_MAIL,
                                       p.PERSONEL_TELEFON,
                                       DepartmanAdi = d.DEPARTMAN_ADI,
                                       p.DEPARTMAN // Foreing key 
                                   }).ToList();

                bindingSource1.DataSource = personeller;
                gridControl1.DataSource = bindingSource1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void frmPersoneller_Load(object sender, EventArgs e)
        {
            personelListele();
            /*this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowEdit = false;*/
        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {              
            if (gridView1.FocusedRowHandle >= 0)
            {               
                int personelId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("PersonelID"));               
                var personel = db.tbl_Personeler.Find(personelId);

                if (personel != null)
                {                    
                    personel.DURUM = false;
                    db.SaveChanges(); 

                    MessageBox.Show("Personel durumu pasif hale getirildi.");
                    personelListele(); 
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir personel seçin.");
            }

        }
    }
}
