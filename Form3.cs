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
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = THEYORULMAZZ; Initial Catalog = OkulKayitSistemi; Integrated Security = True");

        public Form3()
        {
            InitializeComponent();
        }

        private void btngiris2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from sıgnIn where username= '" + txtusername.Text + "' and password= '" + txtsifre2.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Form4 frm = new Form4();
                frm.Show();
                txtusername.Clear();
                txtsifre2.Clear();
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE YANLIŞ", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtusername.Clear();
                txtsifre2.Clear();
            }
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }
    }
}
