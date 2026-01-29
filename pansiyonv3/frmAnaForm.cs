using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pansiyonv3
{
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr= new Form1();
            fr.Show();
            this.Hide();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmYeniMüsteri fr =new frmYeniMüsteri();
            fr.Show();
          
        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
           timer1.Start();
        }

        private void btnMüsteriler_Click(object sender, EventArgs e)
        {
            frmMusteriler fr =new frmMusteriler();
            fr.Show();
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gençay Pansiyon Kayıt Uygulaması / 2024 - İstanbul");
        }

        private void btnCikiss_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            frmOdalar fr = new frmOdalar();
            fr.Show();
        }
        // Tarih  ve saat program calisirken aktif olarak ilerlemeye devam eder
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            frmGelirGider fr = new frmGelirGider();
            fr.Show();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            frmStoklar fr = new frmStoklar();
            fr.Show();
        }

        private void btnMusteriMsj_Click(object sender, EventArgs e)
        {
            frmMesajlar fr=  new frmMesajlar();
            fr.Show();
        }
    }
}
