using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_Kütüphane_Proje
{
    public partial class admin_ekleme : Form
    {
        public admin_ekleme()
        {
            InitializeComponent();
        }
      
        public void ekleme()
        {
           
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
                baglanti.Open();
                string sql = "insert into giris(kullanici_adi,sifre) values (@kullanici_adi,@sifre)";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@kullanici_adi",txt_kuladi.Text);
                komut.Parameters.AddWithValue("@sifre",txt_sifre.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı Şekilde Eklendi...");
                txt_kuladi.Clear();
                txt_sifre.Clear();
            }
            catch (Exception l)
            {
                MessageBox.Show("Kayıt Eklenemedi..."+l.Message);
            }

        }
        private void admin_ekleme_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
            baglanti.Open();
            string sql = "select * from giris";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dgw_admin.DataSource = dt;
            baglanti.Close();
        }
        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
                baglanti.Open();
                string sql = "select * from giris";
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dgw_admin.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            ekleme();
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            if (txt_sifre.Text.Length<=5)
            {

            }
            else
            {
                MessageBox.Show("5 haneyi aşmayacak bir şifre giriniz... ");
                txt_sifre.Clear();
            }
        }

        private void txt_sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}

