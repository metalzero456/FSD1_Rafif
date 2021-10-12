using System;

public class Soal4
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string number = Console.ReadLine();
        char[] arr = number.ToCharArray();
        Console.Write("Reversed Number: ");
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }
    }
}