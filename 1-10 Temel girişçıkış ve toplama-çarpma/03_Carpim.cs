using System;

class Program
{
    static void Main()
    {
        Console.Write("Lutfen 1. sayiyi gir: ");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.Write("Lutfen 2. sayiyi gir: ");
        int sayi2 = int.Parse(Console.ReadLine());

        int carpim = sayi1 * sayi2;
        Console.WriteLine("Iki sayinin carpimi: " + carpim);
    }
}