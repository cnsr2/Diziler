using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama
            // 5 elemanlı renkler adındaki dizi (elemanları belirsiz)
            string[] renkler = new string[5];

           string[] hayvanlar = {"kedi","köpek","kuş","maymun"}; // 4 elemanlı hayvanlar isimli dizi (elemanları belli)

           int[] dizi;
           dizi = new int[5];
           
           //dizilere değer atama ve erişim

           renkler[0] = "Mavi";

           dizi[3] = 10;
           
           Console.WriteLine(hayvanlar[1]);
           Console.WriteLine(dizi[3]);
           Console.WriteLine(renkler[0]);


            //Döngülerle dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.Write("Lütfen dizinin elaman sayısnı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] sayiDizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("lütfen {0}. sayıyı giriniz", i+1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
            }
            int toplam =0;
            foreach (var sayi  in sayiDizisi)
                toplam += sayi;
                Console.WriteLine(toplam/n);
        }
    }
}
