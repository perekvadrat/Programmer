// Составить частотный словарь элементов двумерного массива

// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных

int[] array = { 1, 9, 9, 0, 2, 8, 0, 9 };
int[] array2 = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[i] == array[j])
        {
            count++;
        }
    for (int k = 0; k < array2.Length; k++)
        {
            if (array2[i] != array[k]) array2[k] = array[k];            
        }
    }
    Console.WriteLine($"Кол-во эл. {array[i]} = {count}");
}
for (int i = 0; i< array2.Length; i++)
{
    Console.Write($"{array2[i]} ");
}
Console.WriteLine();
