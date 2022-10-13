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

namespace OkulKayıtSistemi
{
    public partial class Form5 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=OZCAN;Initial Catalog=OkulKayitSistemi;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            baglan.Open();
            string kayit = "SELECT * from tblkayit";            
            SqlCommand komut = new SqlCommand(kayit, baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglan.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
