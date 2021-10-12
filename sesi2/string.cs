using System;

public class String
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");
        Console.Write("Masukan nama: ");
        string name = Console.ReadLine();
        Console.Write("Masukan alamat: ");
        string alamat = Console.ReadLine();
        Console.Write("Masukan umur: ");
        int umur = int.Parse(Console.ReadLine());

        Console.WriteLine("\nTerima Kasih!");
        Console.WriteLine("Data Berikut");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Alamat: {alamat}");
        Console.WriteLine($"Umur: {umur} tahun");
        Console.WriteLine("SUDAH DISIMPAN!");
    }

}