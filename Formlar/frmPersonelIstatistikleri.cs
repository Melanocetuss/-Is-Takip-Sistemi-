using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IsTakipSistemi;

namespace IsTakipSistemi.Formlar
{
    public partial class frmPersonelIstatistikleri : Form
    {
        
        private Entity.DbisTakipEntities db = new Entity.DbisTakipEntities();
        private Timer timer = new Timer();

        public frmPersonelIstatistikleri()
        {
            InitializeComponent();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm");
        }

        private void frmPersonel_Istatistikler_Load(object sender, EventArgs e)
        {
            lblPersonelSayisi.Text = db.tbl_Personeler.Count(x => x.DURUM == true).ToString(); 
            lblAktifIsSayisi.Text = db.tbl_Gorevler.Count(x => x.GOREV_DURUM == true).ToString(); 
            lblPasifIsSayisi.Text = db.tbl_Gorevler.Count(x => x.GOREV_DURUM == false).ToString(); 
            lblFirmaSayisi.Text = db.tbl_Firmalar.Count().ToString();
            lblIsYapilanSehir.Text = db.tbl_Firmalar.Select(x => x.FIRMA_IL).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today; lblBugunAcilanGorevler.Text = db.tbl_Gorevler.Count(x=> x.GOREV_TARIH == bugun).ToString();
            lblSonGorev.Text = db.tbl_Gorevler.OrderByDescending(x=> x.ID_GOREV).Select(x=> x.GOREV_ACIKLAMA).FirstOrDefault().ToString();
            lblSektorSayisi.Text = db.tbl_Firmalar.Select(x=> x.FIRMA_SEKTOR).Distinct().Count().ToString();    
            //
            var ayinPerId = db.tbl_Gorevler.GroupBy(x => x.GOREV_ALAN).OrderByDescending(x => x.Count()).Select(x=> x.Key).FirstOrDefault();
            lblAyinPersoneli.Text = db.tbl_Personeler.Where(x=> x.ID_PERSONAl == ayinPerId).Select(x => x.PERSONEL_ADI + " " + x.PERSONEL_SOYADI).FirstOrDefault().ToString();
            //
            lblAyinDepartmani.Text = db.tbl_Departmanlar
                .Where(x => x.ID_DEPARTMAN == db.tbl_Personeler
                .Where(y=> y.ID_PERSONAl == ayinPerId).Select(z=> z.DEPARTMAN).FirstOrDefault())
                .Select(x=> x.DEPARTMAN_ADI).FirstOrDefault().ToString();
            
            lblTarih.Text = bugun.ToString("dd-MM-yyyy");
            
            timer.Interval = 1000; // 1 saniye
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();           
        }

    }
}
