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
    public partial class FrmMuhasebe : Form
    {
        public FrmMuhasebe()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E5JB5ET\\SQLEXPRESS;Initial Catalog=tasinirMal;Integrated Security=True");
        public int tutar;
        public string tarih;
        private void FrmMuhasebe_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tasinirMalDataSet4.Tbl_Muhasebe' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_MuhasebeTableAdapter.Fill(this.tasinirMalDataSet4.Tbl_Muhasebe);

        }


        private void btnYenile_Click(object sender, EventArgs e)
        {
            

        }
       
        
        
         
        

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
            this.Hide();
        }
    }
}
