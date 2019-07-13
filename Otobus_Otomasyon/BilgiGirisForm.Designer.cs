namespace Otobus_Otomasyon
{
    partial class BilgiGirisForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOnay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerSeferBilgi = new System.Windows.Forms.DateTimePicker();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtPlakaNo = new System.Windows.Forms.TextBox();
            this.txtBiletFiyat = new System.Windows.Forms.TextBox();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.txtVarisyeri = new System.Windows.Forms.TextBox();
            this.txtKalkisYeri = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.btnOnay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboCinsiyet);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yolcu Bilgileri";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(172, 231);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(120, 38);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "VAZGEÇ";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(38, 231);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(120, 38);
            this.btnOnay.TabIndex = 3;
            this.btnOnay.Text = "ONAYLA";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefon No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "TC Kimlik No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadınız :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adınız :";
            // 
            // comboCinsiyet
            // 
            this.comboCinsiyet.FormattingEnabled = true;
            this.comboCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Bayan"});
            this.comboCinsiyet.Location = new System.Drawing.Point(146, 99);
            this.comboCinsiyet.Name = "comboCinsiyet";
            this.comboCinsiyet.Size = new System.Drawing.Size(146, 21);
            this.comboCinsiyet.TabIndex = 1;
            this.comboCinsiyet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(146, 152);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(146, 20);
            this.txtTel.TabIndex = 0;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(146, 126);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(146, 20);
            this.txtTc.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(146, 72);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(146, 20);
            this.txtSoyad.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(146, 46);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(146, 20);
            this.txtAd.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateTimePickerSeferBilgi);
            this.groupBox2.Controls.Add(this.txtMarka);
            this.groupBox2.Controls.Add(this.txtPlakaNo);
            this.groupBox2.Controls.Add(this.txtBiletFiyat);
            this.groupBox2.Controls.Add(this.txtKoltukNo);
            this.groupBox2.Controls.Add(this.txtVarisyeri);
            this.groupBox2.Controls.Add(this.txtKalkisYeri);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(380, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sefer Bilgileri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Gidiş Tarihi :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Marka :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Plaka No :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bilet Fiyatı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Koltuk No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Varış Yeri :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kalkış Yeri :";
            // 
            // dateTimePickerSeferBilgi
            // 
            this.dateTimePickerSeferBilgi.Location = new System.Drawing.Point(138, 180);
            this.dateTimePickerSeferBilgi.Name = "dateTimePickerSeferBilgi";
            this.dateTimePickerSeferBilgi.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerSeferBilgi.TabIndex = 1;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(142, 154);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(146, 20);
            this.txtMarka.TabIndex = 0;
            // 
            // txtPlakaNo
            // 
            this.txtPlakaNo.Location = new System.Drawing.Point(142, 128);
            this.txtPlakaNo.Name = "txtPlakaNo";
            this.txtPlakaNo.Size = new System.Drawing.Size(146, 20);
            this.txtPlakaNo.TabIndex = 0;
            // 
            // txtBiletFiyat
            // 
            this.txtBiletFiyat.Location = new System.Drawing.Point(138, 248);
            this.txtBiletFiyat.Name = "txtBiletFiyat";
            this.txtBiletFiyat.Size = new System.Drawing.Size(146, 20);
            this.txtBiletFiyat.TabIndex = 0;
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Location = new System.Drawing.Point(142, 101);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(146, 20);
            this.txtKoltukNo.TabIndex = 0;
            // 
            // txtVarisyeri
            // 
            this.txtVarisyeri.Location = new System.Drawing.Point(142, 74);
            this.txtVarisyeri.Name = "txtVarisyeri";
            this.txtVarisyeri.Size = new System.Drawing.Size(146, 20);
            this.txtVarisyeri.TabIndex = 0;
            // 
            // txtKalkisYeri
            // 
            this.txtKalkisYeri.Location = new System.Drawing.Point(142, 48);
            this.txtKalkisYeri.Name = "txtKalkisYeri";
            this.txtKalkisYeri.Size = new System.Drawing.Size(146, 20);
            this.txtKalkisYeri.TabIndex = 0;
            // 
            // BilgiGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BilgiGirisForm";
            this.Text = "BilgiGirisForm";
            this.Load += new System.EventHandler(this.BilgiGirisForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboCinsiyet;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerSeferBilgi;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtPlakaNo;
        private System.Windows.Forms.TextBox txtBiletFiyat;
        private System.Windows.Forms.TextBox txtKoltukNo;
        private System.Windows.Forms.TextBox txtVarisyeri;
        private System.Windows.Forms.TextBox txtKalkisYeri;
    }
}