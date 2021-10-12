using System;

public class Soal3
{
    public static void Main(string[] args)
    {
        int number = 0;
        do
        {
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            int hasil = number;
            for (int i = number - 1; i > 0; i--)
            {
                hasil *= i;
            }
            Console.WriteLine("Factorial of " + number + " is: " + hasil);
            Console.WriteLine("-------------------------");
        }
        while (number != 0);
    }
}