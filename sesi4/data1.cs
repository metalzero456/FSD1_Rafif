using System;

public class Data1
{
    public static void Main(string[] args)
    {
        int[] aAngka = new int[5];
        string[] aNama = new string[] { "Joni", "Meri", "David" };
        object[] aObjek = { 20.33, "Lorem ipsum", DateTime.Now, true, 'D' };

        for (int i = 0; i < aAngka.Length; i++)
        {
            Console.Write($"Masukan angka ke- {i + 1}: ");
            aAngka[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n\nArray aAngka:");
        foreach (int item in aAngka)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine("\n\nArray aNama:");
        foreach (string item in aNama)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine("\n\nArray aObjek:");
        foreach (object item in aObjek)
        {
            Console.Write($"{item} ");
        }
    }


}