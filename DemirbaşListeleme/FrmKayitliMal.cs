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
    public partial class FrmKayitliMal : Form
    {
        public FrmKayitliMal()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E5JB5ET\\SQLEXPRESS;Initial Catalog=tasinirMal;Integrated Security=True");

        private void FrmKayitliMal_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tasinirMalDataSet3.Tbl_MalListe' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_MalListeTableAdapter.Fill(this.tasinirMalDataSet3.Tbl_MalListe);
            // TODO: Bu kod satırı 'tasinirMalDataSet2.Tbl_MalListe' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            
            // TODO: Bu kod satırı 'tasinirMalDataSet.Tbl_KayitliMallar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
            this.Hide();
        }
    }
}
