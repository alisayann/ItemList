using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemirbaşListeleme
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E5JB5ET\\SQLEXPRESS;Initial Catalog=tasinirMal;Integrated Security=True");

        private void FrmKayit_Load(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_PersonelBilgi (Personelad,Personelsifre,Personelgorev) values(@a1,@a2,@a3) ", baglanti);
            komut.Parameters.AddWithValue("@a1", txtKayitKullanici.Text);
            komut.Parameters.AddWithValue("@a2",txtKayitSifre.Text);
            komut.Parameters.AddWithValue("@a3", txtDepartman.Text);
            komut.ExecuteNonQuery();
            FrmBaslangic fr = new FrmBaslangic();
            fr.Show();
            this.Hide();
            MessageBox.Show("Kayıt Olundu");
            

            baglanti.Close();
        }
    }
}
