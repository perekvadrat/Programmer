// Показать вторую цифру трёхзначного числа

int number = new Random().Next(100,1000);
Console.WriteLine($"n = {number}");

int i = (number / 10) % 10;
Console.WriteLine($"Вторая цифра = {i}");
