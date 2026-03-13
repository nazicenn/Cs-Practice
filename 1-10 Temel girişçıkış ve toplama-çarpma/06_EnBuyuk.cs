using System;

class Program
{
    static void Main()
    {
        Console.Write("Lutfen 1. sayiyi gir: ");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.Write("Lutfen 2. sayiyi gir: ");
        int sayi2 = int.Parse(Console.ReadLine());

        Console.Write("Lutfen 3. sayiyi gir: ");
        int sayi3 = int.Parse(Console.ReadLine());

        int enBuyuk = sayi1;

        if(sayi2 > enBuyuk)
            enBuyuk = sayi2;
        if(sayi3 > enBuyuk)
            enBuyuk = sayi3;

        Console.WriteLine("En buyuk sayi: " + enBuyuk);
    }
}