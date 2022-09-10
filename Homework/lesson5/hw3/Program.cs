// Написать программу копирования массива

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

void CopyArray(int[,] matr, int[,] matr1) // Копируемый массив, заполняемая копия
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr1[i, j] = matr[i, j];
        }
    }
}

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] mass = new int[m, n];
FillArray(mass);
PrintArray(mass);

int m1 = m;
int n1 = n;

Console.WriteLine();
int[,] mass1 = new int[m1, n1];
CopyArray(mass, mass1);
PrintArray(mass1);