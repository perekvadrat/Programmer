// Написать программу, которая обменивает элементы первой строки и последней строки

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

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
            matr[i, j] = new Random().Next(10, 100);
        }
    }
}

void ChangeStrings(int[,] matr, int a, int b)
{
    int[] temparray = new int[n]; // Временный массив
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            temparray[j] = matr[a, j];
            matr[a, j] = matr[b, j];
            matr[b, j] = temparray[j];
        }
    }
}

int[,] array = new int[m,n];
FillArray(array);
PrintArray(array);
Console.WriteLine();

ChangeStrings(array, 0, m-1);
PrintArray(array);

// Пока не разобрался почему работает только с нечётным количеством строк