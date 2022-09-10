// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     int result = 0;
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         result += matr[i, j];
//         Console.WriteLine($"Среднее арифметическое стобца {j} = {result}");
//     }
        
// }

int m = 5;
int n = 6;

int[,] array = new int[m,n];
FillArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(1); i++)
{
    double result = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        result += array[j, i];
    }
    Console.WriteLine($"Среднее арифметическое стобца {i} = {result/m}");
}