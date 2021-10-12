using System;

public class Logika3
{
    public static void Main(string[] args)
    {
        string Username;
        string Password;

        Console.Write("Username: ");
        Username = Console.ReadLine();
        Console.Write("Password: ");
        Password = Console.ReadLine();

        if (Username == "ocbc" && Password == "bootcamp")
        {
            Console.WriteLine($"Selamat datang {Username}, anda telah berhasil login.");
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


    }

}