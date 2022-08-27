// Удалить вторую цифру трёхзначного числа

string number = new Random().Next(100, 1000).ToString();
Console.WriteLine($"n = {number}");
// string s = number;
Console.WriteLine($"{number[0]}{number[2]}");

// Console.WriteLine($"{number/100}{number%10}");
