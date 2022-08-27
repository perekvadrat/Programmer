// Задать номер четверти, показать диапазоны для возможных координат
// Четверти нумеруются начиная с правой верхней и далее против часовой стрелки

Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine() ?? "0");

if (quarter == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if (quarter == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if (quarter == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else Console.WriteLine("x > 0, y < 0");