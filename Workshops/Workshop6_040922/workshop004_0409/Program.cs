// В матрице чисел найти сумму элементов главной диагонали

void PrintArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i, j]} ");
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

void SummMainDiag(int[,] matr)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        count += matr[i,i];
    }
    Console.WriteLine($"Сумма элементов основной диагонали: {count}");
}

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] mass = new int[m, n];
FillArray(mass);
PrintArray(mass);
SummMainDiag(mass);