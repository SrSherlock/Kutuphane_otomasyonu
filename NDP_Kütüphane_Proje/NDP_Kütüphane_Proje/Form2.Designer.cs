
namespace NDP_Kütüphane_Proje
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_kitapgüncelle = new System.Windows.Forms.Button();
            this.btn_okuyuculistgüncellle = new System.Windows.Forms.Button();
            this.txt_tcnosorgu = new System.Windows.Forms.TextBox();
            this.txt_KitapAdı = new System.Windows.Forms.TextBox();
            this.txt_barkodno = new System.Windows.Forms.TextBox();
            this.txt_AdSoyadSorgu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgw_kitap = new System.Windows.Forms.DataGridView();
            this.dgw_Okuyucu = new System.Windows.Forms.DataGridView();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_adminekle = new System.Windows.Forms.Button();
            this.btn_OkuyucuListe = new System.Windows.Forms.Button();
            this.btn_OkuyucuKayıt = new System.Windows.Forms.Button();
            this.btn_KitapKayıt = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Okuyucu)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage1.Controls.Add(this.btn_kitapgüncelle);
            this.tabPage1.Controls.Add(this.btn_okuyuculistgüncellle);
            this.tabPage1.Controls.Add(this.txt_tcnosorgu);
            this.tabPage1.Controls.Add(this.txt_KitapAdı);
            this.tabPage1.Controls.Add(this.txt_barkodno);
            this.tabPage1.Controls.Add(this.txt_AdSoyadSorgu);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgw_kitap);
            this.tabPage1.Controls.Add(this.dgw_Okuyucu);
            this.tabPage1.Controls.Add(this.btn_cikis);
            this.tabPage1.Controls.Add(this.btn_adminekle);
            this.tabPage1.Controls.Add(this.btn_OkuyucuListe);
            this.tabPage1.Controls.Add(this.btn_OkuyucuKayıt);
            this.tabPage1.Controls.Add(this.btn_KitapKayıt);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ana Menü";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_kitapgüncelle
            // 
            this.btn_kitapgüncelle.BackColor = System.Drawing.Color.SlateGray;
            this.btn_kitapgüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapgüncelle.Location = new System.Drawing.Point(367, 430);
            this.btn_kitapgüncelle.Name = "btn_kitapgüncelle";
            this.btn_kitapgüncelle.Size = new System.Drawing.Size(179, 36);
            this.btn_kitapgüncelle.TabIndex = 26;
            this.btn_kitapgüncelle.Text = "Kitap Güncelle";
            this.btn_kitapgüncelle.UseVisualStyleBackColor = false;
            this.btn_kitapgüncelle.Click += new System.EventHandler(this.btn_kitapgüncelle_Click);
            // 
            // btn_okuyuculistgüncellle
            // 
            this.btn_okuyuculistgüncellle.BackColor = System.Drawing.Color.SlateGray;
            this.btn_okuyuculistgüncellle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_okuyuculistgüncellle.Location = new System.Drawing.Point(75, 430);
            this.btn_okuyuculistgüncellle.Name = "btn_okuyuculistgüncellle";
            this.btn_okuyuculistgüncellle.Size = new System.Drawing.Size(179, 36);
            this.btn_okuyuculistgüncellle.TabIndex = 25;
            this.btn_okuyuculistgüncellle.Text = "Okuyucu Güncelle";
            this.btn_okuyuculistgüncellle.UseVisualStyleBackColor = false;
            this.btn_okuyuculistgüncellle.Click += new System.EventHandler(this.btn_okuyuculistgüncellle_Click);
            // 
            // txt_tcnosorgu
            // 
            this.txt_tcnosorgu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(163)))), ((int)(((byte)(137)))));
            this.txt_tcnosorgu.Location = new System.Drawing.Point(154, 129);
            this.txt_tcnosorgu.Name = "txt_tcnosorgu";
            this.txt_tcnosorgu.Size = new System.Drawing.Size(118, 20);
            this.txt_tcnosorgu.TabIndex = 24;
            this.txt_tcnosorgu.TextChanged += new System.EventHandler(this.txt_tcnosorgu_TextChanged);
            // 
            // txt_KitapAdı
            // 
            this.txt_KitapAdı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(163)))), ((int)(((byte)(137)))));
            this.txt_KitapAdı.Location = new System.Drawing.Point(512, 129);
            this.txt_KitapAdı.Name = "txt_KitapAdı";
            this.txt_KitapAdı.Size = new System.Drawing.Size(112, 20);
            this.txt_KitapAdı.TabIndex = 13;
            this.txt_KitapAdı.TextChanged += new System.EventHandler(this.txt_KitapAdı_TextChanged);
            // 
            // txt_barkodno
            // 
            this.txt_barkodno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(163)))), ((int)(((byte)(137)))));
            this.txt_barkodno.Location = new System.Drawing.Point(367, 129);
            this.txt_barkodno.Name = "txt_barkodno";
            this.txt_barkodno.Size = new System.Drawing.Size(118, 20);
            this.txt_barkodno.TabIndex = 12;
            this.txt_barkodno.TextChanged += new System.EventHandler(this.txt_barkodno_TextChanged);
            // 
            // txt_AdSoyadSorgu
            // 
            this.txt_AdSoyadSorgu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(163)))), ((int)(((byte)(137)))));
            this.txt_AdSoyadSorgu.Location = new System.Drawing.Point(3, 129);
            this.txt_AdSoyadSorgu.Name = "txt_AdSoyadSorgu";
            this.txt_AdSoyadSorgu.Size = new System.Drawing.Size(125, 20);
            this.txt_AdSoyadSorgu.TabIndex = 9;
            this.txt_AdSoyadSorgu.TextChanged += new System.EventHandler(this.txt_AdSoyadSorgu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(151, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 45);
            this.label2.TabIndex = 23;
            this.label2.Text = "Okuyucunun TC\'sine \r\nGöre DataGridView\'den \r\n Bulma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(318, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Kitap Kayıt";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Okuyucu Kayıt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(509, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kitabın Adına  Göre \r\nDataGridView\'den Bulma\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(364, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 45);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kitabın Barkod No\'suna \r\nGöre DataGridView\'den\r\nBulma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Okuyucunun Adına Göre\r\nDaraGridView\'den Bulma";
            // 
            // dgw_kitap
            // 
            this.dgw_kitap.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgw_kitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_kitap.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgw_kitap.Location = new System.Drawing.Point(323, 188);
            this.dgw_kitap.Name = "dgw_kitap";
            this.dgw_kitap.Size = new System.Drawing.Size(319, 233);
            this.dgw_kitap.TabIndex = 8;
            // 
            // dgw_Okuyucu
            // 
            this.dgw_Okuyucu.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgw_Okuyucu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Okuyucu.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgw_Okuyucu.Location = new System.Drawing.Point(4, 188);
            this.dgw_Okuyucu.Name = "dgw_Okuyucu";
            this.dgw_Okuyucu.Size = new System.Drawing.Size(313, 233);
            this.dgw_Okuyucu.TabIndex = 7;
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.SlateGray;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(551, 6);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(91, 53);
            this.btn_cikis.TabIndex = 6;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_adminekle
            // 
            this.btn_adminekle.BackColor = System.Drawing.Color.SlateGray;
            this.btn_adminekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_adminekle.Location = new System.Drawing.Point(417, 6);
            this.btn_adminekle.Name = "btn_adminekle";
            this.btn_adminekle.Size = new System.Drawing.Size(97, 53);
            this.btn_adminekle.TabIndex = 3;
            this.btn_adminekle.Text = "Admin Ekle\r\n\r\n";
            this.btn_adminekle.UseVisualStyleBackColor = false;
            this.btn_adminekle.Click += new System.EventHandler(this.btn_adminekle_Click);
            // 
            // btn_OkuyucuListe
            // 
            this.btn_OkuyucuListe.BackColor = System.Drawing.Color.SlateGray;
            this.btn_OkuyucuListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OkuyucuListe.Location = new System.Drawing.Point(283, 6);
            this.btn_OkuyucuListe.Name = "btn_OkuyucuListe";
            this.btn_OkuyucuListe.Size = new System.Drawing.Size(91, 53);
            this.btn_OkuyucuListe.TabIndex = 2;
            this.btn_OkuyucuListe.Text = "Data\'daki Verileri\r\nTxt Aktarma";
            this.btn_OkuyucuListe.UseVisualStyleBackColor = false;
            this.btn_OkuyucuListe.Click += new System.EventHandler(this.btn_OkuyucuListe_Click);
            // 
            // btn_OkuyucuKayıt
            // 
            this.btn_OkuyucuKayıt.BackColor = System.Drawing.Color.SlateGray;
            this.btn_OkuyucuKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OkuyucuKayıt.Location = new System.Drawing.Point(136, 6);
            this.btn_OkuyucuKayıt.Name = "btn_OkuyucuKayıt";
            this.btn_OkuyucuKayıt.Size = new System.Drawing.Size(91, 53);
            this.btn_OkuyucuKayıt.TabIndex = 1;
            this.btn_OkuyucuKayıt.Text = "Okuyucu kayıt";
            this.btn_OkuyucuKayıt.UseVisualStyleBackColor = false;
            this.btn_OkuyucuKayıt.Click += new System.EventHandler(this.btn_OkuyucuKayıt_Click);
            // 
            // btn_KitapKayıt
            // 
            this.btn_KitapKayıt.BackColor = System.Drawing.Color.SlateGray;
            this.btn_KitapKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KitapKayıt.Location = new System.Drawing.Point(6, 6);
            this.btn_KitapKayıt.Name = "btn_KitapKayıt";
            this.btn_KitapKayıt.Size = new System.Drawing.Size(91, 53);
            this.btn_KitapKayıt.TabIndex = 0;
            this.btn_KitapKayıt.Text = "Kitap Kayıt";
            this.btn_KitapKayıt.UseVisualStyleBackColor = false;
            this.btn_KitapKayıt.Click += new System.EventHandler(this.btn_KitapKayıt_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 495);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 504);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Okuyucu)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_kitapgüncelle;
        private System.Windows.Forms.Button btn_okuyuculistgüncellle;
        private System.Windows.Forms.TextBox txt_tcnosorgu;
        private System.Windows.Forms.TextBox txt_KitapAdı;
        private System.Windows.Forms.TextBox txt_barkodno;
        private System.Windows.Forms.TextBox txt_AdSoyadSorgu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgw_kitap;
        private System.Windows.Forms.DataGridView dgw_Okuyucu;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_adminekle;
        private System.Windows.Forms.Button btn_OkuyucuListe;
        private System.Windows.Forms.Button btn_OkuyucuKayıt;
        private System.Windows.Forms.Button btn_KitapKayıt;
        private System.Windows.Forms.TabControl tabControl1;
    }
}