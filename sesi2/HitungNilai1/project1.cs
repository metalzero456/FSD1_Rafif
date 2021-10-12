using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int bil1;
        int bil2;
        int hasil = 0;
        string operasi;

        Console.WriteLine("--------- KALKULATOR ---------");
        Console.Write("Bilangan 1: ");
        bil1 = int.Parse(Console.ReadLine());

        Console.Write("Operasi (+ - * /): ");
        operasi = Console.ReadLine();

        Console.Write("Bilangan 2: ");
        bil2 = int.Parse(Console.ReadLine());

        switch (operasi)
        {
            case "+":
                hasil = bil1 + bil2;
                break;
            case "-":
                hasil = bil1 - bil2;
                break;
            case "*":
                hasil = bil1 * bil2;
                break;
            case "/":
                hasil = bil1 / bil2;
                break;
            default:
                Console.WriteLine("Operasi yang dimasukan tidak valid!");
                break;
        }

        Console.WriteLine("Hasil: " + hasil);


    }
}