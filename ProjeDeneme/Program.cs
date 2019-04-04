using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Rezervasyon[] rezervasyon = new Rezervasyon[30];
            UcYildizliOtel Farukotel = new UcYildizliOtel("Faruk Otel");
            UcYildizliOtel Yildizotel = new UcYildizliOtel("Yıldız Otel");
            DortYildizliOtel Gunesotel = new DortYildizliOtel("Güneş Otel");
            DortYildizliOtel Ayotel = new DortYildizliOtel("Ay Otel");
            BesYildizliOtel KainatOtel = new BesYildizliOtel("Kainat Otel");
           
            Otel[] oteller = new Otel[5];
            oteller[0] = Farukotel;
            oteller[1] = Yildizotel;
            oteller[2] = Gunesotel;
            oteller[3] = Ayotel;
            oteller[4] = KainatOtel;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    oteller[j].odalar[i] = new Oda();
                    
                }
            }
           


            while(true)
            {
                int menu;int secim;
                int rezsayac=0;
                Console.WriteLine("Hosgeldiniz");
                Console.WriteLine("1)Yeni Rezarvasyon");
                Console.WriteLine("2)Rezarvasyon İptali");
                Console.WriteLine("Çıkış");
                menu =Convert.ToInt16(Console.ReadLine());
                
                if (menu==1)
                {
                    rezervasyon[rezsayac] = new Rezervasyon();
                    Console.WriteLine("İsminizi Girin");
                    rezervasyon[rezsayac].MusteriAdi = Console.ReadLine();
                    Console.WriteLine("Soyisminizi Girin");
                    rezervasyon[rezsayac].MusteriSoyadi = Console.ReadLine();
                    rezervasyon[rezsayac].RezervasyonNO += 1;
                    rezervasyon[rezsayac].otelbilgi(oteller);
                    secim = Convert.ToInt16(Console.ReadLine());
                    rezervasyon[rezsayac].odabilgileri(oteller, secim);
                    

                }

                else
                {
                    break;   
                }
            }
            
            

            

 
            
            
          
        }
    }
}
