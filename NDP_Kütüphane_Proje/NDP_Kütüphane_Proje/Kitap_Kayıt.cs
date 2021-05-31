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
    public partial class Kitap_Kayıt : Form
    {
      
        public  class kitaplar
        {
            internal int _barkodno;
            internal string _kitapadi;
            internal string _yazaradi;
            internal string _yayinevi;
            internal string _kitaptürü;
            internal int _stoksayisi;

            public  kitaplar(int barkodno,string kitapad,string yazarad,string yayıevi,string ktürü,int stoksayisi)
            {
                 _barkodno = barkodno;
                 _kitapadi = kitapad;
                 _yazaradi = yazarad;
                 _yayinevi = yayıevi;
                 _kitaptürü = ktürü;
                 _stoksayisi = stoksayisi;
            }
        }
        public class kitap:kitaplar
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");

            public kitap(int a,string b,string c,string d,string e,int f) : base( a, b, c,  d,  e, f)
            {
                             
            }
            public void veriekle()
            {
                try
                {
                    baglanti.Open();
                    string sql = "insert into kitapkayit values (" + _barkodno + ",'" + _kitapadi.ToString() + "','" + _yazaradi.ToString() + "','" + _yayinevi.ToString() + "','" + _kitaptürü.ToString() + "'," + _stoksayisi + ")";
                    SqlCommand komut = new SqlCommand(sql, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }


        }
        public Kitap_Kayıt()
        {
            InitializeComponent();
        }
        private void Kitap_Kayıt_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
            baglanti.Open();
            string sql = "select * from kitapkayit";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                kitap k = new kitap(int.Parse(txt_barkodno.Text), txt_kitapadi.Text, txt_yazaradi.Text, txt_yayinevi.Text, txt_kitaptürü.Text, int.Parse(txt_stoksayisi.Text));
                k.veriekle();
                MessageBox.Show("Başarılı Şekilde Kaydedildi...");
                txt_barkodno.Clear();
                txt_kitapadi.Clear();
                txt_kitaptürü.Clear();
                txt_stoksayisi.Clear();
                txt_yayinevi.Clear();
                txt_yazaradi.Clear();
            }
            catch (Exception q)
            {
                MessageBox.Show("Girdiğiniz Bilgileri Lütfen Doğru Bir Şekilde Giriniz..."+q.Message);
            }
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
            baglanti.Open();
            string sql = "select * from kitapkayit";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            MessageBox.Show("Başarılı Şekilde Güncellendi...");

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
            baglanti.Open();
            string sql = "delete from kitapkayit where barkodno=" + label8.Text;
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            MessageBox.Show("Başarılı Şekilde Silindi...");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            label8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
