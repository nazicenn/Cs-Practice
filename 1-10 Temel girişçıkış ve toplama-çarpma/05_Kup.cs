using System;

class Program
{
    static void Main()
    {
        Console.Write("Lutfen bir sayi gir: ");
        int sayi = int.Parse(Console.ReadLine());

        int kup = sayi * sayi * sayi;
        Console.WriteLine("Girdiginiz sayinin kupu: " + kup);
    }
}