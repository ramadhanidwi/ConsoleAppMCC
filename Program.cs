using System;
namespace ConsoleAppMCC;


public class Program
{
    public static List<Create> kumpulData = new List<Create>();
    static void Main()
    {
        Menu();
    }

static void Menu()
    {
        bool cek = true;
        do
        {
        Console.WriteLine("== BASIC AUTHENTICATION ==");
        string[] menu_item = { "Create User" , "Show User", "Login User", "Exit"};
        for (int i = 0; i< menu_item.Length; i++)
        {
            Console.WriteLine($"{i+1}. {menu_item[i]}");
        }

        Console.Write("Input : ");
        int pilih_menu = Convert.ToInt32(Console.ReadLine());
        switch (pilih_menu)
        {
            case 1:
                    Console.Clear();
                    Create buatUser = new Create();
                    buatUser.buatAkun();
                    break;
            case 2:
                Show tampilUser = new Show();
                tampilUser.TampilUser();
                break;
            case 3:
                Login lamanLogin = new Login();
                    lamanLogin.Masuk();
                break;
            case 4:
                Console.WriteLine("Exit User");
                cek = false;
                break;
            default:
                Console.WriteLine("Pilihan Menu Tidak Ada");
                Menu();
                break;
            }

        } while (cek);
    }


}