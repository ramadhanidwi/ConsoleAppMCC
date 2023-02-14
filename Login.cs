using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMCC;

class Login : Create
{
public void Masuk()
        {
            Console.Clear();
            Console.WriteLine("== LOGIN ==");
            Console.Write("USER NAME : ");
            string input_uname = Console.ReadLine();

            Console.Write("PASSWORD : ");
            string input_password = Console.ReadLine();

            bool cek = false;

        foreach (var item in kumpulData)
        {
            if (item.user_name == input_uname && item.password == input_password)
            {
                cek = true;
                break;
            }
        }
        if (cek == true)
        {
            Console.WriteLine("Login Berhasil");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Login Gagal");
            Console.ReadKey();
        }
    }
}
