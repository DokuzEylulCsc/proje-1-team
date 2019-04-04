using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeDeneme
{
    class Rezervasyon
    {
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public int RezervasyonNO = 0;
        
        public void otelbilgi(Otel[] otel)
        {
            int sira = 1;
            foreach (Otel i in otel)
            {
                if(i is UcYildizliOtel)
                {
                    Console.WriteLine(sira.ToString()+")Uc Yildizli Otel:"+ i.OtelAdi);
                    sira++;

                }
                else if(i is DortYildizliOtel)
                {
                    Console.WriteLine(sira.ToString()+ ")Dort Yildizli Otel:"+ i.OtelAdi);
                    sira++;
                }
                else if(i is BesYildizliOtel)
                {
                    Console.WriteLine(sira.ToString()+ ")Bes Yildizli Otel:"+ i.OtelAdi);
                    sira++;
                }
            }
        }
        public void odabilgileri(Otel[] otel,int otelNo)
        {
            Console.WriteLine(otel[otelNo].OtelAdi + "Oda Bilgileri:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Tek Yatak:" + otel[otelNo].odalar[i].tekyatak.ToString());
                Console.WriteLine("Cift Yatak:" + otel[otelNo].odalar[i].ciftyatak.ToString());
                Console.WriteLine("İkiz Yatak:" + otel[otelNo].odalar[i].ikizyatak.ToString());
                Console.WriteLine("Deniz Manzara:" + otel[otelNo].odalar[i].denizmanzara.ToString());
                Console.WriteLine("Havuz Manzara:" + otel[otelNo].odalar[i].havuzmanzara.ToString());
                
            }
        }
    }
        
       
    }
    class Otel
    {
    
    public string OtelAdi { get; set; }
        public Oda[] odalar = new Oda[5];
        public Otel()
        {

        }
    }
    class UcYildizliOtel:Otel
    {
    
    public UcYildizliOtel(string name)
        {
            OtelAdi = name;
        }
        
        
    }
    class DortYildizliOtel:Otel
    {
    public bool denizmanzara = true;
        public DortYildizliOtel(string name)
        {
            OtelAdi = name;
        }
        public Oda[] odalar = new Oda[5];
    }
    class BesYildizliOtel:Otel
    {
        public new bool denizmanzara = true;
        public bool havuzmanzara = true;
        public BesYildizliOtel(string name)
        {
            OtelAdi = name;
        }
        public Oda[] odalar = new Oda[5];
    }
    
    



    class Oda:Otel
        {
            public bool musaitlik;


         public bool tekyatak = false;
         public bool ciftyatak = false;
         public bool ikizyatak = false;
         public bool denizmanzara = false;
         public bool havuzmanzara = true;

}
    

