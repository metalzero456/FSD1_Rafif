using System;

public class Data
{
    public string nama;
    public double notelp;
    public void print(string nama)
    {
        this.nama = nama;
        Console.WriteLine($"Namanya adalah {this.nama}");
    }

    public void print(double notelp)
    {
        this.notelp = notelp;
        Console.WriteLine($"Nomor HP: {this.notelp}");

    }
}