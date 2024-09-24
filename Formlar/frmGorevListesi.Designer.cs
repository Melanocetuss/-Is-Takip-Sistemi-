namespace IsTakipSistemi.Formlar
{
    partial class frmGorevListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGorevListesi));
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblTopDep = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.lblAktifGorevler = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.lblPasifGorevler = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, -10);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(589, 613);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Goldenrod;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.lblTopDep);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(597, 2);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(300, 186);
            this.panelControl1.TabIndex = 3;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(193, 64);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(81, 73);
            this.pictureEdit1.TabIndex = 4;
            // 
            // lblTopDep
            // 
            this.lblTopDep.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopDep.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTopDep.Appearance.Options.UseFont = true;
            this.lblTopDep.Appearance.Options.UseForeColor = true;
            this.lblTopDep.Location = new System.Drawing.Point(49, 84);
            this.lblTopDep.Name = "lblTopDep";
            this.lblTopDep.Size = new System.Drawing.Size(18, 40);
            this.lblTopDep.TabIndex = 3;
            this.lblTopDep.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(173, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Toplam Departman";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(181)))), ((int)(((byte)(204)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.pictureEdit2);
            this.panelControl2.Controls.Add(this.lblAktifGorevler);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(903, 2);
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(300, 186);
            this.panelControl2.TabIndex = 4;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(159, 64);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(81, 73);
            this.pictureEdit2.TabIndex = 5;
            // 
            // lblAktifGorevler
            // 
            this.lblAktifGorevler.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAktifGorevler.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblAktifGorevler.Appearance.Options.UseFont = true;
            this.lblAktifGorevler.Appearance.Options.UseForeColor = true;
            this.lblAktifGorevler.Location = new System.Drawing.Point(42, 84);
            this.lblAktifGorevler.Name = "lblAktifGorevler";
            this.lblAktifGorevler.Size = new System.Drawing.Size(18, 40);
            this.lblAktifGorevler.TabIndex = 4;
            this.lblAktifGorevler.Text = "0";
            // 
            // labelControl2
            // 
            this.labelControl2.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(121, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Aktif Görevler";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.pictureEdit3);
            this.panelControl3.Controls.Add(this.lblPasifGorevler);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Location = new System.Drawing.Point(1209, 2);
            this.panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(300, 186);
            this.panelControl3.TabIndex = 5;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(153, 44);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(93, 93);
            this.pictureEdit3.TabIndex = 6;
            // 
            // lblPasifGorevler
            // 
            this.lblPasifGorevler.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasifGorevler.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblPasifGorevler.Appearance.Options.UseFont = true;
            this.lblPasifGorevler.Appearance.Options.UseForeColor = true;
            this.lblPasifGorevler.Location = new System.Drawing.Point(51, 74);
            this.lblPasifGorevler.Name = "lblPasifGorevler";
            this.lblPasifGorevler.Size = new System.Drawing.Size(18, 40);
            this.lblPasifGorevler.TabIndex = 5;
            this.lblPasifGorevler.Text = "0";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(123, 24);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Pasif Görevler";
            // 
            // chartControl1
            // 
            this.chartControl1.Location = new System.Drawing.Point(597, 204);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Durum";
            series1.SeriesID = 1;
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(911, 399);
            this.chartControl1.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(546, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(45, 29);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmGorevListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 606);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.MaximumSize = new System.Drawing.Size(1538, 653);
            this.MinimumSize = new System.Drawing.Size(1538, 653);
            this.Name = "frmGorevListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Listesi";
            this.Load += new System.EventHandler(this.frmGorevListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblAktifGorevler;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblPasifGorevler;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblTopDep;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}