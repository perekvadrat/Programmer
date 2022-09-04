// Показать кубы чисел, заканчивающихся на четную цифру
// Числа от 1 до N

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine() ?? "0");
double result = 1;

for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    {
        result = Math.Pow(i, 3);
        Console.WriteLine($"Число {i}^3 = {result}");
    }
}
