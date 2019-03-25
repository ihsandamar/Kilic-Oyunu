using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilicOyunu
{
    class Deste
    {
        Kart[] kartlar = new Kart[52];
        Kart[] deste1 = new Kart[26];
        Kart[] deste2 = new Kart[26];
        int cekilenKartSay = 0;
        int kulCekKartSay = 0;
        int pcCekKartSay = 0;


        public void olustur()
        {
            string[] turler = new string[4] { "Maca", "Sinek", "Kupa", "Karo" };
            string[] sayilar = new string[13] { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            int k = 0;
            for(int i=0;i<4;i++)
            {
                for(int j=0;j<13;j++)
                {

                    kartlar[k] = new Kart();
                    kartlar[k].tur = turler[i];
                    kartlar[k].sayi = sayilar[j];
                    k++;
                }
            }
        }

        public void yaz()
        {

            for (int k = 0; k < 52; k++)
            {
                Console.Write(k+1 + "-  ");
                kartlar[k].bilgiYaz();
            }
                
        }

        public void karistir()
        {
            Random sayiGen = new Random();
            for (int k = 0; k < 52; k++)
            {
                int rIndis = sayiGen.Next(0, 52);
                Kart gecici = kartlar[k];
                kartlar[k] = kartlar[rIndis];
                kartlar[rIndis] = gecici;
            }
        }

        public Kart kartCek()
        {
            // return kartlar[cekilenKS++];
            return kartlar[cekilenKartSay++];
        }

        public Kart oyuncuKarti()
        {
            Console.Write("Kartın Yanindaki Sayiyi Giriniz:");
            int k = Convert.ToInt32(Console.ReadLine());
            k--;
            return kartlar[k];
        }

        public Kart bilgisayarKarti()
        {
            Random rastgele = new Random();
            int r = rastgele.Next(0, 52);
            return kartlar[r];
        }

        public void kes()
        {
            for(int i=0,j=51;i<26;i++,j--)
            {
                deste1[i] = kartlar[i];
                deste2[i] = kartlar[j]; 
            }
            /* denemek için yazidir
            Console.WriteLine("Deste1-----");
            foreach (Kart kart in deste1)
            {
                kart.bilgiYaz();
            }

            Console.WriteLine("Deste2-----");
            foreach (Kart kart in deste2)
            {
                kart.bilgiYaz();
            }*/
        }

        public Kart kulKartCek()
        {
            // return kartlar[cekilenKS++];
            return deste1[kulCekKartSay++];
        }

        public Kart pcKartCek()
        {
            // return kartlar[cekilenKS++];
            return deste2[pcCekKartSay++];
        }
    }
}
