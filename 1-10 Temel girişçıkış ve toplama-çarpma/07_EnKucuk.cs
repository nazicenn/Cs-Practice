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

        int enKucuk = sayi1;

        if(sayi2 < enKucuk)
            enKucuk = sayi2;
        if(sayi3 < enKucuk)
            enKucuk = sayi3;

        Console.WriteLine("En kucuk sayi: " + enKucuk);
    }
}