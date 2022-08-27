// Определить количество цифр в числе

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");
int i = 0;
int x = A;
while (x>0)
{
    i++;
    x = x/10;
}
Console.WriteLine($"Количество цифр в числе {i}");