// Возведите число А в натуральную степень B используя цикл

// Console.Clear;

int A = new Random().Next(1, 50);
Console.WriteLine($"Число А = {A}");
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine() ?? "0");
int result = 1;
for (int i = 0; i < B; i++)
{
    result = result * A;
}
Console.WriteLine($"{A} ^ {B} = {result}");
