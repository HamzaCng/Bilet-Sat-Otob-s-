﻿namespace Otobus_Otomasyon
{
    partial class SeferKontrol
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
            this.comboKalkis = new System.Windows.Forms.ComboBox();
            this.comboVaris = new System.Windows.Forms.ComboBox();
            this.btnSeferAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboKalkis
            // 
            this.comboKalkis.FormattingEnabled = true;
            this.comboKalkis.Location = new System.Drawing.Point(97, 30);
            this.comboKalkis.Name = "comboKalkis";
            this.comboKalkis.Size = new System.Drawing.Size(121, 21);
            this.comboKalkis.TabIndex = 0;
            // 
            // comboVaris
            // 
            this.comboVaris.FormattingEnabled = true;
            this.comboVaris.Location = new System.Drawing.Point(334, 30);
            this.comboVaris.Name = "comboVaris";
            this.comboVaris.Size = new System.Drawing.Size(121, 21);
            this.comboVaris.TabIndex = 0;
            // 
            // btnSeferAra
            // 
            this.btnSeferAra.Location = new System.Drawing.Point(512, 33);
            this.btnSeferAra.Name = "btnSeferAra";
            this.btnSeferAra.Size = new System.Drawing.Size(111, 23);
            this.btnSeferAra.TabIndex = 1;
            this.btnSeferAra.Text = "Sefer Ara";
            this.btnSeferAra.UseVisualStyleBackColor = true;
            this.btnSeferAra.Click += new System.EventHandler(this.btnSeferAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kalkış Noktası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Varış Noktası :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 222);
            this.dataGridView1.TabIndex = 3;
            // 
            // SeferKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 357);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeferAra);
            this.Controls.Add(this.comboVaris);
            this.Controls.Add(this.comboKalkis);
            this.Name = "SeferKontrol";
            this.Text = "SeferKontrol";
            this.Load += new System.EventHandler(this.SeferKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboKalkis;
        private System.Windows.Forms.ComboBox comboVaris;
        private System.Windows.Forms.Button btnSeferAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}