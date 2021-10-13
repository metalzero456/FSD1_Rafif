using System;


public class Pesawat
{
    public string nama;
    protected int ketinggian;

    //Setter and Getter Method
    public int Ketinggian
    {
        get { return ketinggian; }
        set { ketinggian = value; }
    }

    public void Terbang()
    {
        Console.WriteLine($"Pesawat dengan nama {this.nama}, sedang take off");
    }

    public void SudahTerbang()
    {
        Console.WriteLine($"Pesawat sekarang berada pada ketinggian {this.ketinggian} mdpl");

    }
}
