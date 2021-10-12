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
            switch (op)
            {
                case '+':
                    a += tmp;
                    break;
                case '-':
                    a -= tmp;
                    break;
                case '*':
                    a *= tmp;
                    break;
            }
            Console.WriteLine($"i = {i} : {a}");
            i++;
            a++;
        } while (a <= b);
    }


}