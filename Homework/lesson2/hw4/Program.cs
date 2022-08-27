// Найти расстояние между точками в пространстве 2D/3D

int xa = new Random().Next(-10, 10);
Console.WriteLine($"xa = {xa}");
int ya = new Random().Next(-10, 10);
Console.WriteLine($"ya = {ya}");
int xb = new Random().Next(-10, 10);
Console.WriteLine($"xb = {xb}");
int yb = new Random().Next(-10, 10);
Console.WriteLine($"yb = {yb}");

// AB = √(xb - xa)2 + (yb - ya)2

double result = (Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2)));
Console.WriteLine($"Растояние между точками = {result}");