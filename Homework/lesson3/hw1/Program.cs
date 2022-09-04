// Найти кубы чисел от 1 до N

int number = new Random().Next(1, 20);
Console.WriteLine($"N = {number}");
double result = 0;
for (int i = 1; i <= number; i++)
{
    result = Math.Pow(i, 3);
    Console.WriteLine($"{i}^3= {result} ");
}