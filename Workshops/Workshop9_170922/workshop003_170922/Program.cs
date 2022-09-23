// https://codeforces.com/contest/560/problem/A

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == 1) count++;
}
if (count == 0) Console.WriteLine("Минимально неудачная сумма = 1");
else Console.WriteLine(-1);