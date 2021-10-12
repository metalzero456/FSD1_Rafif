using System;

public class Logika8
{
    public static void Main(string[] args)
    {
        Console.Write("Angka awal: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Angka akhir: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Operasi: ");
        char op = char.Parse(Console.ReadLine());
        int i = 1;

        int tmp = a;
        do
        {
            int hasil = 0;
            switch (op)
            {

                case '+':
                    Console.WriteLine($"angka = {a} : {hasil = a + tmp}");
                    break;
                case '-':
                    Console.WriteLine($"angka = {a} : {hasil = a -= tmp}");
                    break;
                case '*':
                    Console.WriteLine($"angka = {a} : {hasil = a *= tmp}");
                    break;
            }

            i++;
            a++;
        } while (a <= b);
    }


}