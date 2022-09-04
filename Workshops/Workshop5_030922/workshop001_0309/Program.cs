// Выяснить являются ли три числа сторонами треугольника

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine() ?? "0");

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Это треугольник");
}
else
{
    Console.WriteLine("Это НЕ треугольник");
}