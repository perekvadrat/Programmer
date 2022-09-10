// Написать программу масштабирования фигуры 
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой) 
// например: "(0,0) (2,0) (2,2) (0,2)" 
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5 
// В результате показать координаты, которые получатся. 
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

string text = "(0,0) (2,0) (2,2) (0,2)"
            .Replace("(", "")
            .Replace(")", "")
            ;
Console.WriteLine(text);

Console.Write("Задайте коэффициент масштабирования: ");
double k = double.Parse(Console.ReadLine() ?? "0");

var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Select(point => (point.x * k, point.y * k))
                .ToArray();

// Console.Write("Задайте коэффициент масштабирования: ");
// int k = int.Parse(Console.ReadLine() ?? "0");

// int[] array = new int[4];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = int.Parse(data[i]);
//     Console.WriteLine(array[i]);
// }

// int i = 0;
// int index = int.Parse(data[i]);

for (int i = 0; i < data.Length; i++)
{
    Console.Write($"{data[i]} ");
}
Console.WriteLine();