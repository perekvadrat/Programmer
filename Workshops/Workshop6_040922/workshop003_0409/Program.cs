// В двумерном массиве показать позиции числа, 
// заданного пользователем или указать, что такого элемента нет

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

void FindNumber(int[,] matr, int x)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == x)
            {
                Console.WriteLine($"Позиция числа {x} = {i}, {j}");
                count++;
            }
        }
    }
    if (count == 0) Console.WriteLine($"Элемента {x} нет");
}

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] mass = new int[m, n];
FillArray(mass);
PrintArray(mass);
Console.Write("Введите искомое число: ");
int x = int.Parse(Console.ReadLine() ?? "0");
FindNumber(mass, x);