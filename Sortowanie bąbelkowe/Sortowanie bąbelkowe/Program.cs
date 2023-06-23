using System;

class BubbleSort
{
    static void Main()
    {
        int[] array = { 5, 2, 8, 1, 9, 3 };

        Console.WriteLine("Przed sortowaniem:");
        PrintArray(array);

        BubbleSortAlgorithm(array);

        Console.WriteLine("\nPo sortowaniu:");
        PrintArray(array);
    }

    static void BubbleSortAlgorithm(int[] array)
    {
        int n = array.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Zamień elementy miejscami
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            // Jeśli wewnątrz pętli wewnętrznej nie było żadnej zamiany, to lista jest już posortowana
            if (!swapped)
                break;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }
}
