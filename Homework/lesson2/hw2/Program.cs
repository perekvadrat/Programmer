// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Первое число: ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Второе число: ");
int numberB = int.Parse(Console.ReadLine() ?? "0");
if (numberA == numberB * numberB)
{
    Console.WriteLine("Первое число является квадратом второго!");
}
else if (numberB == numberA * numberA)
{
    Console.WriteLine("Второе число является квадратом первого!");
}
else
{
    Console.WriteLine("Ни одно из этих чисел НЕ является квадратом другого");
}