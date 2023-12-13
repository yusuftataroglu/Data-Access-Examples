
using CA_BarbutBankaDbFirst.Models;
using CA_BarbutBankaDbFirst.Repository;
using CA_BarbutBankaDbFirst.Utils;

namespace CA_BarbutBankaDbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            BarbutBankaDbContext context = new BarbutBankaDbContext();
            string menuSecim = "";
            string altMenuSecim = "";
            decimal tutar = 0;

            //Login işlemi döngüsü
            while (true)
            {
                MenuOperation.GetLoginMenu();
                if (MenuOperation.CheckLoginInfos())
                {
                    MenuOperation.GetWelcomeMessage();
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış kullanıcı adı veya şifre girdiniz. Tekrar giriniz.");
                    continue;
                }
            }
            //Menü döngüsü
            while (true)
            {
                MenuOperation.GetOperationMenu();
                menuSecim = MenuOperation.GetSelectionFromOperationMenu();
                switch (menuSecim)
                {
                    case "1":
                        MenuOperation.GetGameMenu();
                        altMenuSecim = MenuOperation.GetGameMenuSelection();
                        switch (altMenuSecim)
                        {
                            case "1":
                                UserRepository userRepo = new UserRepository();
                                userRepo.PlayGame();
                                break;
                            case "2":
                                var oynananOyunlar = context.PlayedGames.ToList();
                                foreach (var item in oynananOyunlar)
                                {
                                    Console.WriteLine(item);
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case "2":
                        MenuOperation.GetBalanceMenu();
                        altMenuSecim = MenuOperation.GetBalanceMenuSelection();
                        switch (altMenuSecim)

                        {
                            case "1":
                                var oyuncuBakiye = context.Users.FirstOrDefault(x => x.Firstname == MenuOperation.Isim).Balance;
                                Console.WriteLine(oyuncuBakiye);
                                break;
                            case "2":
                                Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                                try
                                {
                                    tutar = decimal.Parse(Console.ReadLine());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                if (tutar < 1)
                                {
                                    Console.WriteLine("Lütfen en az 1 TL yatırınız.");
                                    MenuOperation.GetBalanceMenuSelection();
                                }
                                else
                                {
                                    var oyuncu = context.Users.FirstOrDefault(x => x.Firstname == MenuOperation.Isim);
                                    oyuncu.Balance += tutar;
                                    Console.WriteLine($"Yeni bakiye: {oyuncu.Balance}");
                                    context.SaveChanges();
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }

            }
        }
    }
}