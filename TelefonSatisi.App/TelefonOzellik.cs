using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonSatisi.App
{
    internal class TelefonOzellik
    {
        public string Marka { get; set; }
        public string İsim_soyisim { get; set; }
        public int Ram { get; set; }
        public int Hafıza { get; set; }
        public int Fiyat { get; set; }
        public int Bakiye { get; set; }

        public void Marka_()
        {
            

            Console.WriteLine("Almak istediğin telefonun markasını girebilir misin\n" +
                "1=Iphone\n" +
                "2=samung" +
                "\n3=Huawey\n" +
                " 4=Xiaomi");
            int secimmarka = int.Parse(Console.ReadLine());
            switch (secimmarka)
            {
                case 1:
                    this.Marka = "Iphone";
                    this.Fiyat = 50000;
                    break;
                case 2:
                    this.Marka = "Samsung";
                    this.Fiyat = 30000;
                    break;
                case 3:
                    this.Marka = "Huawey";
                    this.Fiyat = 20000;
                    break;
                case 4:
                    this.Marka = "Xiaomi";
                    this.Fiyat = 15000;
                    break;
                default:
                    Console.WriteLine("Herhangi bir telefon marksı girilmedi");
                    break;
            }

        }

        public void Ram_Fiyat_Hesaplama()
        {
            Console.WriteLine("Almak istediğin telefonun Ram boyutunu giriniz" +
                "mevcut ram kapasiteleri\n4\n8\n12");
            int seciram = int.Parse(Console.ReadLine());

            switch (seciram)
            {
                case 4:
                    this.Fiyat=Fiyat;
                    this.Ram = seciram;
                    break;
                case 8:
                    this.Ram = seciram;
                    this.Fiyat+=500;
                    break;
                case 12:
                    this.Ram = seciram;
                    this.Fiyat +=1000;
                    break;

                default:
                    Console.WriteLine("Herhangi bir Ram  girilmedi");
                    break;
            }

        }
        public void Hafıza_Fiyat_Hesaplama()
        {
            Console.WriteLine("Almak istediğiniz telefonun Hafıza boyutunu giriniz"
                + "\nMevcut hafıza boyutlar\n16\n32\n64\n128");
            int secimhafiza=int.Parse(Console.ReadLine());
            switch (secimhafiza)
            {
                case 16:
                    this.Hafıza = secimhafiza;
                    this.Fiyat = Fiyat;
                    break;
                case 32:
                    this.Fiyat += 500;
                    this.Hafıza = secimhafiza;
                    break;
                case 64:
                    this.Hafıza = secimhafiza;
                    this.Fiyat += 1000;
                    break;
                case 128:
                    this.Hafıza = secimhafiza;
                    this.Fiyat += 1000;
                    break;
                default:
                    break;
            }
        }

        public void KişiselBilgiler()
        {
            Console.WriteLine($"İsim soyisim:{İsim_soyisim}\n" +
                $"Bakiyeniz: {Bakiye}");
        }
        public void TelefonBilgi()
        {
            Console.WriteLine($"Telefon markası:{Marka}\n" +
                $"Ram kapasitesi:{Ram}\n" +
                $"Hafıza kapasitesi:{Hafıza}\n" +
                $"Telefon fiyatı:{Fiyat}");
        }

        public void Alinabilirlik()
        {
            if (Bakiye >= Fiyat)
            {

                Console.WriteLine($"{Marka} telefonu alabilirsiniz");
            }
            else
            {
                Console.WriteLine($"Üzgünüm {Marka} telefonu alamıyorsun");

            }
        }
    }
}
