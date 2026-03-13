using System;

class Program
{
    static void Main()
    {
        Console.Write("Lutfen N sayisini gir: ");
        int n = int.Parse(Console.ReadLine());

        int toplam = 0;

        for(int i = 1; i <= n; i++)
        {
            toplam += i;
        }

        Console.WriteLine("1'den " + n + " sayisina kadar toplami: " + toplam);
    }
}