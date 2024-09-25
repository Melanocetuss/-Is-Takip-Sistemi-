namespace IsTakipSistemi.Formlar
{
    partial class frmDepartmanEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmanEkle));
            this.grpCDep = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDepSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDepEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtDepAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDepID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpCDep)).BeginInit();
            this.grpCDep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCDep
            // 
            this.grpCDep.Controls.Add(this.btnKapat);
            this.grpCDep.Controls.Add(this.btnDepSil);
            this.grpCDep.Controls.Add(this.btnDepEkle);
            this.grpCDep.Controls.Add(this.txtDepAdi);
            this.grpCDep.Controls.Add(this.labelControl2);
            this.grpCDep.Controls.Add(this.txtDepID);
            this.grpCDep.Controls.Add(this.labelControl1);
            this.grpCDep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCDep.Location = new System.Drawing.Point(0, 0);
            this.grpCDep.Name = "grpCDep";
            this.grpCDep.Size = new System.Drawing.Size(369, 297);
            this.grpCDep.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(130, 176);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(183, 35);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnDepSil
            // 
            this.btnDepSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDepSil.ImageOptions.Image")));
            this.btnDepSil.Location = new System.Drawing.Point(130, 135);
            this.btnDepSil.Name = "btnDepSil";
            this.btnDepSil.Size = new System.Drawing.Size(183, 35);
            this.btnDepSil.TabIndex = 6;
            this.btnDepSil.Text = "Sil";
            this.btnDepSil.Click += new System.EventHandler(this.btnDepSil_Click);
            // 
            // btnDepEkle
            // 
            this.btnDepEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDepEkle.ImageOptions.Image")));
            this.btnDepEkle.Location = new System.Drawing.Point(130, 94);
            this.btnDepEkle.Name = "btnDepEkle";
            this.btnDepEkle.Size = new System.Drawing.Size(183, 35);
            this.btnDepEkle.TabIndex = 5;
            this.btnDepEkle.Text = "Ekle";
            this.btnDepEkle.Click += new System.EventHandler(this.btnDepEkle_Click);
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
            // frmDepartmanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 297);
            this.Controls.Add(this.grpCDep);
            this.Name = "frmDepartmanEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDepartmanEkle";
            ((System.ComponentModel.ISupportInitialize)(this.grpCDep)).EndInit();
            this.grpCDep.ResumeLayout(false);
            this.grpCDep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCDep;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnDepSil;
        private DevExpress.XtraEditors.SimpleButton btnDepEkle;
        private DevExpress.XtraEditors.TextEdit txtDepAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDepID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}