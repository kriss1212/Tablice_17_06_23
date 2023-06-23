using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Elementy tablicy to: 5,2,9,1,7");
        int[] tablica = { 5, 2, 9, 1, 7 };

        int najmniejszy = tablica[0];
        int największy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszy)
            {
                najmniejszy = tablica[i];
            }

            if (tablica[i] > największy)
            {
                największy = tablica[i];
            }
        }

        Console.WriteLine("Najmniejszy element: " + najmniejszy);
        Console.WriteLine("Największy element: " + największy);
    }
}
