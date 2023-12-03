using CA_FacultyDB.Models;
using CA_FacultyDB.Utils;

namespace CA_Odev_15_11_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MainMenu.GetMenu();
                MenuSelection.GetSelection();
                switch (MenuSelection.Secim)
                {
                    case "1":
                        StudentMenu.GetStudentMenu();
                        StudentMenuSelection.GetSelection();
                        switch (StudentMenuSelection.Secim)
                        {
                            case "1":
                                TakeAction.Read();
                                break;
                            case "2":
                                TakeAction.Create();
                                break;
                            case "3":
                                TakeAction.Update();
                                break;
                            case "4":
                                TakeAction.Delete();
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