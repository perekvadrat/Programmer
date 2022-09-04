// Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
string number = (Console.ReadLine() ?? "0");

int result = 0;
for (int i = 0; i < number.Length; i++)
{
    // Console.Write($"{number[i]} ");
    result += number[i]-48; // Хитрый ход, но ничего умнее не придумал
}
Console.WriteLine($"Сумма цифр в числе = {result}");