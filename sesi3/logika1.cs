using System;

public class Logika1
{
    public static void Main(string[] args)
    {
        Console.Write("Masukan Angka Pertama: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Masukan Angka Kedua: ");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("Angka Pertama lebih besar dari Angka Kedua");
        }
        else if (a < b)
        {
            Console.WriteLine("Angka Kedua lebih besar dari Angka Pertama");
        }
        else
        {
            Console.WriteLine("Angka Kedua lebih sama dengan Angka Pertama");
        }

    }

}