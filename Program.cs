using System;

class Program
{
    static void Peruslaskutoimitukset(int a, int b)
    {
        int summa = a + b;
        int erotus = a - b;
        int tulo = a * b;
        double jako = (double)a / b;

        Console.WriteLine($"Summa: {summa}");
        Console.WriteLine($"Erotus: {erotus}");
        Console.WriteLine($"Tulo: {tulo}");
        Console.WriteLine($"Jakolasku: {jako}");
    }

    static void Main()
    {
        Console.Write("Syötä ensimmäinen numero: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Syötä toinen numero: ");
        int numero2 = int.Parse(Console.ReadLine());

        Peruslaskutoimitukset(numero1, numero2);
    }
}