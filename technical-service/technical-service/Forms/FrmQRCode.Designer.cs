
namespace technical_service.Forms
{
    partial class FrmQRCode
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnQROlustur = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(303, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(178, 158);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 20);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "SERİ NO";
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(303, 159);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSeriNo.Properties.Appearance.Options.UseBackColor = true;
            this.txtSeriNo.Properties.Mask.EditMask = "AAAAA";
            this.txtSeriNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSeriNo.Size = new System.Drawing.Size(181, 22);
            this.txtSeriNo.TabIndex = 9;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(303, 266);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(181, 141);
            this.pictureEdit1.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(178, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(592, 36);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "SERİ NO İÇİN QR KOD OLUŞTURMA";
            // 
            // btnQROlustur
            // 
            this.btnQROlustur.Location = new System.Drawing.Point(303, 209);
            this.btnQROlustur.Name = "btnQROlustur";
            this.btnQROlustur.Size = new System.Drawing.Size(127, 40);
            this.btnQROlustur.TabIndex = 6;
            this.btnQROlustur.Text = "QR OLUŞTUR";
            this.btnQROlustur.Click += new System.EventHandler(this.btnQROlustur_Click);
            // 
            // FrmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1000, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnQROlustur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQRCode";
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnQROlustur;
    }
}