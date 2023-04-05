namespace _3.HaftaOdev
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tctOgrenciNo = new System.Windows.Forms.TextBox();
            this.Algoritmalar = new System.Windows.Forms.GroupBox();
            this.radiobtnVigenere = new System.Windows.Forms.RadioButton();
            this.radiobtnCaesar = new System.Windows.Forms.RadioButton();
            this.SifrelemeDesifreleme = new System.Windows.Forms.GroupBox();
            this.radiobtnDesifreleme = new System.Windows.Forms.RadioButton();
            this.radiobtnSifreleme = new System.Windows.Forms.RadioButton();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSifrelemeDesifreleme = new System.Windows.Forms.Button();
            this.lblSifrelenmisDesifrelenmisMetin = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.Algoritmalar.SuspendLayout();
            this.SifrelemeDesifreleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numarası";
            // 
            // tctOgrenciNo
            // 
            this.tctOgrenciNo.Location = new System.Drawing.Point(233, 34);
            this.tctOgrenciNo.MaxLength = 8;
            this.tctOgrenciNo.Name = "tctOgrenciNo";
            this.tctOgrenciNo.Size = new System.Drawing.Size(100, 22);
            this.tctOgrenciNo.TabIndex = 1;
            this.tctOgrenciNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tctOgrenciNo_KeyPress);
            // 
            // Algoritmalar
            // 
            this.Algoritmalar.Controls.Add(this.radiobtnVigenere);
            this.Algoritmalar.Controls.Add(this.radiobtnCaesar);
            this.Algoritmalar.Location = new System.Drawing.Point(114, 154);
            this.Algoritmalar.Name = "Algoritmalar";
            this.Algoritmalar.Size = new System.Drawing.Size(245, 149);
            this.Algoritmalar.TabIndex = 2;
            this.Algoritmalar.TabStop = false;
            this.Algoritmalar.Text = "Algoritmalar";
            // 
            // radiobtnVigenere
            // 
            this.radiobtnVigenere.AutoSize = true;
            this.radiobtnVigenere.Location = new System.Drawing.Point(18, 81);
            this.radiobtnVigenere.Name = "radiobtnVigenere";
            this.radiobtnVigenere.Size = new System.Drawing.Size(125, 20);
            this.radiobtnVigenere.TabIndex = 1;
            this.radiobtnVigenere.TabStop = true;
            this.radiobtnVigenere.Text = "Vigenère Cipher";
            this.radiobtnVigenere.UseVisualStyleBackColor = true;
            // 
            // radiobtnCaesar
            // 
            this.radiobtnCaesar.AutoSize = true;
            this.radiobtnCaesar.Location = new System.Drawing.Point(18, 43);
            this.radiobtnCaesar.Name = "radiobtnCaesar";
            this.radiobtnCaesar.Size = new System.Drawing.Size(114, 20);
            this.radiobtnCaesar.TabIndex = 0;
            this.radiobtnCaesar.TabStop = true;
            this.radiobtnCaesar.Text = "Caesar Cipher";
            this.radiobtnCaesar.UseVisualStyleBackColor = true;
            // 
            // SifrelemeDesifreleme
            // 
            this.SifrelemeDesifreleme.Controls.Add(this.radiobtnDesifreleme);
            this.SifrelemeDesifreleme.Controls.Add(this.radiobtnSifreleme);
            this.SifrelemeDesifreleme.Location = new System.Drawing.Point(410, 170);
            this.SifrelemeDesifreleme.Name = "SifrelemeDesifreleme";
            this.SifrelemeDesifreleme.Size = new System.Drawing.Size(247, 133);
            this.SifrelemeDesifreleme.TabIndex = 3;
            this.SifrelemeDesifreleme.TabStop = false;
            this.SifrelemeDesifreleme.Text = "Şifreleme /Deşifreleme";
            // 
            // radiobtnDesifreleme
            // 
            this.radiobtnDesifreleme.AutoSize = true;
            this.radiobtnDesifreleme.Location = new System.Drawing.Point(16, 65);
            this.radiobtnDesifreleme.Name = "radiobtnDesifreleme";
            this.radiobtnDesifreleme.Size = new System.Drawing.Size(101, 20);
            this.radiobtnDesifreleme.TabIndex = 1;
            this.radiobtnDesifreleme.TabStop = true;
            this.radiobtnDesifreleme.Text = "Deşifreleme";
            this.radiobtnDesifreleme.UseVisualStyleBackColor = true;
            // 
            // radiobtnSifreleme
            // 
            this.radiobtnSifreleme.AutoSize = true;
            this.radiobtnSifreleme.Location = new System.Drawing.Point(16, 27);
            this.radiobtnSifreleme.Name = "radiobtnSifreleme";
            this.radiobtnSifreleme.Size = new System.Drawing.Size(85, 20);
            this.radiobtnSifreleme.TabIndex = 0;
            this.radiobtnSifreleme.TabStop = true;
            this.radiobtnSifreleme.Text = "Şifreleme";
            this.radiobtnSifreleme.UseVisualStyleBackColor = true;
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(114, 106);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(543, 22);
            this.txtMetin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifrelenecek/Şifresi Çözülecek Metin:";
            // 
            // btnSifrelemeDesifreleme
            // 
            this.btnSifrelemeDesifreleme.Location = new System.Drawing.Point(616, 337);
            this.btnSifrelemeDesifreleme.Name = "btnSifrelemeDesifreleme";
            this.btnSifrelemeDesifreleme.Size = new System.Drawing.Size(119, 40);
            this.btnSifrelemeDesifreleme.TabIndex = 6;
            this.btnSifrelemeDesifreleme.Text = "Şifrele/Deşifrele";
            this.btnSifrelemeDesifreleme.UseVisualStyleBackColor = true;
            this.btnSifrelemeDesifreleme.Click += new System.EventHandler(this.btnSifrelemeDesifreleme_Click);
            // 
            // lblSifrelenmisDesifrelenmisMetin
            // 
            this.lblSifrelenmisDesifrelenmisMetin.AutoSize = true;
            this.lblSifrelenmisDesifrelenmisMetin.Location = new System.Drawing.Point(117, 387);
            this.lblSifrelenmisDesifrelenmisMetin.Name = "lblSifrelenmisDesifrelenmisMetin";
            this.lblSifrelenmisDesifrelenmisMetin.Size = new System.Drawing.Size(233, 16);
            this.lblSifrelenmisDesifrelenmisMetin.TabIndex = 7;
            this.lblSifrelenmisDesifrelenmisMetin.Text = "Şifrelenmiş ya da Deşifrelenmiş Metin:";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(613, 40);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(193, 16);
            this.lblSkor.TabIndex = 9;
            this.lblSkor.Text = "Skorunuz burada yazdırılmalıdır";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 486);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.lblSifrelenmisDesifrelenmisMetin);
            this.Controls.Add(this.btnSifrelemeDesifreleme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.SifrelemeDesifreleme);
            this.Controls.Add(this.Algoritmalar);
            this.Controls.Add(this.tctOgrenciNo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "App-3";
            this.Algoritmalar.ResumeLayout(false);
            this.Algoritmalar.PerformLayout();
            this.SifrelemeDesifreleme.ResumeLayout(false);
            this.SifrelemeDesifreleme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tctOgrenciNo;
        private System.Windows.Forms.GroupBox Algoritmalar;
        private System.Windows.Forms.RadioButton radiobtnVigenere;
        private System.Windows.Forms.RadioButton radiobtnCaesar;
        private System.Windows.Forms.GroupBox SifrelemeDesifreleme;
        private System.Windows.Forms.RadioButton radiobtnDesifreleme;
        private System.Windows.Forms.RadioButton radiobtnSifreleme;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSifrelemeDesifreleme;
        private System.Windows.Forms.Label lblSifrelenmisDesifrelenmisMetin;
        private System.Windows.Forms.Label lblSkor;
    }
}

