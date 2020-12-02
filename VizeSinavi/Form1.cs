using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeSinavi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        CepheOtobus cepheOtobus = new CepheOtobus();// Cephe tasarım deseni için nesne oluşturduk.
       
        public bool Kontrol(string musteriAdi,string musteriTC)
        {
            if (string.IsNullOrEmpty(musteriAdi)|| string.IsNullOrEmpty(musteriTC))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Kontrol(textMusteri.Text, textTC.Text))
            {
                cepheOtobus.Otobus_2_1_YerAyirt(textMusteri.Text, textTC.Text, radioButton1.Checked, "2+1 Otobüs");
                MessageBox.Show("2+1 otobüsten yer ayırtıldı.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Kontrol(textMusteri.Text, textTC.Text))
            {
                cepheOtobus.Otobus_2_2_YerAyirt(textMusteri.Text, textTC.Text, radioButton1.Checked, "2+2 Otobüs");
                MessageBox.Show("2+2 otobüsten yer ayırtıldı.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Kontrol(textMusteri.Text, textTC.Text))
            {
                cepheOtobus.Deluxe_YerAyirt(textMusteri.Text,textTC.Text,radioButton1.Checked,"Deluxe Otobüs");
                MessageBox.Show("Deluxe otobüsten yer ayırtıldı.");
            }
        }

        
    }
}
