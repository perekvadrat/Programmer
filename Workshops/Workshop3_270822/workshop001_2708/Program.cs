// Показать таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
int result = 0;
while (i<=N)
{
    result = i * i;
    Console.Write(result);
    i++;
}