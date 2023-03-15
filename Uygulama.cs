using System;
using System.Collections.Generic;
using System.Text;

namespace ButikSinemaUygulaması
{
    class Uygulama
    {
        Sinema Snm;

        public void Calistir()
        {
            Kurulum();
            Menu();
            while (true)
            {
                string secim = SecimAl();

                switch (secim)
                {
                    case "1":
                    case "S":
                        BiletSatisIslemleri();
                        break;
                    case "2":
                    case "R":
                        BiletIadeIslemleri();
                        break;
                    case "3":
                    case "D":
                        DurumBilgisi();
                        break;
                    case "4":
                    case "X":
                        return;
                }
            }
        }


        public void Kurulum()
        {
            Console.WriteLine("-------Butik Sinema Salonu-------");
            Console.Write("Film adı:");
            string ad = Console.ReadLine();
            Console.Write("Kapasite:");
            int kpst = int.Parse(Console.ReadLine());
            Console.Write("Tam Bilet Fiyatı:");
            float tam = float.Parse(Console.ReadLine());
            Console.Write("Yarım Bilet Fiyatı:");
            float yarim = float.Parse(Console.ReadLine());

            Snm = new Sinema(ad, kpst, tam, yarim);
        }

        public void Menu()
        {
            Console.WriteLine("1 - Bilet Sat(S)");
            Console.WriteLine("2 - Bilet İade(R)");
            Console.WriteLine("3 - Durum Bilgisi(D)");
            Console.WriteLine("4 - Çıkış(X)");


        }


        public void BiletSatisIslemleri()
        {
            Console.WriteLine("Bilet Sat:              ");
            Console.WriteLine("Tam Bilet Adedi:     ");
            int tamAdet = int.Parse(Console.ReadLine());
            Console.WriteLine(" Yarım Bilet Adedi:  ");
            int yarimAdet = int.Parse(Console.ReadLine());

            Snm.BiletSat(tamAdet, yarimAdet);
            Console.WriteLine(" İşlem gerçekleştirildi.");






        }

        public void BiletIadeIslemleri()
        {
            Console.WriteLine(" Bilet İade:           ");
            Console.WriteLine("Tam Bilet Adedi:    ");
            int tamAdet = int.Parse(Console.ReadLine());
            Console.WriteLine(" Yarım Bilet Adedi: ");
            int yarimAdet = int.Parse(Console.ReadLine());

            Snm.Biletİade(tamAdet, yarimAdet);
           


        }


        public void DurumBilgisi()
        {
            Console.WriteLine(" Durum Bilgisi");
            Console.WriteLine("Film: " + Snm.FilmAdi);
            Console.WriteLine("Kapasite: " + Snm.Kapasite);
            Console.WriteLine("Tam Bilet Fiyatı : " + Snm.TamBiletFiyati);
            Console.WriteLine("Yarım Bilet Fiyatı : " + Snm.YarimBiletFiyati);
            Console.WriteLine("Toplam Tam Bilet Adedi: " + Snm.ToplamTamBiletAdedi);
            Console.WriteLine("Toplam Yarım Bilet Adedi: " + Snm.ToplamYarimBiletAdedi);
            Console.WriteLine("Ciro: " + Snm.Ciro);
            Console.WriteLine("Boş Koltuk Adedi: " + Snm.BosKoltukVerisiGetir());
           


        }



        public string SecimAl()
        {
            Console.WriteLine();
            Console.Write("Seçim: ");
            return Console.ReadLine().ToUpper();
        }

    }




}
