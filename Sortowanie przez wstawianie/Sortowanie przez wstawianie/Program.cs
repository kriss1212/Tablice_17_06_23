
 static void InsertionSort(int[] arr)
{
    int n = arr.Length;

    for (int i = 1; i < n; i++)
    {
        int key = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }

        arr[j + 1] = key;
    }
}


int[] array = { 4, 9, 7, 1, 8 };
InsertionSort(array);

Console.WriteLine("Posortowana tablica:");
foreach (int num in array)
{
    Console.Write(num + " ");
}

