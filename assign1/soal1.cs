using System;

public class Soal1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("======= PIRAMIDA ALFABET =======");
        Console.Write("Berapa baris tinggi piramida? ");
        int tinggi = int.Parse(Console.ReadLine());
        Console.Write("Puncak Piramida Mau Huruf apa? ");
        char huruf = char.Parse(Console.ReadLine());
        char hurufAwal = huruf;
        for (int i = 1; i <= tinggi; i++)
        {
            for (int j = i; j <= tinggi; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write(huruf);
                if (k == i)
                {
                    break;
                }
                huruf++;
            }
            for (int l = 1; l < i; l++)
            {
                huruf--;
                Console.Write(huruf);
            }
            Console.WriteLine();
            huruf = hurufAwal;
        }
    }
}