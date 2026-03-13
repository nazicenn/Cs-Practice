using System;

class Program
{
    static void Main()
    {
        int toplam = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Lutfen " + i + ". sayiyi gir: ");
            int sayi = int.Parse(Console.ReadLine());
            toplam += sayi;
        }

        Console.WriteLine("Girdiginiz sayilarin toplami: " + toplam);
    }
}