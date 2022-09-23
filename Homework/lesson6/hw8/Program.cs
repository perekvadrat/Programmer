// В прямоугольной матрице найти строку с наименьшей суммой элементов

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

void SummString(int[,] matr)
{
    int sum = int.MaxValue;
    int index = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int count = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            count += matr[i, j];
        }
        Console.WriteLine($"{i} = {count}");
        if (count < sum)
        {
            sum = count;
            index = i;
        }
    }
    Console.Write($"Строка №{index}: ");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write((matr[index, i]) + " ");

    }
    Console.WriteLine();
}

int m = 5;
int n = 5;

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SummString(array);