using System;

public class HitungLuas
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--------Pilih Bidang Datar---------");
        Console.WriteLine("1. Persegi");
        Console.WriteLine("2. Persegi Panjang");
        Console.Write("Input: ");
        int pilih = int.Parse(Console.ReadLine());
        double luas = 0;
        switch (pilih)
        {
            case 1:
                Console.Write("Sisi: ");
                int sisi = int.Parse(Console.ReadLine());
                luas = Math.Pow(sisi, 2);
                Console.WriteLine("Luas: " + luas);
                break;
            case 2:
                Console.Write("Panjang: ");
                int panjang = int.Parse(Console.ReadLine());
                Console.Write("Lebar: ");
                int lebar = int.Parse(Console.ReadLine());
                luas = panjang * lebar;
                Console.WriteLine("Luas: " + luas);
                break;
        }
    }
}