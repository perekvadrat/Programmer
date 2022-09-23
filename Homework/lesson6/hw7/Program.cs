// Написать программу, которая в двумерном массиве заменяет строки на столбцы 
// или сообщить, что это невозможно (в случае, если матрица не квадратная)

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int m = 6;
int n = 6;

if (m == n)
{
    int[,] array = new int[m, n];
    FillArray(array);
    PrintArray(array);
    int[,] newarray = new int[m, n];

    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            newarray[i, j] = array[j, i];
        }
    }

    Console.WriteLine();
    Console.WriteLine("Новый массив:");
    PrintArray(newarray);
}
else Console.WriteLine("Невозможно заменить строки и столбцы т.к. матрица не квадратная");