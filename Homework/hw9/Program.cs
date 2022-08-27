// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");
if (a % b == 0)
{
    Console.WriteLine($"Число {a} кратно {b}");
}
else
{
    Console.WriteLine($"Остаток от деления = {a % b}");
}