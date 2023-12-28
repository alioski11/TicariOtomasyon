namespace TicariOtomasyon.Forms
{
    partial class FrmSatısListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatısListesi));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditPersonel = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSatısFiyatı = new DevExpress.XtraEditors.TextEdit();
            this.txtSatılanUrunId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSatılanUrun = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarihi = new DevExpress.XtraEditors.DateEdit();
            this.lookUpEditCari = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatısFiyatı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatılanUrunId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatılanUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCari.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1006, 514);
            this.gridControl1.TabIndex = 22;
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
            this.groupControl1.Controls.Add(this.lookUpEditCari);
            this.groupControl1.Controls.Add(this.lookUpEditPersonel);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtSatısFiyatı);
            this.groupControl1.Controls.Add(this.txtSatılanUrunId);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnListele);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.txtAdet);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtSatılanUrun);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtTarihi);
            this.groupControl1.Location = new System.Drawing.Point(1015, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(343, 514);
            this.groupControl1.TabIndex = 26;
            this.groupControl1.Text = "Satış İşlemleri";
            // 
            // lookUpEditPersonel
            // 
            this.lookUpEditPersonel.Location = new System.Drawing.Point(113, 99);
            this.lookUpEditPersonel.Name = "lookUpEditPersonel";
            this.lookUpEditPersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPersonel.Properties.DisplayMember = "PERSONEL";
            this.lookUpEditPersonel.Properties.ValueMember = "ID";
            this.lookUpEditPersonel.Size = new System.Drawing.Size(199, 20);
            this.lookUpEditPersonel.TabIndex = 20;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(30, 65);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(77, 13);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "SATILAN ÜRÜN:";
            // 
            // txtSatısFiyatı
            // 
            this.txtSatısFiyatı.Location = new System.Drawing.Point(113, 209);
            this.txtSatısFiyatı.Name = "txtSatısFiyatı";
            this.txtSatısFiyatı.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSatısFiyatı.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSatısFiyatı.Properties.MaskSettings.Set("mask", "c");
            this.txtSatısFiyatı.Size = new System.Drawing.Size(199, 20);
            this.txtSatısFiyatı.TabIndex = 18;
            // 
            // txtSatılanUrunId
            // 
            this.txtSatılanUrunId.Enabled = false;
            this.txtSatılanUrunId.Location = new System.Drawing.Point(113, 29);
            this.txtSatılanUrunId.Name = "txtSatılanUrunId";
            this.txtSatılanUrunId.Size = new System.Drawing.Size(199, 20);
            this.txtSatılanUrunId.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(16, 32);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "SATILAN ÜRÜN İD:";
            // 
            // btnListele
            // 
            this.btnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.ImageOptions.Image")));
            this.btnListele.Location = new System.Drawing.Point(150, 440);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(133, 34);
            this.btnListele.TabIndex = 15;
            this.btnListele.Text = "VERİYİ YENİLE";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
            this.btnGüncelle.Location = new System.Drawing.Point(150, 388);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(133, 34);
            this.btnGüncelle.TabIndex = 14;
            this.btnGüncelle.Text = "SATIŞI GÜNCELLE";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(150, 338);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 34);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "SATIŞI SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(150, 289);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 34);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "SATIŞ YAP";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(113, 246);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(199, 20);
            this.txtAdet.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(38, 212);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "SATIŞ FİYATI:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(77, 249);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "ADET:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(68, 173);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "TARİHİ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(52, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "PERSONEL:";
            // 
            // txtSatılanUrun
            // 
            this.txtSatılanUrun.Location = new System.Drawing.Point(113, 62);
            this.txtSatılanUrun.Name = "txtSatılanUrun";
            this.txtSatılanUrun.Size = new System.Drawing.Size(199, 20);
            this.txtSatılanUrun.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(78, 139);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CARİ:";
            // 
            // txtTarihi
            // 
            this.txtTarihi.EditValue = null;
            this.txtTarihi.Location = new System.Drawing.Point(113, 170);
            this.txtTarihi.Name = "txtTarihi";
            this.txtTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarihi.Properties.DisplayFormat.FormatString = "";
            this.txtTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarihi.Properties.EditFormat.FormatString = "";
            this.txtTarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarihi.Properties.Mask.EditMask = "";
            this.txtTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTarihi.Size = new System.Drawing.Size(199, 20);
            this.txtTarihi.TabIndex = 5;
            // 
            // lookUpEditCari
            // 
            this.lookUpEditCari.Location = new System.Drawing.Point(113, 136);
            this.lookUpEditCari.Name = "lookUpEditCari";
            this.lookUpEditCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCari.Properties.DisplayMember = "CARİ";
            this.lookUpEditCari.Size = new System.Drawing.Size(199, 20);
            this.lookUpEditCari.TabIndex = 21;
            // 
            // FrmSatısListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmSatısListesi";
            this.Text = "Satış İşlemleri";
            this.Load += new System.EventHandler(this.FrmSatısListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatısFiyatı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatılanUrunId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatılanUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCari.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtSatılanUrunId;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtAdet;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSatılanUrun;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSatısFiyatı;
        private DevExpress.XtraEditors.DateEdit txtTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPersonel;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCari;
    }
}