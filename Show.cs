using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMCC;

class Show : Create
{
    public void TampilUser()
    {
        Console.Clear();
        bool cek = true;
        do
        {
            Console.WriteLine("== SHOW USER ==");
            foreach (var item in kumpulData)
            {
                Console.WriteLine("========================");
                Console.WriteLine($"Id          : {item.aydi}");
                Console.WriteLine($"Name        : {item.first_name} {item.last_name}");
                Console.WriteLine($"Username    : {item.user_name}");
                Console.WriteLine($"Password    : {item.password}");
                Console.WriteLine("========================");
            }
            Console.WriteLine("\nMenu");
            string[] menu_edit = { "Edit User", "Delete User", "Back" };
            for (int i = 0; i < menu_edit.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu_edit[i]}");
            }
            Console.Write("Pilih Menu Edit : ");
            int pilih = Convert.ToInt32(Console.ReadLine());
            bool status = true;
            do
            {
                switch (pilih)
                {
                    case 1:
                        Console.Write("Id Yang Ingin Diubah :");
                        int inputan_id = Convert.ToInt32(Console.ReadLine());
                        foreach (var item in kumpulData)
                        {
                            if (inputan_id == item.aydi)
                            {
                                Console.Write("First Name : ");
                                string nama_awal = Console.ReadLine();
                                item.first_name = nama_awal;

                                Console.Write("Last Name : ");
                                string nama_akhir = Console.ReadLine();
                                item.last_name = nama_akhir;
                                bool opsi = true;
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
                                                    item.password = input_password;
                                                    item.user_name = item.first_name[..2] + item.last_name[..2];
                                                    cek = false;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Password must have at least 8 characters \nwith at least one Capital Letter, at elast one lower \ncase letter and at least one number.");
                                    }
                                } while (opsi);
                                Console.WriteLine("Data User Berhasil Diubah");
                                status = false;
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            Console.WriteLine("Id Tidak Ditemukan");
                            Console.ReadKey();
                            break;
                        }
                        break;
                    case 2:
                        Console.Write("Id Yang Ingin Dihapus : ");
                        int hapus_id = Convert.ToInt32(Console.ReadLine());
                        foreach (var item in kumpulData)
                        {
                            if (item.aydi == hapus_id)
                            {
                                kumpulData.Remove(item);
                            }
                        }
                        Console.WriteLine("Id Berhasil Dihapus");
                        Console.ReadKey();
                        break;
                    case 3:
                        cek = false;
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Id tidak ditemukan");
                        break;
                }
            } while (status);
        } while (cek);
    }
}



