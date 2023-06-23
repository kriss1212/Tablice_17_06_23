using System;

class Program
{
    static void Main()
    {
        // Tworzenie tablicy i wypełnienie jej losowymi wartościami
        int[] tablica = new int[10];
        Random rand = new Random();
        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = rand.Next(1, 100);
        }

        // Wywoływanie metody
        WypiszTabliceOdTylu(tablica);

        // Zatrzymaj program przed zamkniciem
        Console.ReadLine();
    }

    static void WypiszTabliceOdTylu(int[] tablica)
    {
        // lIteracja po tablicy od ostatniego elementu do pierwszego
        for (int i = tablica.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(tablica[i]);
        }
    }
}


