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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E5JB5ET\\SQLEXPRESS;Initial Catalog=tasinirMal;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitliMal_Click(object sender, EventArgs e)
        {
            FrmMuhasebe fr = new FrmMuhasebe();
            fr.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FrmMalList fr = new FrmMalList();
            fr.Show();
            this.Hide();
        }

        private void btnKayitliMal_Click_1(object sender, EventArgs e)
        {
            FrmKayitliMal fr = new FrmKayitliMal();
            fr.Show();
            this.Hide();
        }
    }
}
