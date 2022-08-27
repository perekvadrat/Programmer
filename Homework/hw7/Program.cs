// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 100);
Console.WriteLine($"n = {number}");

int a = number / 10;
int b = number % 10;
Console.WriteLine($"Max = {Math.Max(a, b)}");