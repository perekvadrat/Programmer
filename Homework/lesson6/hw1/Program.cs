// Показать двумерный массив размером m×n заполненный вещественными числами

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

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[m,n];
FillArray(array);
PrintArray(array);