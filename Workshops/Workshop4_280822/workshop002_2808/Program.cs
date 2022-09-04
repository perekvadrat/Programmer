// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
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
Console.Write("Введите длину массива: ");
int[] array = new int[int.Parse(Console.ReadLine() ?? "0")];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int count = 0;

for(int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
    count++;
    }
} 
Console.WriteLine($"Чётных = {count}");
Console.WriteLine($"НЕчётных = {array.Length - count}");