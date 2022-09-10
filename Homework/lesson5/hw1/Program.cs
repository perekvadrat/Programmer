// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, 
// y = k2 * x + b2
// b1 k1 и b2 и k2 заданы

int k1 = 1;
int b1 = 1;
int k2 = 5;
int b2 = 1;

int x = (b1-b2)/(k2-k1);
int y = (k2*b1-k1*b2)/(k2-k1);

if (k1 != k2) Console.WriteLine($"Прямые пересекаются в ({x},{y})");
else Console.WriteLine("Прямые не пересекаются");