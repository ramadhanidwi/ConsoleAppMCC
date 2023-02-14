using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMCC;

public class Create : Program
{

    public int aydi { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string password { get; set; }
    public string user_name { get; set; }

    public void buatAkun()
    {
        Console.Clear();
        Create simpenData = new Create();
        Console.WriteLine("== Create User ==");
        for(int i = 0; i <= kumpulData.Count; i++) 
        {
            simpenData.aydi = i + 1;
        }
        Console.Write("First Name : ");
        string nama_pertama = Console.ReadLine();
        simpenData.first_name = nama_pertama;

        Console.Write("Last Name : ");
        string nama_terahir = Console.ReadLine();
        simpenData.last_name = nama_terahir;
        bool cek = true;
        do
        {
            Console.Write("Password : ");
            string input_password = Console.ReadLine();
            if (input_password.Length >= 8)
            {
                if (input_password.Any(char.IsUpper))
                {
                    if (input_password.Any(char.IsLower))
                    {
                        if (input_password.Any(char.IsNumber))
                        {
                            simpenData.password = input_password;
                            Console.WriteLine("Data User Berhasil Dibuat");
                            Console.WriteLine("Lanjut Membuat Akun ? Ya / Tidak");
                            string kepastian = Console.ReadLine();
                            if (kepastian == "Ya")
                            {
                                simpenData.user_name = simpenData.first_name[..2] + simpenData.last_name[..2];
                                kumpulData.Add(simpenData);
                                cek = true;
                                buatAkun();
                            }
                            else if (kepastian == "Tidak")
                            {
                                simpenData.user_name = simpenData.first_name[..2] + simpenData.last_name[..2];
                                kumpulData.Add(simpenData);
                                cek = false;
                                break;
                            }
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Password must have at least 8 characters \nwith at least one Capital Letter, at elast one lower \ncase letter and at least one number.");
            }
        } while (cek);

    }
}

