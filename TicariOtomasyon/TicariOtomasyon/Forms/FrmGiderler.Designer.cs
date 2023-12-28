namespace TicariOtomasyon.Forms
{
    partial class FrmGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pictureEdit15 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.txtAcıklama = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel15 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtGiderFiyatı = new DevExpress.XtraEditors.TextEdit();
            this.txtGiderId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiderTarihi = new DevExpress.XtraEditors.DateEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit15.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcıklama.Properties)).BeginInit();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderFiyatı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(951, 492);
            this.gridControl1.TabIndex = 29;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pictureEdit15
            // 
            this.pictureEdit15.EditValue = ((object)(resources.GetObject("pictureEdit15.EditValue")));
            this.pictureEdit15.Location = new System.Drawing.Point(315, 152);
            this.pictureEdit15.Name = "pictureEdit15";
            this.pictureEdit15.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit15.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit15.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit15.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit15.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit15.Size = new System.Drawing.Size(47, 33);
            this.pictureEdit15.TabIndex = 2;
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl29.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl29.Appearance.Options.UseFont = true;
            this.labelControl29.Appearance.Options.UseForeColor = true;
            this.labelControl29.Location = new System.Drawing.Point(8, 63);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(45, 29);
            this.labelControl29.TabIndex = 1;
            this.labelControl29.Text = "595";
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl30.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl30.Appearance.Options.UseFont = true;
            this.labelControl30.Appearance.Options.UseForeColor = true;
            this.labelControl30.Location = new System.Drawing.Point(8, 3);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(142, 20);
            this.labelControl30.TabIndex = 0;
            this.labelControl30.Text = "GİDERLER TOPLAMI:\r\n";
            // 
            // txtAcıklama
            // 
            this.txtAcıklama.Location = new System.Drawing.Point(144, 66);
            this.txtAcıklama.Name = "txtAcıklama";
            this.txtAcıklama.Size = new System.Drawing.Size(234, 20);
            this.txtAcıklama.TabIndex = 32;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(48, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "GİDER AÇIKLAMA:";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.SeaGreen;
            this.panel15.Controls.Add(this.pictureEdit1);
            this.panel15.Controls.Add(this.labelControl30);
            this.panel15.Controls.Add(this.pictureEdit15);
            this.panel15.Controls.Add(this.labelControl29);
            this.panel15.Location = new System.Drawing.Point(48, 356);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(314, 131);
            this.panel15.TabIndex = 30;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtAcıklama);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.panel15);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.txtGiderFiyatı);
            this.groupControl1.Controls.Add(this.txtGiderId);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnListele);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtGiderTarihi);
            this.groupControl1.Location = new System.Drawing.Point(969, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(398, 492);
            this.groupControl1.TabIndex = 30;
            this.groupControl1.Text = "GİDER İŞLEMLERİ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(183, 144);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(160, 25);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "SÜTUNLARI TEMİZLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtGiderFiyatı
            // 
            this.txtGiderFiyatı.Location = new System.Drawing.Point(144, 118);
            this.txtGiderFiyatı.Name = "txtGiderFiyatı";
            this.txtGiderFiyatı.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtGiderFiyatı.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtGiderFiyatı.Properties.MaskSettings.Set("mask", "c");
            this.txtGiderFiyatı.Size = new System.Drawing.Size(236, 20);
            this.txtGiderFiyatı.TabIndex = 18;
            // 
            // txtGiderId
            // 
            this.txtGiderId.Enabled = false;
            this.txtGiderId.Location = new System.Drawing.Point(144, 40);
            this.txtGiderId.Name = "txtGiderId";
            this.txtGiderId.Size = new System.Drawing.Size(234, 20);
            this.txtGiderId.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(88, 43);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "GİDER İD:";
            // 
            // btnListele
            // 
            this.btnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.ImageOptions.Image")));
            this.btnListele.Location = new System.Drawing.Point(85, 307);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(258, 39);
            this.btnListele.TabIndex = 15;
            this.btnListele.Text = "VERİYİ YENİLE";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
            this.btnGüncelle.Location = new System.Drawing.Point(85, 265);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(258, 36);
            this.btnGüncelle.TabIndex = 14;
            this.btnGüncelle.Text = "GİDERİ GÜNCELLE";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(85, 221);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(258, 38);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "GİDER SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(85, 180);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(258, 35);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "GİDER EKLE";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(66, 121);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "GİDER FİYATI:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(64, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "GİDER TARİHİ:";
            // 
            // txtGiderTarihi
            // 
            this.txtGiderTarihi.EditValue = null;
            this.txtGiderTarihi.Location = new System.Drawing.Point(144, 92);
            this.txtGiderTarihi.Name = "txtGiderTarihi";
            this.txtGiderTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGiderTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGiderTarihi.Properties.DisplayFormat.FormatString = "";
            this.txtGiderTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtGiderTarihi.Properties.EditFormat.FormatString = "";
            this.txtGiderTarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtGiderTarihi.Properties.MaskSettings.Set("mask", "");
            this.txtGiderTarihi.Size = new System.Drawing.Size(236, 20);
            this.txtGiderTarihi.TabIndex = 5;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(235, 76);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(76, 50);
            this.pictureEdit1.TabIndex = 3;
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmGiderler";
            this.Text = "FrmGiderler";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit15.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcıklama.Properties)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderFiyatı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit15;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.TextEdit txtAcıklama;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel15;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtGiderFiyatı;
        private DevExpress.XtraEditors.TextEdit txtGiderId;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit txtGiderTarihi;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}