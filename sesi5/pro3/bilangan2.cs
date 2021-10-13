using System;

public class Bilangan2 : Bilangan1
{
    public override void PenjumlahanPerkalian()
    {
        Console.WriteLine($"Overriding2");
        Console.WriteLine($"Hasil pengurangan angka {this.bil1} dan angka {this.bil2} adalah {this.bil1 - this.bil2}");
        Console.WriteLine($"Hasil pembagian angka {this.bil1} dan angka {this.bil2} adalah {this.bil1 / this.bil2}");
    }
}