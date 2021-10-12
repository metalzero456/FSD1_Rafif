using System;

public class Data2
{
    public static void Main(string[] args)
    {
        Console.Write("Berapa tipe komponen? ");
        int jumlahKomponen = int.Parse(Console.ReadLine());
        string[] contoh = new string[jumlahKomponen];
        for (int i = 0; i < contoh.Length; i++)
        {
            Console.Write($"Masukan komponen ke - {i + 1}: ");
            contoh[i] = Console.ReadLine();
        }

        Console.WriteLine("");
        Console.WriteLine("Menampilkan semua data dalam array");


        foreach (string contoh1 in contoh)
        {
            Console.WriteLine(contoh1);
        }
    }


}