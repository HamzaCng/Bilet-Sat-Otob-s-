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
    public partial class BiletAlisGüzergah : Form
    {
        public BiletAlisGüzergah()
        {
            InitializeComponent();
        }
        Otobus_OtomasyonEntities db = new Otobus_OtomasyonEntities();

        public static string kalkisNoktasi;
        public static string varisNoktasi;
        public static DateTime gidisTarihi;

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

        private void BiletAlisGüzergah_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }

        private void comboVaris_SelectedIndexChanged(object sender, EventArgs e)
        {
                   
            if (comboKalkis.Text.Equals(comboVaris.Text) && comboVaris.SelectedIndex >= 0 && comboKalkis.SelectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Kalkış yeri varış yeri ile aynı olamaz...","Hatalı İşlem", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if(result == DialogResult.Cancel)
                {
                    comboVaris.SelectedIndex = -1;
                }
                else
                {
                    this.Show();
                }
            } 
            else if (!comboVaris.Text.Equals(comboKalkis.Text) && comboVaris.SelectedIndex >= 0 && comboKalkis.SelectedIndex>=0)
            {
                int x = 55, y = 150,index=1;

                for (int i = 0; i < 4; i++)
                {
                    for(int j = 0; j < 10; j++)
                    {
                        Button btn = new Button();
                        btn.Name = "btn" + index;
                        btn.Text = ""+index;
                        btn.Size = new Size(50, 50);
                        btn.Left = x;
                        btn.Top = y;
                        x += 55;
                        btn.BackColor = Color.Aqua;
                        btn.Click += new EventHandler(btn_Click);
                        this.Controls.Add(btn);
                        index++;
                    }
                    x = 60;
                    y += 60;
                    
                }
                
            }
            
        }
        bool color = true;
        public static int secilikoltok;
        private void btn_Click(Object Sender, EventArgs e)
        {
            Button btn = Sender as Button;
            
            if (color == true)
            {
                btn.BackColor = Color.GreenYellow;
                secilikoltok = Convert.ToInt16(btn.Text);
                color = false;
                label4.Text = secilikoltok.ToString();
            }
            else
            {
                btn.BackColor = Color.Aqua;
                color = true;               
            }
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BilgiGirisForm frm = new BilgiGirisForm();
            if (label4.Text != "")
            {
                kalkisNoktasi = comboKalkis.Text;
                varisNoktasi = comboVaris.Text;
                gidisTarihi = dateTimePicker1.Value;

                frm.Show();
                
            }
            else
                MessageBox.Show("Koltuk Seçiniz");
            //frm.SeferBilgileriAl(comboKalkis.Text,comboVaris.Text);
            
           

        }
        

        
    }
}
