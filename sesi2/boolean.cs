using System;

public class Boolean
{
    public static void Main(string[] args)
    {
        bool nilai1 = true;
        bool nilai2 = false;
        Console.WriteLine("Nilai A " + nilai1);
        Console.WriteLine("Nilai B " + nilai2);
        bool nilai3 = (nilai1 && nilai2);
        Console.WriteLine("Nilai A && Nilai B " + nilai3);
        bool nilai4 = (nilai1 || nilai2);
        Console.WriteLine("Nilai A || Nilai B " + nilai4);
    }

}