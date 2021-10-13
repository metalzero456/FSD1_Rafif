using System;

namespace pro3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilih = 0;
            do
            {
                Console.WriteLine($"======= Silahkan Pilih Menu =======");
                Console.WriteLine($"1. Pesawat Tempur");
                Console.WriteLine($"2. Biodata");
                Console.WriteLine($"3. Penjumlahan dan Perkalian");
                Console.WriteLine($"4. Tentang Saya");
                Console.Write($"0. Keluar dari Program\nPilih -> ");
                pilih = int.Parse(Console.ReadLine());
                switch (pilih)
                {
                    case 1:
                        PesawatTempur tempur = new PesawatTempur();
                        Console.Write($"Masukan nama pesawat: ");
                        tempur.nama = Console.ReadLine();
                        Console.Write($"Masukan ketinggian terbang: ");
                        tempur.Ketinggian = int.Parse(Console.ReadLine());
                        Console.WriteLine($"-----------------------------");
                        tempur.Terbang();
                        break;
                    case 2:
                        Data datanew = new Data();
                        Console.Write($"Masukan nama anda: ");
                        string nama = Console.ReadLine();
                        Console.Write($"Masukan nomor hp anda: ");
                        int notelp = int.Parse(Console.ReadLine());
                        Console.WriteLine($"-----------------------------");
                        datanew.print(nama);
                        datanew.print(notelp);
                        break;
                    case 3:
                        Bilangan1 bilangan = new Bilangan1();
                        Console.Write($"Masukan Bilangan 1: ");
                        int bil1 = int.Parse(Console.ReadLine());
                        Console.Write($"Masukan Bilangan 2: ");
                        int bil2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"-----------------------------");
                        bilangan.Bilangan(bil1, bil2);
                        bilangan.PenjumlahanPerkalian();
                        bilangan = new Bilangan2();
                        Console.WriteLine($"-----------------------------");
                        bilangan.Bilangan(bil1, bil2);
                        bilangan.PenjumlahanPerkalian();
                        break;
                    case 4:
                        Console.WriteLine($"Nama saya Rafif, saya telah belajar C# selama 5 sesi pertemuan.");
                        Console.WriteLine($"Sesi 1 : Belajar tentang instalasi environment C# - Lancar");
                        Console.WriteLine($"Sesi 2 : Belajar tentang dasar C# (tipe data, variabel, dll) - Lancar");
                        Console.WriteLine($"Sesi 3 : Belajar tentang Programming Logic - Lancar ");
                        Console.WriteLine($"Sesi 4 : Belajar tentang struktur data C# - Lancar");
                        Console.WriteLine($"Sesi 5 : Belajar tentang OOP C# - Ongoing...");
                        break;
                }
            } while (pilih != 0);

        }
    }
}
