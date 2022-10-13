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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=THEYORULMAZZ;Initial Catalog=OkulKayitSistemi;Integrated Security=True");

        void kontrol()
        {
            txtka.Text = txtka.Text.Replace("'", "''");
            txtpsw.Text = txtpsw.Text.Replace("'", "''");
        }

        private void btnkyt_Click(object sender, EventArgs e)
        {
            if (txtka.Text.Trim() == "") errorProvider1.SetError(txtka, "Boş Geçilemez");
            if (txtpsw.Text.Trim() == "") errorProvider1.SetError(txtpsw, "Boş Geçilemez");
            else
            {
                kontrol();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO SıgnUpogrnc(UserName,Password)VALUES('" + txtka.Text + "','" + txtpsw.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("BİLGİLER KAYIT EDİLDİ", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
