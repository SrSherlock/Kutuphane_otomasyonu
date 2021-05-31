using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Kütüphane_Proje
{
    interface Iokuyucukayit
    {
        string adi { get; set; }
        string tcno { get; set; }
        string okul { get; set; }
        DateTime dogumtarihi { get; set; }
        string dogumyer { get; set; }
        string telno { get; set; }
        string eposta { get; set; }
        DateTime uyeliktarihi { get; set; }
        string cinsiyet { get; set; }
        string adres { get; set; }


    }
    class kayit : Iokuyucukayit
    {
        public string adi;
        public string tcno;
        public string okul;
        public DateTime dogumtarihi;
        public string dogumyer;
        public string telno;
        public string eposta;
        public DateTime uyeliktarihi;
        public string cinsiyet;
        public string adres;



        public kayit(string _adi, string _tcno, string _okul, DateTime _dogumtarihi,string _dogumyer,string _telno,string _eposta,DateTime _uyeliktarihi,string _cinsiyet,string _adres)
        {
            adi = _adi;
            tcno = _tcno;
            okul = _okul;
            dogumtarihi = _dogumtarihi;
            dogumyer = _dogumyer;
            telno = _telno;
            eposta = _eposta;
            uyeliktarihi = _uyeliktarihi;
            cinsiyet = _cinsiyet;
            adres = _adres;
        }
        string Iokuyucukayit.adi
        {
            get
            {
                return adi;
            }
            set
            {
                adi = value;
            }
        }
        string Iokuyucukayit.tcno
        {
            get
            {
                return tcno;
            }

            set
            {
                tcno = value;
            }
        }
        string Iokuyucukayit.okul
        {
            get
            {
                return okul;
            }
            set
            {
                okul = value;
            }
        }
        DateTime Iokuyucukayit.dogumtarihi
        {
            get
            {
                return dogumtarihi;
            }
            set
            {
                dogumtarihi = value;
            }
        }
        string Iokuyucukayit.dogumyer
        {
            get
            {
                return dogumyer;
            }
            set
            {
                dogumyer = value;
            }
        }
        string Iokuyucukayit.telno
        {
            get
            {
                return telno;
            }
            set
            {
                telno = value;
            }
        }
        string Iokuyucukayit.eposta
        {
            get
            {
                return eposta;
            }
            set
            {
                eposta = value;
            }
        }
        DateTime Iokuyucukayit.uyeliktarihi
        {
            get
            {
                return uyeliktarihi;
            }
            set
            {
                uyeliktarihi = value;
            }
        }
        string Iokuyucukayit.cinsiyet   
        {
            get
            {
                return cinsiyet;
            }
            set
            {
                cinsiyet = value;
            }
        }
        string Iokuyucukayit.adres
        {
            get
            {
                return adres;
            }
            set
            {
                adres = value;
            }
        }

    }
}
