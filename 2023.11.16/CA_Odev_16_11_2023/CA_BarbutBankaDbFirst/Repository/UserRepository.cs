using CA_BarbutBankaDbFirst.Abstract;
using CA_BarbutBankaDbFirst.Models;
using CA_BarbutBankaDbFirst.Utils;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_BarbutBankaDbFirst.Repository
{
    public class UserRepository : IBarbutBankaDbUser
    {
        public UserRepository()
        {
            Oyuncu1.Balance = 500M; //todo başlangıç değeri atayamıyorum, sor.
            pc.Balance = 500M;
            context.SaveChanges();
        }

        PlayedGame playedGame = new PlayedGame
        {
            PcScore = 0,
            PlayerScore = 0,
            PlayedDate = DateTime.Now,
        };

        public User pc = new User
        {
            Username = "PC",
            Password = "PC",
            Firstname = "PC",
            Lastname = "PC",
            Balance = 500.0000M
        };
        public User Oyuncu1 = new User();

        public BarbutBankaDbContext context = new BarbutBankaDbContext();
        public DateTime PlayedDate { get; set; }

        public Random rnd = new Random();
        public decimal Oyuncu1YatirilanBakiye { get; set; }
        public decimal Oyuncu2YatirilanBakiye { get; set; }
        public int Oyuncu1GelenZar { get; set; }
        public int Oyuncu2GelenZar { get; set; }

        
        //Giriş yapan kullanıcının bilgilerini almak
        void GetPlayerInformations()
        {
            Oyuncu1 = context.Users.FirstOrDefault(x => x.Firstname == MenuOperation.Isim);
        }

        //Oyuncu bilgileri
        void ShowPlayerInfos()
        {
            Console.WriteLine($"Oyuncu 1 isim: {MenuOperation.Isim} Bakiye: {Oyuncu1.Balance}\nOyuncu 2 isim: {pc.Firstname} bakiye: {pc.Balance}\n");
        }

        //Oyuncularının bakiye girişinin yapılması
        void GetPlayersDepositedBalance()
        {
            Console.Write($"{MenuOperation.Isim} isimli oyuncunun yatırmak istediği bakiye: ");
            try
            {
                Oyuncu1YatirilanBakiye = decimal.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Geçersiz giriş! Tekrar giriniz.");
                GetPlayersDepositedBalance();
            }
        }

        //Girilen bakiyelerin yeterlilik kontrolünün yapılması
        void ShowBalanceConfirmation()
        {
            if (Oyuncu1YatirilanBakiye > Oyuncu1.Balance)
            {
                Console.WriteLine("Yeterli bakiyeniz bulunmamakta! Lütfen geçerli bir bakiye giriniz.");
                GetPlayersDepositedBalance();
            }
            else if (Oyuncu1YatirilanBakiye > pc.Balance)
            {
                Console.WriteLine($"{pc.Firstname} isimli oyuncunun bakiyesinden fazla yatıramazsınız. Lütfen yatırmak istediğiniz bakiyeyi tekrar giriniz.");
                GetPlayersDepositedBalance();
            }
            else if (Oyuncu1YatirilanBakiye <= 0)
            {
                Console.WriteLine("Lütfen pozitif bir tutar giriniz.");
                GetPlayersDepositedBalance();
            }
        }

        //Bakiyelerin güncellenmesi
        void UpdateBalancesBeforeDice()
        {
            Oyuncu2YatirilanBakiye = Oyuncu1YatirilanBakiye;
            Oyuncu1.Balance = Oyuncu1.Balance - Oyuncu1YatirilanBakiye;
            pc.Balance = pc.Balance - Oyuncu2YatirilanBakiye;
            context.SaveChanges();
            //todo tabloda güncellenecek
        }

        //Yatırılan bakiye bilgilerinin gösterilmesi
        void ShowDepositedBalances()
        {
            Console.WriteLine($"{MenuOperation.Isim} isimli oyuncunun yatırdığı bakiye: {Oyuncu1YatirilanBakiye}\n{pc.Firstname} isimli oyuncunun yatırdığı bakiye: {Oyuncu2YatirilanBakiye}\n");
        }

        //Zar atılması
        void Dice()
        {
            Console.WriteLine($"{MenuOperation.Isim} isimli oyuncu zar atıyor...");
            Console.ReadLine();
            Oyuncu1GelenZar = rnd.Next(1, 7);
            Console.WriteLine($"Gelen zar: {Oyuncu1GelenZar}\n");
            Console.WriteLine($"{pc.Firstname} isimli oyuncu zar atıyor...\n");
            Oyuncu2GelenZar = rnd.Next(1, 7);
            Console.WriteLine($"Gelen zar: {Oyuncu2GelenZar}\n");

        }

        //Kazananın belirlenmesi
        void ShowResult()
        {
            if (Oyuncu1GelenZar > Oyuncu2GelenZar)
            {
                Oyuncu1.Balance += Oyuncu1YatirilanBakiye + Oyuncu2YatirilanBakiye;
                playedGame.PlayerScore++;
                Console.WriteLine($"Kazanan oyuncu: {MenuOperation.Isim} Yeni bakiyeler: {MenuOperation.Isim} bakiye: {Oyuncu1.Balance} {pc.Firstname} bakiye: {pc.Balance}\n");
            }
            else if (Oyuncu1GelenZar < Oyuncu2GelenZar)
            {
                pc.Balance += Oyuncu2YatirilanBakiye + Oyuncu1YatirilanBakiye;
                playedGame.PcScore++;
                Console.WriteLine($"Kazanan oyuncu: {pc.Firstname} Yeni bakiyeler: {MenuOperation.Isim} bakiye: {Oyuncu1.Balance} {pc.Firstname} bakiye: {pc.Balance}\n");
            }
            else
            {
                Oyuncu1.Balance += Oyuncu1YatirilanBakiye;
                pc.Balance += Oyuncu2YatirilanBakiye;
                Console.WriteLine("Durum berabere!\n");
            }
            Console.WriteLine($"Skor: {Oyuncu1.Firstname} {playedGame.PlayerScore}:{playedGame.PcScore} {pc.Firstname}");
        }

        //Oyunun devam edip etmediğinin
        void CheckGameStatus()
        {
            if (playedGame.PlayerScore == 5 || pc.Balance <= 0)
            {
                Console.WriteLine($"{MenuOperation.Isim} isimli oyuncu kazandi!\nSkor: {Oyuncu1.Firstname} {playedGame.PlayerScore}:{playedGame.PcScore} {pc.Firstname}");
                Oyuncu1.Balance = 500M;
                UpdatePlayedGamesTable();
                context.SaveChanges();
                //todo değişiklikleri kaydet.
            }
            else if (playedGame.PcScore == 5 || Oyuncu1.Balance <= 0)
            {
                Console.WriteLine($"{pc.Firstname} isimli oyuncu kazandi!\nSkor: {Oyuncu1.Firstname} {playedGame.PlayerScore}:{playedGame.PcScore} {pc.Firstname}");
                Oyuncu1.Balance = 500M;
                UpdatePlayedGamesTable();
                context.SaveChanges(); // update yaparken hata veriyor.
                //todo değişiklikleri kaydet.
            }
            else
            {
                PlayGame();
            }
        }

        void UpdatePlayedGamesTable()
        {
            context.PlayedGames.Add(playedGame);
            // tabloya eklenecek.
        }
        public void PlayGame()
        {
            GetPlayerInformations();
            ShowPlayerInfos();
            GetPlayersDepositedBalance();
            ShowBalanceConfirmation();
            UpdateBalancesBeforeDice();
            ShowDepositedBalances();
            Dice();
            ShowResult();
            CheckGameStatus();
            UpdatePlayedGamesTable();
        }
    }
}
