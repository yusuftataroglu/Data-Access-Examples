namespace CA_FacultyDB.Utils
{
    public static class Confirmation
    {
        public static bool Confirmed { get; set; }

        public static bool ConfirmUpdate()
        {
            Console.WriteLine("Bu ogrencinin bilgilerini guncellemek istiyor musunuz? (e/h)");

            string value = "";
            value = Console.ReadLine();

            if (value.ToLower() == "e")
            {
                Confirmed = true;
            }
            else if (value.ToLower() == "h")
            {
                Confirmed = false;
            }
            else
            {
                Console.WriteLine("Gecerli bir harf giriniz!");
                ConfirmUpdate();
            }
            return Confirmed;
        }

        public static int ConfirmDeleteByID()
        {
            int id = 0;
            Console.Write("Silmek istediginiz ogrencinin ID'sini giriniz: ");
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ConfirmDeleteByID();
            }

            foreach (var item in TakeAction.ogrenciList)
            {
                if (item.Id != id)
                {
                    Console.WriteLine("Gecerli bir ID giriniz!");
                    ConfirmDeleteByID();
                }
            }
            return id;
        }

        public static bool ConfirmDelete()
        {
            bool flag = false;
            string harfSecim = "";
            Console.WriteLine("Ogrenciyi silmek istediginizden emin misiniz? (e/h)");
            harfSecim = Console.ReadLine();
            if (harfSecim.ToLower() == "e")
            {
                flag = true;
            }
            else if (harfSecim.ToLower() == "h")
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("Gecerli bir harf giriniz!");
                ConfirmDelete();
            }
            return flag;
        }
    }
}
