// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число: ");
string n = Console.ReadLine() ?? "";
if (n.Length < 3)
{
    Console.WriteLine("Третьего числа нет");
}
else
{
    // Console.WriteLine(n[2]);
    Console.WriteLine(n[n.Length - 3]);
}