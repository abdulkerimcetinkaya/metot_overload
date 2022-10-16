using System;

namespace metod_overload
{
    class Program
    {
        static void Main(String[] args)
        {
            // out parametreler
            string sayi = "999";
            bool sonuc = int.TryParse(sayi , out int outSAyi);
            if (sonuc)
            {
                System.Console.WriteLine("Başarılı");
                System.Console.WriteLine(outSAyi);
            }
            else
            {
                System.Console.WriteLine("Başarısız");
            }

            metodlar instance =  new metodlar();
            instance.topla(2,3, out int topla);

            // metot aşırı yükleme- overloading

            int ifade = 999;
            instance.EkranaYazdır(Convert.ToString(ifade));
            instance.EkranaYazdır(ifade);
            instance.EkranaYazdır("kerim","çetinkaya");
        }
    }

    class metodlar
    {
        public void topla(int a , int b , out int toplam)
        {
            toplam = a+b;
        }
        public void EkranaYazdır(string veri)
        {
            System.Console.WriteLine(veri);
        }

        public void EkranaYazdır(int veri)
        {
            System.Console.WriteLine(veri);
        }

        public void EkranaYazdır(String veri1, string veri2)
        {
            System.Console.WriteLine(veri1 + veri2);
        }
    }
    
        
    
}