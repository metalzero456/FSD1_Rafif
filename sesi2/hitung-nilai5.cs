using System;

public class HitungNilai5
{
    public static void Main(string[] args)
    {

        Console.WriteLine("==== LOGIN ====");
        Console.Write("Username: ");
        string user = Console.ReadLine();
        Console.Write("Password: ");
        string pass = Console.ReadLine();
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Jenis Kelamin (1 = Laki-laki / 2 = Perempuan): ");
        string inputKelamin = Console.ReadLine();
        string kelamin = "";
        if (inputKelamin == "1")
        {
            kelamin = "Laki-laki";
        }
        else if (inputKelamin == "2")
        {
            kelamin = "Perempuan";
        }
        Console.Write("Status Nikah (true / false): ");
        bool nikah = bool.Parse(Console.ReadLine());
        double hasil = 0;
        if (user == "rafiftaq" && pass == "OCBC" && age > 18)
        {
            Console.WriteLine("==== OPERASI ARITMATIKA ====");
            Console.Write("Nilai 1: ");
            double nilai1 = double.Parse(Console.ReadLine());
            Console.Write("Nilai 2: ");
            double nilai2 = double.Parse(Console.ReadLine());
            Console.Write("Nilai 3: ");
            double nilai3 = double.Parse(Console.ReadLine());
            Console.Write("Operasi (+ - * /): ");
            string operasi = Console.ReadLine();
            switch (operasi)
            {
                case "+":
                    hasil = nilai1 + nilai2 + nilai3;
                    break;
                case "-":
                    hasil = nilai1 - nilai2 - nilai3;
                    break;
                case "*":
                    hasil = nilai1 * nilai2 * nilai3;
                    break;
                case "/":
                    hasil = nilai1 / nilai2 / nilai3;
                    break;
                default:
                    Console.WriteLine("Input Operasi Salah.");
                    break;
            }
            Console.WriteLine("==== HASIL OUTPUT ====");
            Console.WriteLine("Hasil Operasi: " + hasil);
            Console.WriteLine("Username: " + user);
            Console.WriteLine("Umur: " + age);
            Console.WriteLine("Jenis kelamin: " + kelamin);
            Console.WriteLine("Sudah menikah? " + nikah);
        }
        else
        {
            Console.WriteLine("LOGIN GAGAL! Periksa kembali username, password, dan umur.");
        }



    }
}