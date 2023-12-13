using CA_BarbutBankaDbFirst.Models;
using CA_BarbutBankaDbFirst.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CA_BarbutBankaDbFirst.Utils
{
    public static class MenuOperation
    {
        public static BarbutBankaDbContext context = new BarbutBankaDbContext();

        public static string[] MenuSecimMenusu = new string[]
        {
            "1- Oyun işlemleri",
            "2- Bakiye işlemleri"
        };
        public static string[] OyunMenusu { get; set; } = new string[]
        {
            "1- Oyun oyna",
            "2- Oynanan oyunlar"
        };

        public static string[] BakiyeMenusu { get; set; } = new string[]
        {
            "1- Bakiye görüntüle",
            "2- Bakiye yükle"
        };
        public static string KullaniciAdi { get; set; }
        public static string Sifre { get; set; }
        public static string Isim { get; set; }
        public static string Soyisim { get; set; }
        public static string MenuSecim { get; set; }
        public static string AltMenuSecim { get; set; }
        public static decimal Tutar { get; set; }
        public static int MesajSayaci { get; set; } = 0;


        public static void GetWelcomeMessage()
        {
            if (MesajSayaci==0)
            {
                Console.WriteLine($"Hoş geldiniz sayın {Isim} {Soyisim}\n");
            }
            MesajSayaci++;
        }
        public static void GetLoginMenu()
        {
            //Giriş işlemi
            Console.Write("Kullanıcı adı: ");
            KullaniciAdi = Console.ReadLine();
            Console.Write("Sifre: ");
            Sifre = Console.ReadLine();
        }

        public static bool CheckLoginInfos()
        {
            bool flag = false;
            //Giriş bilgilerinin veri tabanındaki bilgilere göre teyit edilmesi
            var kullaniciBilgileriListesi = context.Users.ToList();

            foreach (var item in kullaniciBilgileriListesi)
            {
                if (item.Username.Trim() == KullaniciAdi && item.Password.Trim() == Sifre) //select metoduyla gelen verilerin sonunda boşluk var.
                {
                    flag = true;
                    Isim = item.Firstname;
                    Soyisim = item.Lastname;
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }

        public static void GetOperationMenu()
        {
            foreach (var item in MenuSecimMenusu)
            {
                Console.WriteLine(item);
            }
        }
        public static string GetSelectionFromOperationMenu()
        {
            Console.Write("Bir işlem seçiniz: ");
            MenuSecim = Console.ReadLine();
            if (MenuSecim != "1" && MenuSecim != "2")
            {
                Console.WriteLine("Lütfen geçerli bir işlem seçiniz!");
                GetOperationMenu();
            }
            return MenuSecim;
        }
        public static void GetGameMenu()
        {
            foreach (var item in OyunMenusu)
            {
                Console.WriteLine(item);
            }
        }
        public static void GetBalanceMenu()
        {
            foreach (var item in BakiyeMenusu)
            {
                Console.WriteLine(item);
            }
        }
        public static string GetGameMenuSelection()
        {
            Console.Write("Bir işlem seçiniz: ");
            AltMenuSecim = Console.ReadLine();
            if (AltMenuSecim != "1" && AltMenuSecim != "2")
            {
                Console.WriteLine("Lütfen geçerli bir işlem seçiniz!");
                GetGameMenu();
            }
            return AltMenuSecim;
        }
        public static string GetBalanceMenuSelection()
        {
            Console.Write("Bir işlem seçiniz: ");
            AltMenuSecim = Console.ReadLine();
            if (AltMenuSecim != "1" && AltMenuSecim != "2")
            {
                Console.WriteLine("Lütfen geçerli bir işlem seçiniz!");
                GetBalanceMenu();
            }
            return AltMenuSecim;
        }


    }
}
