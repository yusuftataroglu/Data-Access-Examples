using CA_FacultyDB.Models;

namespace CA_FacultyDB.Utils
{
    public static class TakeAction
    {
        public static FacultyOdevDbContext Context { get; set; } = new FacultyOdevDbContext();
        public static List<Ogrenciler> ogrenciList = new List<Ogrenciler>();

        public static void Read()
        {
            var result = Context.Ogrencilers.Select(x => new
            {
                x.Id,
                x.İsim,
                x.Soyisim,
                x.TcNo,
                x.ÖğrenciNo,
                x.DoğumTarihi,
                x.DoğumYeri,
                x.TelNo,
                x.İkametgahAdresi,
            }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void Create()
        {
            Ogrenciler ogrenci = new Ogrenciler();

            Console.Write("Ogrenci adini giriniz: ");
            ogrenci.İsim = Console.ReadLine();
            Console.Write("Ogrenci soyadini giriniz: ");
            ogrenci.Soyisim = Console.ReadLine();

            bool flag = true;
            foreach (var item in Context.Ogrencilers)
            {
                if (item.İsim == ogrenci.İsim && item.Soyisim == ogrenci.Soyisim)
                {
                    Console.WriteLine("Bu ogrenci zaten kayitli!\n");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Context.Ogrencilers.Add(ogrenci);
                Context.SaveChanges();
                Console.WriteLine("Ogrenci basariyla eklendi!\n");
            }
        }

        public static void Update()
        {
            Ogrenciler ogrenci = new Ogrenciler();
            Console.Write("Bilgilerini guncellemek istediginiz ogrencinin adini giriniz: ");
            ogrenci.İsim = Console.ReadLine();
            bool flag = false;
            foreach (var item in Context.Ogrencilers)
            {
                if (item.İsim == ogrenci.İsim)
                {
                    flag = true;
                    Console.WriteLine($"Guncellenecek ogrenci: Isim: {item.İsim} Soyisim: {item.Soyisim} Ogrenci No: {item.ÖğrenciNo} Tc No: {item.TcNo}");
                    if (Confirmation.ConfirmUpdate())
                    {
                        Console.Write("Ogrenci ismini giriniz: ");
                        ogrenci.İsim = Console.ReadLine();
                        Console.Write("Ogrenci soyismini giriniz: ");
                        ogrenci.Soyisim = Console.ReadLine();
                        Console.Write("Ogrenci numarasini giriniz: ");
                        ogrenci.ÖğrenciNo = Console.ReadLine();
                        Console.Write("Ogrenci Tc No giriniz: ");
                        ogrenci.TcNo = Console.ReadLine();
                        Console.WriteLine("\n****Ogrenci bilgileri guncellendi!****");
                        Console.WriteLine($"Eski ogrenci bilgileri: Isim: {item.İsim} Soyisim: {item.Soyisim} Ogrenci No: {item.ÖğrenciNo} Tc No: {item.TcNo}\nYeni ogrenci bilgileri: Isim: {ogrenci.İsim} Soyisim: {ogrenci.Soyisim} Ogrenci No: {ogrenci.ÖğrenciNo} Tc No: {ogrenci.TcNo}");
                        item.İsim = ogrenci.İsim;
                        item.Soyisim = ogrenci.Soyisim;
                        item.ÖğrenciNo = ogrenci.ÖğrenciNo;
                        item.TcNo = ogrenci.TcNo;
                        Context.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("Ogrenci bilgileri guncellenmedi!");
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Boyle bir ogrenci bulunamadı!");
            }

        }

        public static void Delete()
        {
            Ogrenciler ogrenci = new Ogrenciler();
            Console.Write("Silmek istediginiz ogrencinin adini giriniz: ");
            ogrenci.İsim = Console.ReadLine();
            bool flag = false;
            foreach (var item in Context.Ogrencilers)
            {
                if (item.İsim == ogrenci.İsim)
                {
                    flag = true;
                    ogrenciList.Add(item);
                }
                else
                {
                    flag = false;
                }
            }
            if (flag)
            {
                Console.WriteLine("Bu isimde bulunan ogrenciler asagidadir.");
                foreach (Ogrenciler item in ogrenciList)
                {
                    Console.WriteLine($"Ogrenci ID: {item.Id} Isim: {item.İsim} Soyisim: {item.Soyisim} Ogrenci No: {item.ÖğrenciNo} Tc No: {item.TcNo}");
                }
                int id = Confirmation.ConfirmDeleteByID();
                if (Confirmation.ConfirmDelete())
                {
                    Ogrenciler silincekOgrenci = Context.Ogrencilers.Find(id);
                    Context.Ogrencilers.Remove(silincekOgrenci);
                    Console.WriteLine("****Ogrenci basariyla silindi!****");
                    Context.SaveChanges();
                }
            }
        }

    }
}
