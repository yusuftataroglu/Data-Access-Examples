using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ImdbDataDbFirst.Utils
{
    public static class MainMenu
    {
        public static string[] MainMenuArray { get; set; } = new string[]
        {
            "1- Kullanıcıdan alınan tarih'den sonra çıkan filmleri listeleyin",
            "2- Kullanıcıdan alınan tarih'den sonra ve puanı 75 ile 100 arasında olan filmleri listeleyin",
            "3- Hasılata göre filmleri çoktan az'a doğru listeleyin",
            "4- En yüksek hasılata sahip yönetmenleri yapmış olduğu hasılatlara göre çoktan aza doğru listeleyin",
            "5- Rastgele film getirin",
            "6- Kullanıcıdan alınan değerin filmin konusunda geçenleri listeleyin",
            "7- Türlere göre filmleri listeleyin",
            "8- Kullanıcıdan alınan tür'e göre filmleri listeleyin",
            "9- Yönetmenlere göre filmleri listeleyin",
            "10- Oyunculara göre filmleri listeleyin"
        };
        public static void GetMainMenu()
        {
            foreach (var item in MainMenuArray)
            {
                Console.WriteLine(item);
            }
        }
        public static int GetSelectionFromMainMenu()
        {
            int secim = 0;
            Console.Write("Bir secim yapiniz: ");
            try
            {
                secim = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GetSelectionFromMainMenu();
            }
            if (secim <1 || secim > 10)
            {
                Console.WriteLine("Gecerli bir secim yapiniz!");
                GetSelectionFromMainMenu();
                return 0;
            }
            else { return secim;}

        }
    }
}
