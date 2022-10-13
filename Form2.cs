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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source = THEYORULMAZZ; Initial Catalog = OkulKayitSistemi; Integrated Security = True");

        private void btngiris_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SıgnUpogrnc where UserName= '" + txtusername.Text + "' and Password= '" + txtsifre.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Form5 frm = new Form5();
                frm.Show();
                txtusername.Clear();
                txtsifre.Clear();
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE YANLIŞ", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtusername.Clear();
                txtsifre.Clear();
            }
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
    }
}
