// Определить номер четверти полоскости в которой находится точка XY

int x = new Random().Next(-10, 10);
Console.WriteLine(x);
int y = new Random().Next(-10, 10);
Console.WriteLine(y);

if ((x >= 0) && (y >= 0))
{
    Console.WriteLine("Четверть I");
else if ((x < 0) && (y > 0))
    {
    Console.WriteLine("Четверть II");
    }
else if ((x < 0) && (y < 0))
    {
    Console.WriteLine("Четверть III");
    }
}

else Console.WriteLine("Четверть IV");