namespace TicariOtomasyon.Forms
{
    partial class FrmSiparisListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparisListesi));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtTarihi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSiparisFiyatı = new DevExpress.XtraEditors.TextEdit();
            this.txtSİparisId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPersonel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSiparisAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisFiyatı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSİparisId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1006, 514);
            this.gridControl1.TabIndex = 23;
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.richTextBox1);
            this.groupControl1.Controls.Add(this.txtTarihi);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtSiparisFiyatı);
            this.groupControl1.Controls.Add(this.txtSİparisId);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnListele);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtPersonel);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtSiparisAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1015, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(343, 514);
            this.groupControl1.TabIndex = 27;
            this.groupControl1.Text = "SİPARİŞ İŞLEMLERİ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(113, 136);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(199, 137);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // txtTarihi
            // 
            this.txtTarihi.Location = new System.Drawing.Point(113, 279);
            this.txtTarihi.Name = "txtTarihi";
            this.txtTarihi.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.txtTarihi.Properties.MaskSettings.Set("mask", "g");
            this.txtTarihi.Size = new System.Drawing.Size(199, 20);
            this.txtTarihi.TabIndex = 20;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(42, 65);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 13);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "SİPARİŞ ADI:";
            // 
            // txtSiparisFiyatı
            // 
            this.txtSiparisFiyatı.Location = new System.Drawing.Point(113, 318);
            this.txtSiparisFiyatı.Name = "txtSiparisFiyatı";
            this.txtSiparisFiyatı.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSiparisFiyatı.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSiparisFiyatı.Properties.MaskSettings.Set("mask", "c");
            this.txtSiparisFiyatı.Size = new System.Drawing.Size(199, 20);
            this.txtSiparisFiyatı.TabIndex = 18;
            // 
            // txtSİparisId
            // 
            this.txtSİparisId.Enabled = false;
            this.txtSİparisId.Location = new System.Drawing.Point(113, 29);
            this.txtSİparisId.Name = "txtSİparisId";
            this.txtSİparisId.Size = new System.Drawing.Size(199, 20);
            this.txtSİparisId.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(49, 32);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "SİPARİŞ İD:";
            // 
            // btnListele
            // 
            this.btnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.ImageOptions.Image")));
            this.btnListele.Location = new System.Drawing.Point(113, 469);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(133, 34);
            this.btnListele.TabIndex = 15;
            this.btnListele.Text = "VERİYİ YENİLE";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
            this.btnGüncelle.Location = new System.Drawing.Point(113, 429);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(133, 34);
            this.btnGüncelle.TabIndex = 14;
            this.btnGüncelle.Text = "SİPARİŞ GÜNCELLE";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(113, 389);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 34);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "SİPARİŞ SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(113, 349);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 34);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "SİPARİŞ KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 321);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "SİPARİŞ TUTARI:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 282);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "YAPILMA TARİHİ:";
            // 
            // txtPersonel
            // 
            this.txtPersonel.Location = new System.Drawing.Point(113, 99);
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.Size = new System.Drawing.Size(199, 20);
            this.txtPersonel.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "ALAN PERSONEL:";
            // 
            // txtSiparisAd
            // 
            this.txtSiparisAd.Location = new System.Drawing.Point(113, 62);
            this.txtSiparisAd.Name = "txtSiparisAd";
            this.txtSiparisAd.Size = new System.Drawing.Size(199, 20);
            this.txtSiparisAd.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 139);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "GEREKLİ DETAYLAR:";
            // 
            // FrmSiparisListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmSiparisListesi";
            this.Text = "Sipariş İşlemleri";
            this.Load += new System.EventHandler(this.FrmSiparisListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisFiyatı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSİparisId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtSiparisFiyatı;
        private DevExpress.XtraEditors.TextEdit txtSİparisId;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPersonel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSiparisAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTarihi;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}