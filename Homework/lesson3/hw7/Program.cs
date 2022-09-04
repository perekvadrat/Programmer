// Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива

void FillArray(int[] mass)
{
    int length = mass.Length;
    for (int index = 0; index < length; index++)
    {
        mass[index] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] col)
{
    int length1 = col.Length;
    for (int position = 0; position < length1; position++)
    {
        Console.Write($"{col[position]} ");
    }
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count += array[i];
}
int count1 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0) count1 += array[i];
}
Console.WriteLine($"Сумма положительных элементов = {count}");
Console.WriteLine($"Сумма отрицательных элементов = {count1}");