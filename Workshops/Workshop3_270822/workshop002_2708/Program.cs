// Найти сумму чисел от 1 до А

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
int result = 0;
while (i <= A)
{
    result += i;
    i++;
}
Console.WriteLine($"Сумма чисел от 1 до А = {result}");