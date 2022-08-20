//Даны два числа. Показать большее и меньшее число

Console.Write("Введите число 1:");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число 2:");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
  Console.Write("Большее число:");
  Console.WriteLine(numberA);
  Console.Write("Меньшее число:");
  Console.WriteLine(numberB);
}
else
{
  Console.Write("Большее число:");
  Console.WriteLine(numberB);
  Console.Write("Меньшее число:");
  Console.WriteLine(numberA);
}
