using System;

class Program
{
    static void Main()
    {
        Console.Write("Lutfen bir sayi gir: ");
        int sayi = int.Parse(Console.ReadLine());

        int kare = sayi * sayi;
        Console.WriteLine("Girdiginiz sayinin karesi: " + kare);
    }
}