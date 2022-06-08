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
    public partial class FrmMalList : Form
    {
        public FrmMalList()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E5JB5ET\\SQLEXPRESS;Initial Catalog=tasinirMal;Integrated Security=True");

        public int toplam=0;
        public int tutar=0;
        
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            labelTarih.Text = DateTime.Now.ToString();
            label1.Text = Convert.ToString(numericUpDown1.Value);
            label2.Text = Convert.ToString(numericUpDown2.Value);
            label3.Text = Convert.ToString(numericUpDown3.Value);
            label4.Text = Convert.ToString(numericUpDown4.Value);
            label5.Text = Convert.ToString(numericUpDown5.Value);
            label6.Text = Convert.ToString(numericUpDown6.Value);
            label7.Text = Convert.ToString(numericUpDown7.Value);
            label8.Text = Convert.ToString(numericUpDown8.Value);
            label9.Text = Convert.ToString(numericUpDown9.Value);
            label10.Text = Convert.ToString(numericUpDown10.Value);
            label11.Text = Convert.ToString(numericUpDown11.Value);
            label12.Text = Convert.ToString(numericUpDown12.Value);
            label13.Text = Convert.ToString(numericUpDown13.Value);
            label14.Text = Convert.ToString(numericUpDown14.Value);
            label15.Text = Convert.ToString(numericUpDown15.Value);
            label16.Text = Convert.ToString(numericUpDown16.Value);
            label17.Text = Convert.ToString(numericUpDown17.Value);
            label18.Text = Convert.ToString(numericUpDown18.Value);
            label19.Text = Convert.ToString(numericUpDown19.Value);
            label20.Text = Convert.ToString(numericUpDown20.Value);
            label21.Text = Convert.ToString(numericUpDown21.Value);
            label22.Text = Convert.ToString(numericUpDown22.Value);
            label23.Text = Convert.ToString(numericUpDown23.Value);
            if (numericUpDown1.Value > 0)
            {
                toplam += Convert.ToInt16(LblBilgisayarFiyat.Text) * Convert.ToInt16(numericUpDown1.Value);
            }
            if (numericUpDown2.Value > 0)
            {
                toplam += Convert.ToInt16(LblCalismaMasasiFiyat.Text) * Convert.ToInt16(numericUpDown2.Value);
            }
            if (numericUpDown3.Value > 0)
            {
                toplam += Convert.ToInt16(LblSandalyeFiyat.Text) * Convert.ToInt16(numericUpDown3.Value);
            }
            if (numericUpDown4.Value > 0)
            {
                toplam += Convert.ToInt16(LblYaziciFiyat.Text) * Convert.ToInt16(numericUpDown4.Value);
            }
            if (numericUpDown5.Value > 0)
            {
                toplam += Convert.ToInt16(LblCopKutusuFiyat.Text) * Convert.ToInt16(numericUpDown5.Value);
            }
            if (numericUpDown6.Value > 0)
            {
                toplam += Convert.ToInt16(LblHesapMakinesiFiyat.Text) * Convert.ToInt16(numericUpDown6.Value);
            }
            if (numericUpDown7.Value > 0)
            {
                toplam += Convert.ToInt16(LblDosyaFiyat.Text) * Convert.ToInt16(numericUpDown7.Value);
            }
            if (numericUpDown8.Value > 0)
            {
                toplam += Convert.ToInt16(LblMantarPanoFiyat.Text) * Convert.ToInt16(numericUpDown8.Value);
            }
            if (numericUpDown9.Value > 0)
            {
                toplam += Convert.ToInt16(LblZimbaFiyat.Text) * Convert.ToInt16(numericUpDown9.Value);
            }
            if (numericUpDown10.Value > 0)
            {
                toplam += Convert.ToInt16(LblKalemFiyat.Text) * Convert.ToInt16(numericUpDown10.Value);
            }
            if (numericUpDown11.Value > 0)
            {
                toplam += Convert.ToInt16(LblA4KagitFiyat.Text) * Convert.ToInt16(numericUpDown11.Value);
            }
            if (numericUpDown12.Value > 0)
            {
                toplam += Convert.ToInt16(LblTelefonFiyat.Text) * Convert.ToInt16(numericUpDown12.Value);
            }
            if (numericUpDown13.Value > 0)
            {
                toplam += Convert.ToInt16(LblDolapFiyat.Text) * Convert.ToInt16(numericUpDown13.Value);
            }
            if (numericUpDown14.Value > 0)
            {
                toplam += Convert.ToInt16(LblProjeksiyonFiyat.Text) * Convert.ToInt16(numericUpDown14.Value);
            }
            if (numericUpDown15.Value > 0)
            {
                toplam += Convert.ToInt16(LblEczaDolabiFiyat.Text) * Convert.ToInt16(numericUpDown15.Value);
            }
            if (numericUpDown16.Value > 0)
            {
                toplam += Convert.ToInt16(LblToplantiMasasiFiyat.Text) * Convert.ToInt16(numericUpDown16.Value);
            }
            if (numericUpDown17.Value > 0)
            {
                toplam += Convert.ToInt16(LblKoltukFiyat.Text) * Convert.ToInt16(numericUpDown17.Value);
            }
            if (numericUpDown18.Value > 0)
            {
                toplam += Convert.ToInt16(LblFotokopiMakinesiFiyat.Text) * Convert.ToInt16(numericUpDown18.Value);
            }
            if (numericUpDown19.Value > 0)
            {
                toplam += Convert.ToInt16(LblOtomatFiyat.Text) * Convert.ToInt16(numericUpDown19.Value);
            }
            if (numericUpDown20.Value > 0)
            {
                toplam += Convert.ToInt16(LblKahveMakinesiFiyat.Text) * Convert.ToInt16(numericUpDown20.Value);
            }
            if (numericUpDown21.Value > 0)
            {
                toplam += Convert.ToInt16(LblFaksFiyat.Text) * Convert.ToInt16(numericUpDown21.Value);
            }
            if (numericUpDown22.Value > 0)
            {
                toplam += Convert.ToInt16(LblRafFiyat.Text) * Convert.ToInt16(numericUpDown22.Value);
            }
            if (numericUpDown23.Value > 0)
            {
                toplam += Convert.ToInt16(LblYemekMasasiFiyat.Text) * Convert.ToInt16(numericUpDown23.Value);
            }


            LblToplamDegeri.Text = Convert.ToString(toplam);
            
            

            for (int i = 0; i < chkBoxList1.CheckedItems.Count; i++)
            {
                LstBoxKaydedilenler.Items.Add("-" +chkBoxList1.CheckedItems[i] );
               
            }

            for (int i = 0; i < chkBoxList1.Items.Count; i++)
            {
                chkBoxList1.SetItemChecked(i, false);
            }


            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Muhasebe (MalTutar,MalTarih) values(@m1,@m2)",baglanti);
            komut.Parameters.AddWithValue("@m1",LblToplamDegeri.Text);
            komut.Parameters.AddWithValue("@m2", labelTarih.Text);
            komut.ExecuteNonQuery();
            
      
            baglanti.Close();

            baglanti.Open();
            if (Convert.ToInt16(label1.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l1 where Malid='102'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l1", Convert.ToInt16(label1.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label2.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l2 where Malid='2'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l2", Convert.ToInt16(label2.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label3.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l3 where Malid='3'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l3", Convert.ToInt16(label3.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label4.Text) > 0)
            {
                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l4 where Malid='4'", baglanti);
                
                komutguncelle.Parameters.AddWithValue("@l4", Convert.ToInt16(label4.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label5.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l5 where Malid='5'", baglanti);

                komutguncelle.Parameters.AddWithValue("@l5", Convert.ToInt16(label5.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label6.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l6 where Malid='6'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l6", Convert.ToInt16(label6.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label7.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l7 where Malid='7'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l7", Convert.ToInt16(label7.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label8.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l8 where Malid='8'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l8", Convert.ToInt16(label8.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label9.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l9 where Malid='9'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l9", Convert.ToInt16(label9.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label10.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l10 where Malid='10'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l10", Convert.ToInt16(label10.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label11.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l11 where Malid='11'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l11", Convert.ToInt16(label11.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label12.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l12 where Malid='12'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l12", Convert.ToInt16(label12.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label13.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l13 where Malid='13'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l13", Convert.ToInt16(label13.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label14.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l14 where Malid='14'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l14", Convert.ToInt16(label14.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label15.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l15 where Malid='15'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l15", Convert.ToInt16(label15.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label16.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l16 where Malid='16'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l16", Convert.ToInt16(label16.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label17.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l17 where Malid='17'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l17", Convert.ToInt16(label17.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label18.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l18 where Malid='18'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l18", Convert.ToInt16(label18.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label19.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l19 where Malid='19'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l19", Convert.ToInt16(label19.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label20.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l20 where Malid='20'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l20", Convert.ToInt16(label20.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label21.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l21 where Malid='21'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l21", Convert.ToInt16(label21.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label22.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l22 where Malid='22'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l22", Convert.ToInt16(label22.Text));
                komutguncelle.ExecuteNonQuery();
            }
            if (Convert.ToInt16(label23.Text) > 0)
            {

                SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_MalListe SET Adet=@l23 where Malid='23'", baglanti);
                komutguncelle.Parameters.AddWithValue("@l23", Convert.ToInt16(label23.Text));
                komutguncelle.ExecuteNonQuery();
            }
            baglanti.Close();
            
          

        }
        
        private void FrmMalList_Load(object sender, EventArgs e)
        {
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
            this.Hide();
        }

        private void LblBilgisayarFiyat_Click(object sender, EventArgs e)
        {

        }

        private void labelTarih_Click(object sender, EventArgs e)
        {

        }
    }
}
