using System;

class Program
{
    static void Main()
    {
        Console.Write("Kac sayi gireceksiniz? ");
        int n = int.Parse(Console.ReadLine());
        int toplam = 0;
        int i = 1;

        while(i <= n)
        {
            Console.Write("Lutfen " + i + ". sayiyi gir: ");
            int sayi = int.Parse(Console.ReadLine());
            toplam += sayi;
            i++;
        }

        Console.WriteLine("Toplam: " + toplam);
    }
}