using System;

public class Logika2
{
    public static void Main(string[] args)
    {
        Console.Write("Masukan Nama: ");
        string name = Console.ReadLine();
        Console.Write("Masukan Nilai: ");
        int grade = int.Parse(Console.ReadLine());
        Console.WriteLine("---------------------------------");
        if (grade == 0)
        {
            Console.WriteLine("Nilai Kamu F");
        }
        else if (grade < 50)
        {
            Console.WriteLine("Nilai Kamu D");
        }
        else if (grade < 60)
        {
            Console.WriteLine("Nilai Kamu C");
        }
        else if (grade < 80)
        {
            Console.WriteLine("Nilai Kamu B");
        }
        else
        {
            Console.WriteLine("Nilai Kamu A");
        }

    }

}