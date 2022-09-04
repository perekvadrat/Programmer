// Написать программу преобразования десятичного числа в двоичное

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine() ?? "0");

string result = String.Empty;

while (a > 0)
{
    result = Convert.ToString(a % 2) + result;
    a = a / 2;
}
Console.WriteLine(result);