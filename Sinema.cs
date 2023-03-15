using System;
using System.Collections.Generic;
using System.Text;

namespace ButikSinemaUygulaması
{
    class Sinema
    {
        public string FilmAdi { get;  }
        public int Kapasite { get; }
        public float TamBiletFiyati { get; }
        public float YarimBiletFiyati { get;}
        public int ToplamTamBiletAdedi { get; private set; }
        public int ToplamYarimBiletAdedi { get; private set; }
        public double Ciro 
        { 
            get 
            {
              double x = (this.ToplamTamBiletAdedi * this.TamBiletFiyati) + (this.ToplamYarimBiletAdedi * this.YarimBiletFiyati);
                return x;
            } 
        }

        public Sinema(string filmAdi, int kapasite, float tamBiletFiyati, float yarimBiletFiyati)
        {
            this.FilmAdi = filmAdi;
            this.Kapasite = kapasite;
            this.TamBiletFiyati = tamBiletFiyati;
            this.YarimBiletFiyati = yarimBiletFiyati;


        }
        public void BiletSat(int tamBiletAdedi, int yarimBiletAdedi)
        {
            if (BosKoltukVerisiGetir() >= (tamBiletAdedi + yarimBiletAdedi))
            {
                this.ToplamTamBiletAdedi += tamBiletAdedi;
                this.ToplamYarimBiletAdedi += yarimBiletAdedi;
                //CiroHesapla();
                Console.WriteLine(" İşlem gerçekleştirildi");
            }
            else
            {
                Console.WriteLine("Yeterli boş koltuk yok. Satılabilecek bilet adedi: " + this.BosKoltukVerisiGetir());

            }




        }
        public void Biletİade(int tamBiletAdedi, int yarimBiletAdedi)
        {
            if (tamBiletAdedi <=this.ToplamTamBiletAdedi&& yarimBiletAdedi<= this.ToplamYarimBiletAdedi)
            {
                this.ToplamTamBiletAdedi -= tamBiletAdedi;
                this.ToplamYarimBiletAdedi -= yarimBiletAdedi;
                //CiroHesapla();
                Console.WriteLine(" İşlem gerçekleştirildi");
            }
            else
            {
                Console.WriteLine("Mevcut bilet adedinden fazla iade talebi gerçekleşti.İşlem iptal.");

            }

        }
        private void CiroHesapla()
        {
           // this.Ciro = (this.ToplamTamBiletAdedi * this.TamBiletFiyati) + (this.ToplamYarimBiletAdedi * this.YarimBiletFiyati);

        }
        public int BosKoltukVerisiGetir()
        {
            int bos = this.Kapasite - (this.ToplamTamBiletAdedi + this.ToplamYarimBiletAdedi);
            return bos;
        }

    }
}
