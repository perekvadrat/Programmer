// Написать программу, которая обменивает элементы первой строки и последней строки

int m = 2;
int n = 1;

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
    int temparray = 0; // Временная переменная
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        temparray = matr[a, j];
        matr[a, j] = matr[b, j];
        matr[b, j] = temparray;
    }
}

int[,] array = new int[m,n];
FillArray(array);
PrintArray(array);
Console.WriteLine();

ChangeStrings(array, 0, m-1);
PrintArray(array);