using System;

class Program
{
    static void Main()
    {
        int sayi;
        do
        {
            Console.Write("Lutfen pozitif bir sayi gir: ");
            sayi = int.Parse(Console.ReadLine());
        } while(sayi <= 0);

        Console.WriteLine("Girdiginiz pozitif sayi: " + sayi);
    }
}