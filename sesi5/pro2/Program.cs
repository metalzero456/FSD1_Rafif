using System;

namespace pro2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            Console.Write($"Masukan nama pesawat: ");
            pesawat.nama = Console.ReadLine();
            Console.Write($"Masukan ketinggian terbang: ");
            pesawat.Ketinggian = int.Parse(Console.ReadLine());

            pesawat.Terbang();
            pesawat.SudahTerbang();
        }
    }
}
