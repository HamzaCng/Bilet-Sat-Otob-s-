using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobus_Otomasyon
{
    public partial class BilgiGirisForm : Form
    {
        public BilgiGirisForm()
        {
            InitializeComponent();
        }
        Otobus_OtomasyonEntities db = new Otobus_OtomasyonEntities();
       

        private void BilgiGirisForm_Load(object sender, EventArgs e)
        {
            txtKalkisYeri.Text = BiletAlisGüzergah.kalkisNoktasi;
            txtVarisyeri.Text = BiletAlisGüzergah.varisNoktasi;
            txtKoltukNo.Text = BiletAlisGüzergah.secilikoltok.ToString();
            dateTimePickerSeferBilgi.Value = BiletAlisGüzergah.gidisTarihi;

            TarifeTablosu trf = db.TarifeTablosu.Where(x => x.kalkisNoktasi == BiletAlisGüzergah.kalkisNoktasi 
            && x.varisNoktasi==BiletAlisGüzergah.varisNoktasi).FirstOrDefault();

            txtPlakaNo.Text = trf.plakaNo;
            txtMarka.Text = trf.marka;
            txtBiletFiyat.Text = trf.biletFiyati.ToString();

            //comboCinsiyet.Items.Add("Erkek");
            //comboCinsiyet.Items.Add("Kadın");



        }
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTc.Text != "" && txtTel.Text != "")
            {
                YolcuListesi yolcu = new YolcuListesi();
                yolcu.ad = txtAd.Text;
                yolcu.soyad = txtSoyad.Text;
                yolcu.tcNo = txtTc.Text;
                yolcu.cinsiyet = comboCinsiyet.Text;
                yolcu.telNo = txtTel.Text;

                db.YolcuListesi.Add(yolcu);
                db.SaveChanges();

                SeferBilgileri sfr = new SeferBilgileri();
                sfr.plakaNo = txtPlakaNo.Text;
                sfr.yolcuID = yolcu.yolcuID;
                sfr.marka = txtMarka.Text;
                sfr.kalkisNoktasi = txtKalkisYeri.Text;
                sfr.varisNoktasi = txtVarisyeri.Text;
                sfr.biletFiyati = Convert.ToDecimal(txtBiletFiyat.Text);
                sfr.koltukNo = Convert.ToInt16(txtKoltukNo.Text);
                sfr.gidisTarihi = dateTimePickerSeferBilgi.Value;

                db.SeferBilgileri.Add(sfr);
                db.SaveChanges();

                StringBuilder sb = new StringBuilder();
                sb.Append("Sayın :");
                sb.Append(txtAd.Text);
                sb.Append(" ");
                sb.AppendLine(txtSoyad.Text);
                sb.Append("Sefer Bilgisi :");
                sb.Append(txtKalkisYeri.Text);
                sb.Append(" ==>> ");
                sb.AppendLine(txtVarisyeri.Text);
                sb.Append("Bilet Fiyatı : ");
                sb.AppendLine(txtBiletFiyat.Text);

                MessageBox.Show(sb.ToString(),"İYİ YOLCULUKLAR....",MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurunuz...");
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            
            Form1 frmGiris = new Form1();            
            frmGiris.Show();
        }
    }
}
