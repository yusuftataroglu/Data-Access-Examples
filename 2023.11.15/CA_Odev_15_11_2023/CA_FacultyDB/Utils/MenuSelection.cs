namespace CA_FacultyDB.Utils
{
    public static class MenuSelection
    {
        public static string Secim { get; set; }

        public static string GetSelection()
        {
            Secim = Console.ReadLine();
            if (Secim != "1" && Secim != "2" && Secim != "3" && Secim != "4" && Secim != "5" && Secim != "6")
            {
                Console.WriteLine("Lutfen gecerli bir secim yapiniz!");
                GetSelection();
                return null;
            }
            else
            {
                return Secim;
            }
        }
    }
}
