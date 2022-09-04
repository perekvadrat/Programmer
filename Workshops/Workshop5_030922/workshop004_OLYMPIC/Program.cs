// Поединок волшебников

Console.Write("Введите длину коридора l: ");
double l = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Скорость заклинания Гарри p: ");
double p = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Скорость заклинания Сами-Знаете-Кого q: ");
double q = double.Parse(Console.ReadLine() ?? "0");

double result = 0;
// result = (p*(l/100));
result = (p+q)/l;
Console.WriteLine(result);