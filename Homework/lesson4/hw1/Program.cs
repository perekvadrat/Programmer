// Определить, присутствует ли в заданном массиве, некоторое число

// В одномерном массиве из 123 чисел 
// найти количество элементов из отрезка [10,99]

void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]} ");
    }
}

void FillArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-50, 50);
    }
}

void FindElCount(int[] mass)
{
    int min = 10;
    int max = 99;
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > min && mass[i] < max) count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Колличество элементов >{min} <{max} = {count}");
}

void FindNum(int[] mass)
{
    Console.Write("Введите искомое число: ");
    int num = int.Parse(Console.ReadLine() ?? "0");
    int result = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] == num) result++;
    }
    if (result > 0) Console.WriteLine($"Число {num} встречается {result} раз");
    else Console.WriteLine($"Массив не содержит {num}!");
}
int[] array = new int[123];
FillArray(array);
PrintArray(array);
FindElCount(array);
FindNum(array);