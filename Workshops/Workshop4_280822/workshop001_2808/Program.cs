// Написать программу замену элементов массива на противоположные

int[] array = { 1, 0, 3, 4, -7, 6, 7, -8, 6, 54, -678, -34 };

for (int index = 0; index < array.Length; index++)
{
    array[index] = array[index] * -1;
    Console.Write($"{array[index]} ");
};
Console.WriteLine("\n");