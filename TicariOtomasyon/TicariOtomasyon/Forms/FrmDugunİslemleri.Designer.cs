namespace TicariOtomasyon.Forms
{
    partial class FrmDugunİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDugunİslemleri));
            this.lookUpEditPersonel = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDugunSatısFiyatı = new DevExpress.XtraEditors.TextEdit();
            this.txtDugunId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtDugunSahibiTelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDugunSahibi = new DevExpress.XtraEditors.TextEdit();
            this.txtDugunTarihi = new DevExpress.XtraEditors.DateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDugunTuru = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel15 = new System.Windows.Forms.Panel();
            this.pictureEdit15 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDugunSatısFiyatı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDugunId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDugunSahibiTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDugunSahibi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDugunTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDugunTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDugunTuru.Properties)).BeginInit();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit15.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEditPersonel
            // 
            this.lookUpEditPersonel.Location = new System.Drawing.Point(144, 196);
            this.lookUpEditPersonel.Name = "lookUpEditPersonel";
            this.lookUpEditPersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPersonel.Properties.DisplayMember = "PERSONEL";
            this.lookUpEditPersonel.Properties.ValueMember = "ID";
            this.lookUpEditPersonel.Size = new System.Drawing.Size(236, 20);
            this.lookUpEditPersonel.TabIndex = 20;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(62, 95);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(76, 13);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "DÜĞÜN SAHİBİ:";
            // 
            // txtDugunSatısFiyatı
            // 
            this.txtDugunSatısFiyatı.Location = new System.Drawing.Point(144, 170);
            this.txtDugunSatısFiyatı.Name = "txtDugunSatısFiyatı";
            this.txtDugunSatısFiyatı.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtDugunSatısFiyatı.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtDugunSatısFiyatı.Properties.MaskSettings.Set("mask", "c");
            this.txtDugunSatısFiyatı.Size = new System.Drawing.Size(236, 20);
            this.txtDugunSatısFiyatı.TabIndex = 18;
            // 
            // txtDugunId
            // 
            this.txtDugunId.Enabled = false;
            this.txtDugunId.Location = new System.Drawing.Point(144, 40);
            this.txtDugunId.Name = "txtDugunId";
            this.txtDugunId.Size = new System.Drawing.Size(234, 20);
            this.txtDugunId.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(85, 43);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "DÜĞÜN İD:";
            // 
            // btnListele
            // 
            this.btnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.ImageOptions.Image")));
            this.btnListele.Location = new System.Drawing.Point(85, 418);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(258, 39);
            this.btnListele.TabIndex = 15;
            this.btnListele.Text = "VERİYİ YENİLE";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
            this.btnGüncelle.Location = new System.Drawing.Point(85, 376);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(258, 36);
            this.btnGüncelle.TabIndex = 14;
            this.btnGüncelle.Text = "SATIŞI GÜNCELLE";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(85, 332);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(258, 38);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "SATIŞI SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(85, 291);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(258, 35);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "SATIŞ YAP";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtDugunSahibiTelefon
            // 
            this.txtDugunSahibiTelefon.Location = new System.Drawing.Point(144, 118);
            this.txtDugunSahibiTelefon.Name = "txtDugunSahibiTelefon";
            this.txtDugunSahibiTelefon.Size = new System.Drawing.Size(234, 20);
            this.txtDugunSahibiTelefon.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(63, 173);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "DÜĞÜN FİYATI:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 121);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(123, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "DÜĞÜN SAHİBİ TELEFON:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(61, 147);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "DÜĞÜN TARİHİ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(47, 199);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "SATAN PERSONEL:";
            // 
            // txtDugunSahibi
            // 
            this.txtDugunSahibi.Location = new System.Drawing.Point(144, 92);
            this.txtDugunSahibi.Name = "txtDugunSahibi";
            this.txtDugunSahibi.Size = new System.Drawing.Size(234, 20);
            this.txtDugunSahibi.TabIndex = 1;
            // 
            // txtDugunTarihi
            // 
            this.txtDugunTarihi.EditValue = null;
            this.txtDugunTarihi.Location = new System.Drawing.Point(144, 144);
            this.txtDugunTarihi.Name = "txtDugunTarihi";
            this.txtDugunTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDugunTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDugunTarihi.Properties.DisplayFormat.FormatString = "";
            this.txtDugunTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDugunTarihi.Properties.EditFormat.FormatString = "";
            this.txtDugunTarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDugunTarihi.Properties.MaskSettings.Set("mask", "");
            this.txtDugunTarihi.Size = new System.Drawing.Size(236, 20);
            this.txtDugunTarihi.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDugunTuru);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.panel15);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.lookUpEditPersonel);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtDugunSatısFiyatı);
            this.groupControl1.Controls.Add(this.txtDugunId);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnListele);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.txtDugunSahibiTelefon);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtDugunSahibi);
            this.groupControl1.Controls.Add(this.txtDugunTarihi);
            this.groupControl1.Location = new System.Drawing.Point(960, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(399, 697);
            this.groupControl1.TabIndex = 28;
            this.groupControl1.Text = "DÜĞÜN İŞLEMLERİ";
            // 
            // txtDugunTuru
            // 
            this.txtDugunTuru.Location = new System.Drawing.Point(144, 66);
            this.txtDugunTuru.Name = "txtDugunTuru";
            this.txtDugunTuru.Size = new System.Drawing.Size(234, 20);
            this.txtDugunTuru.TabIndex = 32;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(69, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "DÜĞÜN TÜRÜ:";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Black;
            this.panel15.Controls.Add(this.pictureEdit15);
            this.panel15.Controls.Add(this.labelControl29);
            this.panel15.Controls.Add(this.labelControl30);
            this.panel15.Location = new System.Drawing.Point(15, 504);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(365, 188);
            this.panel15.TabIndex = 30;
            // 
            // pictureEdit15
            // 
            this.pictureEdit15.EditValue = ((object)(resources.GetObject("pictureEdit15.EditValue")));
            this.pictureEdit15.Location = new System.Drawing.Point(286, 135);
            this.pictureEdit15.Name = "pictureEdit15";
            this.pictureEdit15.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit15.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit15.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit15.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit15.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit15.Size = new System.Drawing.Size(76, 50);
            this.pictureEdit15.TabIndex = 2;
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl29.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl29.Appearance.Options.UseFont = true;
            this.labelControl29.Appearance.Options.UseForeColor = true;
            this.labelControl29.Location = new System.Drawing.Point(14, 80);
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
            this.labelControl30.Location = new System.Drawing.Point(3, 3);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(335, 40);
            this.labelControl30.TabIndex = 0;
            this.labelControl30.Text = "BUGÜNE KADAR YAPILAN DÜĞÜNLERİN TOPLAM\r\nGELİRİ:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(188, 222);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(160, 25);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "SÜTUNLARI TEMİZLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(951, 697);
            this.gridControl1.TabIndex = 27;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // FrmDugunİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmDugunİslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Düğün İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDugunİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDugunSatısFiyatı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDugunId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDugunSahibiTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDugunSahibi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDugunTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDugunTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDugunTuru.Properties)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit15.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPersonel;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtDugunSatısFiyatı;
        private DevExpress.XtraEditors.TextEdit txtDugunId;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtDugunSahibiTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDugunSahibi;
        private DevExpress.XtraEditors.DateEdit txtDugunTarihi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel15;
        private DevExpress.XtraEditors.PictureEdit pictureEdit15;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.TextEdit txtDugunTuru;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}