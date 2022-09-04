// В Указанном массиве вещественных чисел найдите 
// разницу между максимальным и минимальным элементом

void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(1, 100);
    }
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);

int min = array[0];
int max = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}
Console.WriteLine($"{max} - {min} = {max - min}");