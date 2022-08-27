// По заданному номеру дня недели вывести его название

Console.WriteLine("Введите номер дня недели от 1 до 7");
int numberA = int.Parse(Console.ReadLine() ?? "0");
string[] week = new string[8] {"", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
if (numberA >= 1 && numberA <= 7) {
    Console.WriteLine(week[numberA]);
} 
else
{
    Console.WriteLine("Вы ввели неверное значение!");
}