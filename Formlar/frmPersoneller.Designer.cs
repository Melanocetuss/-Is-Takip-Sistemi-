namespace IsTakipSistemi.Formlar
{
    partial class frmPersoneller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersoneller));
            this.grpC_Per = new DevExpress.XtraEditors.GroupControl();
            this.txtPerSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbxDepartmanlar = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPerTel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPerMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnPerGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnPerSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnPerEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnPerListele = new DevExpress.XtraEditors.SimpleButton();
            this.txtPerAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPerID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grpC_Per)).BeginInit();
            this.grpC_Per.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartmanlar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpC_Per
            // 
            this.grpC_Per.Controls.Add(this.txtPerSoyadi);
            this.grpC_Per.Controls.Add(this.labelControl5);
            this.grpC_Per.Controls.Add(this.cbxDepartmanlar);
            this.grpC_Per.Controls.Add(this.labelControl6);
            this.grpC_Per.Controls.Add(this.txtPerTel);
            this.grpC_Per.Controls.Add(this.labelControl3);
            this.grpC_Per.Controls.Add(this.txtPerMail);
            this.grpC_Per.Controls.Add(this.labelControl4);
            this.grpC_Per.Controls.Add(this.btnPerGuncelle);
            this.grpC_Per.Controls.Add(this.btnPerSil);
            this.grpC_Per.Controls.Add(this.btnPerEkle);
            this.grpC_Per.Controls.Add(this.btnPerListele);
            this.grpC_Per.Controls.Add(this.txtPerAdi);
            this.grpC_Per.Controls.Add(this.labelControl2);
            this.grpC_Per.Controls.Add(this.txtPerID);
            this.grpC_Per.Controls.Add(this.labelControl1);
            this.grpC_Per.Location = new System.Drawing.Point(1156, -4);
            this.grpC_Per.Name = "grpC_Per";
            this.grpC_Per.Size = new System.Drawing.Size(383, 615);
            this.grpC_Per.TabIndex = 3;
            // 
            // txtPerSoyadi
            // 
            this.txtPerSoyadi.Location = new System.Drawing.Point(130, 94);
            this.txtPerSoyadi.Name = "txtPerSoyadi";
            this.txtPerSoyadi.Size = new System.Drawing.Size(183, 22);
            this.txtPerSoyadi.TabIndex = 16;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(25, 100);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 16);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Personel Soyadı:";
            // 
            // cbxDepartmanlar
            // 
            this.cbxDepartmanlar.EditValue = "";
            this.cbxDepartmanlar.Location = new System.Drawing.Point(130, 178);
            this.cbxDepartmanlar.Name = "cbxDepartmanlar";
            this.cbxDepartmanlar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDepartmanlar.Properties.PopupView = this.gridLookUpEdit1View;
            this.cbxDepartmanlar.Size = new System.Drawing.Size(183, 22);
            this.cbxDepartmanlar.TabIndex = 13;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 181);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 16);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Departman ID:";
            // 
            // txtPerTel
            // 
            this.txtPerTel.Location = new System.Drawing.Point(130, 150);
            this.txtPerTel.Name = "txtPerTel";
            this.txtPerTel.Size = new System.Drawing.Size(183, 22);
            this.txtPerTel.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(0, 156);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 16);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Personel Telefon:";
            // 
            // txtPerMail
            // 
            this.txtPerMail.Location = new System.Drawing.Point(130, 122);
            this.txtPerMail.Name = "txtPerMail";
            this.txtPerMail.Size = new System.Drawing.Size(183, 22);
            this.txtPerMail.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Personel Mail:";
            // 
            // btnPerGuncelle
            // 
            this.btnPerGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPerGuncelle.ImageOptions.Image")));
            this.btnPerGuncelle.Location = new System.Drawing.Point(130, 329);
            this.btnPerGuncelle.Name = "btnPerGuncelle";
            this.btnPerGuncelle.Size = new System.Drawing.Size(183, 35);
            this.btnPerGuncelle.TabIndex = 7;
            this.btnPerGuncelle.Text = "Güncelle";
            this.btnPerGuncelle.Click += new System.EventHandler(this.btnPerGuncelle_Click);
            // 
            // btnPerSil
            // 
            this.btnPerSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPerSil.ImageOptions.Image")));
            this.btnPerSil.Location = new System.Drawing.Point(130, 288);
            this.btnPerSil.Name = "btnPerSil";
            this.btnPerSil.Size = new System.Drawing.Size(183, 35);
            this.btnPerSil.TabIndex = 6;
            this.btnPerSil.Text = "Sil";
            this.btnPerSil.Click += new System.EventHandler(this.btnPerSil_Click);
            // 
            // btnPerEkle
            // 
            this.btnPerEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPerEkle.ImageOptions.Image")));
            this.btnPerEkle.Location = new System.Drawing.Point(130, 247);
            this.btnPerEkle.Name = "btnPerEkle";
            this.btnPerEkle.Size = new System.Drawing.Size(183, 35);
            this.btnPerEkle.TabIndex = 5;
            this.btnPerEkle.Text = "Ekle";
            this.btnPerEkle.Click += new System.EventHandler(this.btnPerEkle_Click);
            // 
            // btnPerListele
            // 
            this.btnPerListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPerListele.ImageOptions.Image")));
            this.btnPerListele.Location = new System.Drawing.Point(130, 206);
            this.btnPerListele.Name = "btnPerListele";
            this.btnPerListele.Size = new System.Drawing.Size(183, 35);
            this.btnPerListele.TabIndex = 4;
            this.btnPerListele.Text = "Listele";
            this.btnPerListele.Click += new System.EventHandler(this.btnPerListele_Click);
            // 
            // txtPerAdi
            // 
            this.txtPerAdi.Location = new System.Drawing.Point(130, 66);
            this.txtPerAdi.Name = "txtPerAdi";
            this.txtPerAdi.Size = new System.Drawing.Size(183, 22);
            this.txtPerAdi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Personel Adı:";
            // 
            // txtPerID
            // 
            this.txtPerID.Location = new System.Drawing.Point(130, 38);
            this.txtPerID.Name = "txtPerID";
            this.txtPerID.Size = new System.Drawing.Size(183, 22);
            this.txtPerID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Personel ID:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-18, -4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1168, 615);
            this.gridControl1.TabIndex = 2;
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
            // frmPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 606);
            this.Controls.Add(this.grpC_Per);
            this.Controls.Add(this.gridControl1);
            this.MaximumSize = new System.Drawing.Size(1538, 653);
            this.MinimumSize = new System.Drawing.Size(1538, 653);
            this.Name = "frmPersoneller";
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.frmPersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpC_Per)).EndInit();
            this.grpC_Per.ResumeLayout(false);
            this.grpC_Per.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartmanlar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpC_Per;
        private DevExpress.XtraEditors.SimpleButton btnPerGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnPerSil;
        private DevExpress.XtraEditors.SimpleButton btnPerEkle;
        private DevExpress.XtraEditors.SimpleButton btnPerListele;
        private DevExpress.XtraEditors.TextEdit txtPerAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPerID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtPerTel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPerMail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GridLookUpEdit cbxDepartmanlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtPerSoyadi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}