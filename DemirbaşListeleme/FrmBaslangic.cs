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
    public partial class FrmBaslangic : Form
    {
        public FrmBaslangic()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E5JB5ET\\SQLEXPRESS;Initial Catalog=tasinirMal;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKayit fr = new FrmKayit();
            fr.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        private void FrmBaslangic_Load(object sender, EventArgs e)
        {

        }
    }
}
