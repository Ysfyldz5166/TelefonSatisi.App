using System;

namespace TelefonSatisi.App
{
    internal class Program
    {
        static void Main(string[] args)
        {


            TelefonOzellik alici1 = new TelefonOzellik();
            Console.WriteLine("İsim Soyisminizi giriniz");
            alici1.İsim_soyisim = Console.ReadLine();
            Console.WriteLine("Telefon almak için ayırdığınız bütçeyi giriniz");
            alici1.Bakiye = int.Parse(Console.ReadLine());
            alici1.Marka_();
            alici1.Ram_Fiyat_Hesaplama();
            alici1.Hafıza_Fiyat_Hesaplama();
            Console.WriteLine("Telefonun alınabilirlik durumunu kontrol etmek ister misiniz\n1-EVET\n2-HAYIR");
            int alinabilirlik = int.Parse(Console.ReadLine());
            switch (alinabilirlik)
            {
                case 1:
                    alici1.KişiselBilgiler();
                    alici1.TelefonBilgi();
                    alici1.Alinabilirlik();

                    break;
                case 2:
                    alici1.KişiselBilgiler();
                    alici1.TelefonBilgi();
                    break;
            }

        }
    }
}
