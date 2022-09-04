// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(10, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

// voif PrintArray(int[] col)
// {
//     foreach(int element in array)
//         Console.WriteLine($"{element} ")
// }

Console.Write("Введите длину массива: ");
int[] array = new int[int.Parse(Console.ReadLine() ?? "0")];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int sum = 0;

for(int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
    sum = sum + array[i];
    }
} 
Console.WriteLine($"Сумма чисел на нечётных позициях = {sum}");