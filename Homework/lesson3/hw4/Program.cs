// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine() ?? "0");
double result = 1;
for (int i = 1; i <= number; i++)
{
    result *= i;
}
Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");