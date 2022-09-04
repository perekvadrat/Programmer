// Задать массив из 8 элементов, 
// заполненных нулями и единицами вывести их на экран

void FillArray(int[] mass)
{
    int length = mass.Length;
    for (int index = 0; index < length; index++)
    {
        mass[index] = new Random().Next(0, 2);
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

int[] array = new int[8];
FillArray(array);
PrintArray(array);
Console.WriteLine();