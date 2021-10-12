using System;

public class Logika4
{
    public static void Main(string[] args)
    {
        string Username;
        string Password;

        Console.Write("Username: ");
        Username = Console.ReadLine();
        Console.Write("Password: ");
        Password = Console.ReadLine();
        bool log = false;

        if (Username == "ocbc" && Password == "bootcamp")
        {
            Console.WriteLine($"Selamat datang {Username}, anda telah berhasil login.");
            log = true;
        }
        else if (Username == "ocbc")
        {
            Console.WriteLine("Password anda salah!");
        }
        else if (Password == "bootcamp")
        {
            Console.WriteLine("Username anda salah!");
        }
        else
        {
            Console.WriteLine("Username dan Password anda salah!");
        }

        if (log == true)
        {
            Console.Write("Nilai: ");
            double nilai = Convert.ToDouble(Console.ReadLine());

            if (nilai >= 85)
            {
                Console.WriteLine("Kamu mendapat nilai A");
            }
            else if (nilai >= 65)
            {
                Console.WriteLine("Kamu mendapat nilai B");
            }
            else if (nilai >= 45)
            {
                Console.WriteLine("Kamu mendapat nilai C");
            }
            else if (nilai <= 25)
            {
                Console.WriteLine("Kamu mendapat nilai E");
            }
            else if (nilai == 0)
            {
                Console.WriteLine("Kamu mendapat nilai F");
            }
            else
            {
                Console.WriteLine("Kamu mendapat nilai D");
            }
        }
    }

}