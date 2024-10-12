using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProjeBilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        kayitCONTEXT db = new kayitCONTEXT();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbOtobus.Text)
            {
                case "SDTurizm": KoltukDoldur(8, false); break;
                case "GÜTruzim": KoltukDoldur(12, true); break;
                case "GSTurizm": KoltukDoldur(10, false); break;
                default:
                    break;
            }
        }
        void KoltukDoldur(int sira,bool arakBesliMi)
        {
            yavaslat:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = ctrl as Button;
                    if (btn.Text == "Kaydet")
                    {
                        continue;
                    }
                    else
                    {
                        this.Controls.Remove(ctrl);
                        goto yavaslat;
                    }
                }
            }
            int koltukNo = 1;
            for (int i = 0; i < sira; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i==5 && j >2)
                    {
                        continue;
                    }
                    if (arakBesliMi==true)
                    {
                        if (i!= sira- 1 && j==2)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (j == 2)
                        {
                            continue;
                        }
                    }
                    
                    Button koltuk = new Button();
                    koltuk.Height = koltuk.Width=40;
                    koltuk.Top = 30 + (i * 45);
                    koltuk.Left = 5 + (j * 45);
                    koltuk.Text=koltukNo.ToString();
                    koltuk.ContextMenuStrip = contextMenuStrip1;
                    koltukNo++;
                    koltuk.MouseDown += koltuk_MouseDown;
                    this.Controls.Add(koltuk);
                }
            }
        }
        Button tiklanan;
        private void koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbOtobus.SelectedIndex==-1 || cmbNerden.SelectedIndex==-1 || cmbNereye.SelectedIndex==-1)
            {
                MessageBox.Show("Öncelikli olarak gerekli alanları doldurmanız gerekmektedir!");
                return;
            }
                Kayit kay = new Kayit();

            DialogResult sonuc = kay.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                DataGridView dtv = new DataGridView();
                veriler veri = new veriler();
                veri.tc = kay.maskedTextBox4.Text;
                veri.name = kay.maskedTextBox1.Text;
                veri.surname = kay.maskedTextBox2.Text;
                veri.tel = kay.maskedTextBox3.Text;
                if (kay.rdbBay.Checked)
                {
                    veri.cinsiyet = "Bay";
                    tiklanan.BackColor = Color.Blue;
                }
                else if (kay.rdbBayan.Checked)
                {
                    veri.cinsiyet = "Bayan";
                    tiklanan.BackColor = Color.Pink;
                }
                veri.otobüs = cmbOtobus.Text;
                veri.nereden = cmbNerden.Text;
                veri.nereye = cmbNereye.Text;
                veri.tarih = dtpTarih.Text;
                veri.fiyat = nudFiyat.Value.ToString();

                db.yolcuverileri.Add(veri);
                db.SaveChanges();
                dataGridView1.DataSource = db.yolcuverileri.ToList();
            }
        }
    }
}
