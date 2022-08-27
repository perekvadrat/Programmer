// Дано число. Проверить кратно ли оно 7 и 23

int a = new Random().Next(1, 1000); // 161
Console.WriteLine(a);

if ((a % 7 == 0) && (a % 23 == 0))
{
    Console.WriteLine("Число кратно 7 и 23");
}
else Console.WriteLine("Число НЕ кратно 7 и 23");