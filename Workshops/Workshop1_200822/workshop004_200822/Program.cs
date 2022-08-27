// Показать числа от -N до N

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
int count = (-number);
while (count <= number)
{
 Console.Write(" " +count);
 count = count+1;
}
