using System;

namespace pro1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instansiasi Object
            Laptop laptop1 = new Laptop();

            //Akses atribut
            Console.Write($"Input merk laptop: ");
            laptop1.SetMerk(Console.ReadLine());
            Console.Write($"Input jumlah RAM (GB): ");
            laptop1.SetRam(int.Parse(Console.ReadLine()));
            Console.Write($"Input jumlah Storage (GB): ");
            laptop1.SetStorage(int.Parse(Console.ReadLine()));

            //Tampilkan
            Console.WriteLine($"\nMerk Laptop adalah {laptop1.merk}");
            Console.WriteLine($"Kapasitas RAM adalah {laptop1.ram} GB");
            Console.WriteLine($"Kapasitas Storage adalah {laptop1.storage} GB");

            //Akses Method
            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();
        }
    }
}
