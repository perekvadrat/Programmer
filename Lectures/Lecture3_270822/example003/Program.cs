// Отсортировать массив

int[] arr = { 1, 5, 65, 10, 6, 9, 0, 1, 0 };

void PrintArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPos]) minPos = j;
        }

        int temporary = array[i];
        array[i] = array[minPos];
        array[minPos] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);