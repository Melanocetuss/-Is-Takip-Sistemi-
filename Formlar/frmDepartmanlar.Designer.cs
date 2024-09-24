namespace IsTakipSistemi.Formlar
{
    partial class frmDepartmanlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmanlar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpCDep = new DevExpress.XtraEditors.GroupControl();
            this.btnDepGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnDepSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDepEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnDepListele = new DevExpress.XtraEditors.SimpleButton();
            this.txtDepAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDepID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCDep)).BeginInit();
            this.grpCDep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, -2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1168, 615);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // grpCDep
            // 
            this.grpCDep.Controls.Add(this.btnDepGuncelle);
            this.grpCDep.Controls.Add(this.btnDepSil);
            this.grpCDep.Controls.Add(this.btnDepEkle);
            this.grpCDep.Controls.Add(this.btnDepListele);
            this.grpCDep.Controls.Add(this.txtDepAdi);
            this.grpCDep.Controls.Add(this.labelControl2);
            this.grpCDep.Controls.Add(this.txtDepID);
            this.grpCDep.Controls.Add(this.labelControl1);
            this.grpCDep.Location = new System.Drawing.Point(1174, -2);
            this.grpCDep.Name = "grpCDep";
            this.grpCDep.Size = new System.Drawing.Size(383, 615);
            this.grpCDep.TabIndex = 1;
            // 
            // btnDepGuncelle
            // 
            this.btnDepGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDepGuncelle.ImageOptions.Image")));
            this.btnDepGuncelle.Location = new System.Drawing.Point(130, 217);
            this.btnDepGuncelle.Name = "btnDepGuncelle";
            this.btnDepGuncelle.Size = new System.Drawing.Size(183, 35);
            this.btnDepGuncelle.TabIndex = 7;
            this.btnDepGuncelle.Text = "Güncelle";
            this.btnDepGuncelle.Click += new System.EventHandler(this.btnDepGuncelle_Click);
            // 
            // btnDepSil
            // 
            this.btnDepSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDepSil.ImageOptions.Image")));
            this.btnDepSil.Location = new System.Drawing.Point(130, 176);
            this.btnDepSil.Name = "btnDepSil";
            this.btnDepSil.Size = new System.Drawing.Size(183, 35);
            this.btnDepSil.TabIndex = 6;
            this.btnDepSil.Text = "Sil";
            this.btnDepSil.Click += new System.EventHandler(this.btnDepSil_Click);
            // 
            // btnDepEkle
            // 
            this.btnDepEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDepEkle.ImageOptions.Image")));
            this.btnDepEkle.Location = new System.Drawing.Point(130, 135);
            this.btnDepEkle.Name = "btnDepEkle";
            this.btnDepEkle.Size = new System.Drawing.Size(183, 35);
            this.btnDepEkle.TabIndex = 5;
            this.btnDepEkle.Text = "Ekle";
            this.btnDepEkle.Click += new System.EventHandler(this.btnDepEkle_Click);
            // 
            // btnDepListele
            // 
            this.btnDepListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDepListele.ImageOptions.Image")));
            this.btnDepListele.Location = new System.Drawing.Point(130, 94);
            this.btnDepListele.Name = "btnDepListele";
            this.btnDepListele.Size = new System.Drawing.Size(183, 35);
            this.btnDepListele.TabIndex = 4;
            this.btnDepListele.Text = "Listele";
            this.btnDepListele.Click += new System.EventHandler(this.btnDepListele_Click);
            // 
            // txtDepAdi
            // 
            this.txtDepAdi.Location = new System.Drawing.Point(130, 66);
            this.txtDepAdi.Name = "txtDepAdi";
            this.txtDepAdi.Size = new System.Drawing.Size(183, 22);
            this.txtDepAdi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Departmanlar ADI:";
            // 
            // txtDepID
            // 
            this.txtDepID.Location = new System.Drawing.Point(130, 38);
            this.txtDepID.Name = "txtDepID";
            this.txtDepID.Size = new System.Drawing.Size(183, 22);
            this.txtDepID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Departmanlar ID:";
            // 
            // frmDepartmanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 606);
            this.Controls.Add(this.grpCDep);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmDepartmanlar";
            this.Text = "Departman Listesi";
            this.Load += new System.EventHandler(this.frmDepartmanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCDep)).EndInit();
            this.grpCDep.ResumeLayout(false);
            this.grpCDep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpCDep;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDepGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnDepSil;
        private DevExpress.XtraEditors.SimpleButton btnDepEkle;
        private DevExpress.XtraEditors.SimpleButton btnDepListele;
        private DevExpress.XtraEditors.TextEdit txtDepAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDepID;
    }
}