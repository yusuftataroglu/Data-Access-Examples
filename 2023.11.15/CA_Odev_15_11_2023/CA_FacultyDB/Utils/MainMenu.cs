namespace CA_FacultyDB.Utils
{
    public class MainMenu
    {
        public static string[] MenuArray { get; set; } = new string[]
        {
            "1- Ogrenciler",
            "2- Bolumler",
            "3- Dersler",
            "4- Akademik Personeller",
            "5- Idari Personeller",
            "6- Sosyal Kulupler"
        };
        public static void GetMenu()
        {
            Console.WriteLine("*** Muhendislik Fakultesi Veri Tabani ***\n");
            Console.WriteLine("Lutfen asagidan islem yapmak istediginiz kategoriyi seciniz.");
            foreach (var item in MenuArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
