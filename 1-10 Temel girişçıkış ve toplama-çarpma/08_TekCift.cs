using System;

class Program
{
    static void Main()
    {
        Console.Write("Lutfen bir sayi gir: ");
        int sayi = int.Parse(Console.ReadLine());

        if(sayi % 2 == 0)
            Console.WriteLine("Sayi cift");
        else
            Console.WriteLine("Sayi tek");
    }
}