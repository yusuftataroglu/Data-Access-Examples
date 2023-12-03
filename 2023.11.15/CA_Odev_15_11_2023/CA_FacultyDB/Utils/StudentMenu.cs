namespace CA_FacultyDB.Utils
{
    public static class StudentMenu
    {
        public static string[] StudentMenuArray { get; set; } = new string[]
        {
            "1-Ogrencileri listele",
            "2-Ogrenci olustur",
            "3-Ogrenci guncelle",
            "4-Ogrenci sil"
        };
        public static void GetStudentMenu()
        {
            Console.WriteLine("Lutfen asagidan yapmak istediginiz islemi seciniz.");
            foreach (var item in StudentMenuArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
