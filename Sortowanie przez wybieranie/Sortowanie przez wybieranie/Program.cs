using System;

class SelectionSort
{
    static void Main()
    {
        int[] array = { 5, 2, 9, 1, 3 };

        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(array);

        SelectionSortAlgorithm(array);

        Console.WriteLine("Tablica po sortowaniu:");
        PrintArray(array);
    }

    static void SelectionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Zamiana miejscami elementów
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
