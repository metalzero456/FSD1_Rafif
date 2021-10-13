using System;

public class Bilangan1
{
    public int bil1, bil2;
    public void Bilangan(int angka1, int angka2)
    {
        bil1 = angka1;
        bil2 = angka2;
    }

    public virtual void PenjumlahanPerkalian()
    {
        Console.WriteLine($"Overriding1");
        Console.WriteLine($"Hasil penjumlahan angka {this.bil1} dan angka {this.bil2} adalah {this.bil1 + this.bil2}");
        Console.WriteLine($"Hasil perkalian angka {this.bil1} dan angka {this.bil2} adalah {this.bil1 * this.bil2}");
    }
}