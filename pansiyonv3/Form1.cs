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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=FEYZA-LENOVO\\SQLEXPRESS;Initial Catalog=GencayPansiyon;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text== "feyza" && txtSifre.Text== "123")
            {
                frmAnaForm frm = new frmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalıdır!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
