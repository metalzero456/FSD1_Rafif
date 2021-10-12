using System;

public class Soal5
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        string number = Console.ReadLine();
        char[] arr = number.ToCharArray();
        string[] hasil = new string[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            switch (arr[i])
            {
                case '1':
                    hasil[i] = "one";
                    break;
                case '2':
                    hasil[i] = "two";
                    break;
                case '3':
                    hasil[i] = "three";
                    break;
                case '4':
                    hasil[i] = "four";
                    break;
                case '5':
                    hasil[i] = "five";
                    break;
                case '6':
                    hasil[i] = "six";
                    break;
                case '7':
                    hasil[i] = "seven";
                    break;
                case '8':
                    hasil[i] = "eight";
                    break;
                case '9':
                    hasil[i] = "nine";
                    break;
                case '0':
                    hasil[i] = "zero";
                    break;
            }
        }

        Console.WriteLine("Hasil konversi ke String: ");
        foreach (string str in hasil)
        {
            Console.Write(str + " ");
        }
    }
}