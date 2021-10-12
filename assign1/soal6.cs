using System;

public class Soal6
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a word: ");
        string number = Console.ReadLine();
        number = number.ToLower(System.Globalization.CultureInfo.CurrentCulture);
        char[] arr = number.ToCharArray();
        Console.Write("Reversed word: ");
        bool isPalindrome = true;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != arr[arr.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine($"\nMerupakan palindrom: {isPalindrome}");
    }
}