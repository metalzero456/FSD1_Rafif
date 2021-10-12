using System;

public class Statement
{
    public static void Main(string[] args)
    {
        Console.Write("Input Nama Customer: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name);
        Console.WriteLine("Selamat Datang di Program Bootcamp OCBC");
        Console.WriteLine("Tahap 1 saya akan belajar C#");
        string input = "";
        int harga = 0;
        int jumlah = 0;
        int totalSemua = 0;
        while (input != "selesai")
        {
            Console.Write("\nMasukan nama course (ketik 'selesai' apabila sudah selesai): ");
            input = Console.ReadLine();
            if (input == "selesai")
            {
                break;
            }
            Console.Write("Masukan harga course: ");
            harga = int.Parse(Console.ReadLine());
            Console.Write("Masukan berapa unit: ");
            jumlah = int.Parse(Console.ReadLine());

            int total = harga * jumlah;
            totalSemua += total;
            Console.WriteLine("\n---------- Produk Ditambahkan! ----------");
            Console.WriteLine("course " + input + ", Harga: " + harga + ",Jumlah: " + jumlah + ",Total Harga: " + total);
        }
        Console.WriteLine("----------------------------------");
        Console.Write("Total Harga Keseluruhan: " + totalSemua);
    }
}