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
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        private string sifre = "";
        public string Sifre
        {
            get
            {
                return sifre;
            }
            set
            {
                if (txt_sifre.Text.Length <= 5)
                {
                    sifre = value;
                }
            }
        }
        public void bilgilerial()
        {
            try
            {
                baglanti.Open();
                string sql = "select * from giris where kullanici_adi=@kadi AND sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("kadi", txt_kullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txt_sifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter dp = new SqlDataAdapter(komut);
                dp.Fill(dt);
                if (dt.Rows.Count > 0 && sifre.ToString() == prm2.Value.ToString())
                {
                    Form2 fr = new Form2();
                    fr.Show();
                    this.Hide();
                    baglanti.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı adi veya şifre hatalı.....");
                baglanti.Close();
            }
        }
        private void btn_yardım_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kali 123");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btn_giris_Click(object sender, EventArgs e)
        {
            Sifre = txt_sifre.Text.ToString();
            bilgilerial();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_sifre.PasswordChar = '\0' ;         
            }         
            else
            {
                txt_sifre.PasswordChar = '*';
            }
        }

        private void txt_sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
