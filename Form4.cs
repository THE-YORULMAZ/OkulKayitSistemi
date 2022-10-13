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
    public partial class Form4 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=THEYORULMAZZ;Initial Catalog=OkulKayitSistemi;Integrated Security=True");
        DataTable tablo = new DataTable();
        public Form4()
        {
            InitializeComponent();
        }

        void listele()
        {
            txtograd.Text = "";
            txtogrsad.Text = "";
            txtders.Text = "";
            txtogretmen.Text = "";
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from tblkayit", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            baglanti.Close();
        }

        void kontrol()
        {
            txtograd.Text = txtograd.Text.Replace("'", "''");
            txtogrsad.Text = txtogrsad.Text.Replace("'", "''");
            txtders.Text = txtders.Text.Replace("'", "''");
            txtogretmen.Text = txtogretmen.Text.Replace("'", "''");

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listele();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtograd.Text.Trim() == "") errorProvider1.SetError(txtograd, "Boş Geçilemez");
            if (txtogrsad.Text.Trim() == "") errorProvider1.SetError(txtogrsad, "Boş Geçilemez");
            if (txtders.Text.Trim() == "") errorProvider1.SetError(txtders, "Boş Geçilemez");
            if (txtogretmen.Text.Trim() == "") errorProvider1.SetError(txtogretmen, "Boş Geçilemez");
            else
            {
                kontrol();
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglanti;
                komut1.CommandText = "INSERT INTO tblkayit(ogr_ad,ogr_sad,ders_adi,ogretmen)VALUES('" + txtograd.Text + "','" + txtogrsad.Text + "','" + txtders.Text + "','" + txtogretmen.Text + "')";
                komut1.ExecuteNonQuery();
                tablo.Clear();
                baglanti.Close();
                MessageBox.Show("BİLGİLER KAYIT EDİLDİ", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtograd.Text == "")
            {
                MessageBox.Show("LÜTFEN LİSTEDEN BİR KAYIT SEÇİN", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                kontrol();
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "UPDATE tblkayit SET ogr_ad='" + txtograd.Text + "',ogr_sad='" + txtogrsad.Text + "',ders_adi='" + txtders.Text + "',ogretmen='" + txtogretmen.Text + "'where ID=@NUMARA";
                cmd.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                tablo.Clear();
                baglanti.Close();
                MessageBox.Show("KAYIT GÜNCELLEME İŞLEMİ TAMAMLANDI", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tablo.Clear();
            }
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtograd.Text == "")
            {
                MessageBox.Show("LÜTFEN LİSTEDEN BİR KAYIT SEÇİN", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("KAYIT SİLİNSİNMİ ?", "SİSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = baglanti;
                    cmd2.CommandText = "DELETE FROM tblkayit WHERE ID=@NUMARA";
                    cmd2.Parameters.AddWithValue("@NUMARA", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd2.ExecuteNonQuery();
                    tablo.Clear();
                    baglanti.Close();
                }
            }
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtograd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtogrsad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtders.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtogretmen.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
