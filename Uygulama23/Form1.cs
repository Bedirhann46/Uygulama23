using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama23
{
    public partial class Form1 : Form
    {
        List<Sehirler> listSehirler = new List<Sehirler>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sehirler sehir = new Sehirler();
            sehir.Plaka = textBox1.Text;
            sehir.SehirAdi = textBox2.Text;
            listSehirler.Add(sehir);
            Bagla();
        }
        private void Bagla()
        {
            cbSehirler.DataSource = null;
            cbSehirler.DataSource = listSehirler;
            cbSehirler.DisplayMember = "SehirAdi";
            cbSehirler.ValueMember = "Plaka";
        }
    }
}
