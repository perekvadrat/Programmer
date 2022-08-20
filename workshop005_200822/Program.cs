// Показать последнюю цифру трёхзначного числа

int number = new Random().Next(100,1000);
Console.WriteLine(number);
int thirdNumber = number % 10;
Console.WriteLine(thirdNumber);