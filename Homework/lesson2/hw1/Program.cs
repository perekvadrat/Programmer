// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели от 1 до 7");
int numberA = int.Parse(Console.ReadLine() ?? "0");
string[] week = new string[8] {"", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
if (numberA >= 1 && numberA <= 7) {
    Console.WriteLine(week[numberA]);
    if (numberA >= 6 && numberA <= 7)
    {
        Console.WriteLine($"Это выходной!");
    }
    else
    {
        Console.WriteLine($"Это будний день");
    }
}
else
{
    Console.WriteLine("Вы ввели неверное значение!");
}