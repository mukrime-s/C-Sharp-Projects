
namespace TeknikServis.Formlar
{
    partial class frmUrunListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunListesi));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtStok = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSatisFiyati = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAlisFiyati = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.lblUrunAdi = new DevExpress.XtraEditors.LabelControl();
            this.btListele = new DevExpress.XtraEditors.SimpleButton();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1016, 550);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.btListele);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtStok);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtSatisFiyati);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtAlisFiyati);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtMarka);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtUrunAd);
            this.groupControl1.Controls.Add(this.lblUrunAdi);
            this.groupControl1.Location = new System.Drawing.Point(1022, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(286, 519);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Ürün İslemleri";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.btnGüncelle.Location = new System.Drawing.Point(87, 380);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(185, 29);
            this.btnGüncelle.TabIndex = 17;
            this.btnGüncelle.Text = "Güncelle";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(87, 345);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(185, 29);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage1")));
            this.btnKaydet.Location = new System.Drawing.Point(87, 277);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(185, 29);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(87, 240);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(184, 22);
            this.lookUpEdit1.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(4, 240);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 16);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Kategori";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(87, 205);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(184, 22);
            this.txtStok.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(4, 208);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 16);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Stok";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(87, 170);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(184, 22);
            this.txtSatisFiyati.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(4, 173);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 16);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Satış Fiyatı";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(87, 136);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(184, 22);
            this.txtAlisFiyati.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(4, 139);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Alış Fiyatı";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(87, 108);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(184, 22);
            this.txtMarka.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 111);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Marka";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(87, 74);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(184, 22);
            this.txtUrunAd.TabIndex = 4;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.Location = new System.Drawing.Point(4, 77);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(49, 16);
            this.lblUrunAdi.TabIndex = 3;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // btListele
            // 
            this.btListele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btListele.Location = new System.Drawing.Point(86, 312);
            this.btListele.Name = "btListele";
            this.btListele.Size = new System.Drawing.Size(185, 29);
            this.btListele.TabIndex = 18;
            this.btListele.Text = "Listele";
            this.btListele.Click += new System.EventHandler(this.btListele_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(87, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(184, 22);
            this.txtID.TabIndex = 20;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(4, 45);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 16);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Ürün ID";
            // 
            // frmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1368, 533);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmUrunListesi";
            this.Text = "frmUrunListesi";
            this.Load += new System.EventHandler(this.frmUrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtStok;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyati;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyati;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMarka;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUrunAd;
        private DevExpress.XtraEditors.LabelControl lblUrunAdi;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btListele;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}