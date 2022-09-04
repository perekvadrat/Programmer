// Показать числа Фибоначчи меньше заданного числа N
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987..

void Fibo(int n)
{
    // int[] numbers = new int[n];
    int result = 0;
    int result0 = 0;
    int result1 = 1;
    Console.Write($"{result0} ");
    Console.Write($"{result1} ");
    int i = 0;
    while (result0+result1 < n)
    {
    result = result0 + result1;
    result0 = result1;
    result1 = result;
    i++;
    Console.Write($"{result} ");
    }
}

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Fibo(n);
Console.WriteLine();