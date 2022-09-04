// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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
        mass[i] = new Random().Next(1, 10);
    }
}

void Multiply(int[] mass) //Перемножает первый и последний элемент, второй и предпоследний и т.д.
{
    int result = 0;
    for (int i = 0; i < (mass.Length/2); i++)
    {
        result = mass[i] * mass[(mass.Length)-i-1];
        Console.WriteLine($"{mass[i]} * {mass[(mass.Length)-i-1]} = {result}");
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Multiply(array);