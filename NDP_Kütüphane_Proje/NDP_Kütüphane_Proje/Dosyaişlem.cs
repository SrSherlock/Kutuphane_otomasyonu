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
using System.IO;

namespace NDP_Kütüphane_Proje
{
    // datagride ulaşamadıgımız ıcın retuında tipi
    public partial class okuyuculiste : Form 
    {
        public okuyuculiste()
        {
            InitializeComponent();
        }
        public void dosyaolustur()
        {
            try
            {
                if (txt_dosyadi.Text=="")
                {
                    MessageBox.Show("Oluşturacak dosyanın adını giriniz!!!");
                }
                else
                {
                    string dosyayolu = "D:\\" + txt_dosyadi.Text;
                    Directory.CreateDirectory(dosyayolu);
                    MessageBox.Show("Dosya Başarıyla oluşturuldu...");
                  
                    
                  
                }
            }
            catch (Exception)
            {
                MessageBox.Show("DOSYA OLUŞTURULAMADI!!!");
            }
        }
        public void dosyasil()
        {
            string yol = "D:\\"+txt_dosyadi.Text;
            try
            {
                if (txt_dosyadi.Text == "")
                {
                    MessageBox.Show("Silinecek Dosyanın Adını Giriniz!!!");
                }
                else
                {                  
                    Directory.Delete(yol, true);
                    MessageBox.Show("dosya başarılı şekilde silindi...");
                }

            }
            catch (Exception)
            {
                System.Threading.Thread.Sleep(0);
                Directory.Delete(yol, true);
            }



        }
        public void txtolusturma()
        {
            try
            {
                string dosyayeri = @"D:\" + txt_dosyadi.Text + "\\";
                FileStream fs = File.Create(dosyayeri + txt_txtdosya.Text + ".txt");
                MessageBox.Show("dosya oluştu");
                fs.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        public void verileriaktar()
        {
            try
            {
                string yeni = "D:\\" + txt_dosyadi.Text + "\\" + txt_txtdosya.Text + ".txt";
                TextWriter writer = new StreamWriter(yeni,true);
                
                for (int i = 0; i < dgw_verileriaktar.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgw_verileriaktar.Columns.Count; j++)
                    {
                        writer.Write("\t" + dgw_verileriaktar.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("data aktarıldı...");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void okuyuculiste_Load(object sender, EventArgs e)
        {

        }
        private void btn_dosyaOlustur_Click(object sender, EventArgs e)
        {
            dosyaolustur();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            dosyasil();
        }
        private void txt_dosyadi_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_txtolus_Click(object sender, EventArgs e)
        {
            txtolusturma();
        }
        private void btn_aktar_Click(object sender, EventArgs e)
        {
            verileriaktar();   
        }

        private void btn_okuyuculistele_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
                baglanti.Open();
                string sql = "select * from okuyucukayit";
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dgw_verileriaktar.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_kitapliste_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-LC1R8UQ9;Initial Catalog=Kütüphane;Integrated Security=True");
                baglanti.Open();
                string sql = "select * from kitapkayit";
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dgw_verileriaktar.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
