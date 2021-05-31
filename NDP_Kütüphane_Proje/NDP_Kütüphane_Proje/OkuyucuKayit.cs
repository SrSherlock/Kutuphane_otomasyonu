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

namespace NDP_Kütüphane_Proje
{
  
    public partial class OkuyucuKayit : Form
    {
        public OkuyucuKayit()
        {
            InitializeComponent();
        }
        public  void veriekle()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
            try
            {
                baglanti.Open();
                string sql = "insert into okuyucukayit  values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
                
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@p1",txt_adsoyad.Text);
                komut.Parameters.AddWithValue("@p2",mtxt_TcNo.Text);
                komut.Parameters.AddWithValue("@p3",txt_okul.Text);
                komut.Parameters.AddWithValue("@p4",dt_dogumtarihi.Value);
                komut.Parameters.AddWithValue("@p5",txt_dogumyer.Text);
                komut.Parameters.AddWithValue("@p6",mtxt_telefon.Text);
                komut.Parameters.AddWithValue("@p7",txt_EPosta.Text);
                komut.Parameters.AddWithValue("@p8",dt_üyeliktarihi.Value);
                komut.Parameters.AddWithValue("@p9",cbox_cinsiyet.Text);
                komut.Parameters.AddWithValue("@p10",txt_adres.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();            
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void OkuyucuKayit_Load(object sender, EventArgs e)
        {
            dt_dogumtarihi.Format=DateTimePickerFormat.Short;
            dt_üyeliktarihi.Format = DateTimePickerFormat.Short;
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
            baglanti.Open();
            string sql = "select * from okuyucukayit";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dgw_okuyucukayit.DataSource = dt;
            baglanti.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                kayit k1 = new kayit(txt_adsoyad.Text, mtxt_TcNo.Text, txt_okul.Text, dt_dogumtarihi.Value, txt_dogumyer.Text, mtxt_telefon.Text, txt_EPosta.Text, dt_üyeliktarihi.Value, cbox_cinsiyet.Text, txt_adres.Text);
                veriekle();
                MessageBox.Show("Başarılı Şekilde kayıt edildi...");
                txt_adres.Clear();
                txt_adsoyad.Clear();
                txt_dogumyer.Clear();
                txt_EPosta.Clear();
                txt_okul.Clear();
                mtxt_TcNo.Clear();
                mtxt_telefon.Clear();
            }
            catch (Exception g)
            {
                MessageBox.Show("Lütfen Girilen Değerleri Doğru Giriniz"+g.Message);
            }

        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
            baglanti.Open();
            string sql = "select * from okuyucukayit";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dgw_okuyucukayit.DataSource = dt;
            baglanti.Close();
            MessageBox.Show("Güncel Tablo...");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
                baglanti.Open();
                string sql = "delete from okuyucukayit where tcno=" + label11.Text;
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dgw_okuyucukayit.DataSource = dt;
                baglanti.Close();
                MessageBox.Show("Başarılı Şekilde Silindi...");
            }
            catch (Exception ü)
            {
                MessageBox.Show(ü.Message);
            }


        }
        private void dgw_okuyucukayit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgw_okuyucukayit_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            label11.Text = dgw_okuyucukayit.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
