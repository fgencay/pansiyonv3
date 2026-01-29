using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace pansiyonv3
{
    public partial class frmGelirGider : Form
    {
        public frmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=FEYZA-LENOVO\\SQLEXPRESS;Initial Catalog=GencayPansiyon;Integrated Security=True");

        private void frmGelirGider_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();
            //gıda

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblAlınanUrunler1.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();

            //icecekler

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(Icecekler) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblAlınanUrunler2.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();

            //atistirmaliklar

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select sum(Cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblAlınanUrunler3.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            //elektrik
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblFaturalar1.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();

            //su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblFaturalar2.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();

            //internet
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select sum(Internet) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblFaturalar3.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();

           
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            lblPersonelMaas.Text = (personel * 25000).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(lblKasaToplam.Text) - (Convert.ToInt32(lblPersonelMaas.Text) + Convert.ToInt32(lblAlınanUrunler1.Text) + Convert.ToInt32(lblAlınanUrunler2.Text) + Convert.ToInt32(lblAlınanUrunler3.Text) +
                Convert.ToInt32(lblFaturalar1.Text) + Convert.ToInt32(lblFaturalar2.Text) + Convert.ToInt16(lblFaturalar3.Text));
            lblSonuc.Text = sonuc.ToString();
        }
    }
}
