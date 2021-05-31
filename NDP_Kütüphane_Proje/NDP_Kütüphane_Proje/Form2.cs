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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public abstract class çhek
        {
            public abstract DataTable doldur();
        }
        public class veri_1 : çhek
        {
            public override DataTable doldur()
            {
                SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
                baglanti.Open();
                string sql = "select * from okuyucukayit";
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                baglanti.Close();
                return dt;
            }
        }
        public abstract class çek
        {
            public abstract DataTable doldur();
        }
        public class veri : çek
        {
            public override DataTable doldur()
            {
                SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
                baglanti.Open();
                string sql = "select * from kitapkayit";
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                baglanti.Close();
                return dt;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            veri v1 = new veri();
            dgw_kitap.DataSource = v1.doldur();
            veri_1 v2 = new veri_1();
            dgw_Okuyucu.DataSource = v2.doldur();

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void btn_KitapKayıt_Click(object sender, EventArgs e)
        {
            Kitap_Kayıt frm = new Kitap_Kayıt();
            frm.Show();
        }
        private void btn_OkuyucuKayıt_Click(object sender, EventArgs e)
        {
            OkuyucuKayit ok = new OkuyucuKayit();
            ok.Show();

        }
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void btn_OkuyucuListe_Click(object sender, EventArgs e)
        {
            okuyuculiste ol = new okuyuculiste();
            ol.Show();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void txt_barkodno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from kitapkayit  where barkodno like '%" + txt_barkodno.Text + "%'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgw_kitap.DataSource = ds.Tables[0];
                baglanti.Close();

            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
        }
        private void txt_AdSoyadSorgu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from okuyucukayit  where adsoyad like '%"+txt_AdSoyadSorgu.Text+"%'",baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgw_Okuyucu.DataSource = ds.Tables[0];
                baglanti.Close();

            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
        }
        private void txt_tcnosorgu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from okuyucukayit  where tcno like '%" + txt_tcnosorgu.Text + "%'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgw_Okuyucu.DataSource = ds.Tables[0];
                baglanti.Close();

            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
        }
        private void txt_KitapAdı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from kitapkayit  where kitapadi like '%" + txt_KitapAdı.Text + "%'", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgw_kitap.DataSource = ds.Tables[0];
                baglanti.Close();

            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
        }
        private void btn_adminekle_Click(object sender, EventArgs e)
        {
            admin_ekleme ad = new admin_ekleme();
            ad.Show();
        }
        private void btn_okuyuculistgüncellle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
            baglanti.Open();
            string sql = "select * from okuyucukayit";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dgw_Okuyucu.DataSource = dt;
            baglanti.Close();
        }
        private void btn_kitapgüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
            baglanti.Open();
            string sql = "select * from kitapkayit";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dgw_kitap.DataSource = dt;
            baglanti.Close();
        }
    }
}
