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
    public partial class SeferKontrol : Form
    {
        public SeferKontrol()
        {
            InitializeComponent();
        }
        Otobus_OtomasyonEntities db = new Otobus_OtomasyonEntities();


        void ComboDoldur()
        {
            comboKalkis.DisplayMember = "ilAd";
            comboKalkis.ValueMember = "ilID";
            comboKalkis.DataSource = db.IlTablosu.ToList();
            comboKalkis.SelectedIndex = -1;

            comboVaris.DisplayMember = "ilAd";
            comboVaris.ValueMember = "ilID";
            comboVaris.DataSource = db.IlTablosu.ToList();
            comboVaris.SelectedIndex = -1;
        }

        void SecimListele()
        {
            dataGridView1.DataSource = null;
            var sefer = db.SeferBilgileri.Where(x => x.kalkisNoktasi.Contains(comboKalkis.Text) &&
            x.varisNoktasi.Contains(comboVaris.Text)).ToList();

            dataGridView1.DataSource = sefer;

        }
         void DefaultList()
        {
            var defList = db.SeferBilgileri.ToList();
            dataGridView1.DataSource = defList;
        }
            

        private void SeferKontrol_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            DefaultList();

        }

        private void btnSeferAra_Click(object sender, EventArgs e)
        {
            SecimListele(); 
        }
    }
}
