using System;
public class String4
{
    public static void Main()
    {
        string stringawal = "C# membuat string mudah.";

        //Menciptakan sebuah substring.
        string substr = stringawal.Substring(5, 12);

        Console.WriteLine("stringawal: " + stringawal);
        Console.WriteLine("substring: " + substr);
    }
}