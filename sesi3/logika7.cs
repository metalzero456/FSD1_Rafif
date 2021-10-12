using System;

public class Logika7
{
    public static void Main(string[] args)
    {
        Console.Write("Angka awal: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Angka akhir: ");
        int b = int.Parse(Console.ReadLine());
        for (int i = 1; a <= b; i++)
        {
            Console.WriteLine($"Nilai a ke {i} = {a}");
            a++;
        }
    }

}