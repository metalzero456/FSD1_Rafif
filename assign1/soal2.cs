using System;

public class Soal2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("======= PIRAMIDA ANGKA =======");
        Console.Write("Berapa baris tinggi piramida? ");
        int tinggi = int.Parse(Console.ReadLine());
        Console.Write("Puncak Piramida Mau Angka apa? ");
        int angka = int.Parse(Console.ReadLine());
        int angkaAwal = angka;
        for (int i = 1; i <= tinggi; i++)
        {
            for (int j = i; j <= tinggi; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write(angka);
                if (k == i)
                {
                    break;
                }
                angka++;
            }
            for (int l = 1; l < i; l++)
            {
                angka--;
                Console.Write(angka);
            }
            Console.WriteLine();
            angka = angkaAwal;
        }
    }
}