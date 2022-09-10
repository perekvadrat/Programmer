// Написать программу масштабирования фигуры 
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой) 
// например: "(0,0) (2,0) (2,2) (0,2)" 
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5 
// В результате показать координаты, которые получатся. 
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

Console.Write("Задайте вершины фигуры одной строкой: ");
string top = (Console.ReadLine() ?? "0"); // (0,0) (2,0) (2,2) (0,2)

Console.Write("Задайте коэффициент масштабирования: ");
int k = int.Parse(Console.ReadLine() ?? "0");

char top1 = Convert.ToChar(top[1]*k-(48*(k-1)));
char top2 = Convert.ToChar(top[3]*k-(48*(k-1)));
char top3 = Convert.ToChar(top[7]*k-(48*(k-1)));
char top4 = Convert.ToChar(top[9]*k-(48*(k-1)));
char top5 = Convert.ToChar(top[13]*k-(48*(k-1)));
char top6 = Convert.ToChar(top[15]*k-(48*(k-1)));
char top7 = Convert.ToChar(top[19]*k-(48*(k-1)));
char top8 = Convert.ToChar(top[21]*k-(48*(k-1)));

Console.WriteLine($"k={k} ({top1},{top2}) ({top3},{top4}) ({top5},{top6}) ({top7},{top8})");

// void PrintArray(string[] matr)
// {
//     for (int i = 0; i < matr.Length; i++)
//     {
//         Console.Write($"{matr[i]} ");
//     }
// }

// void FillArray(string[] matr)
// {
//     for (int i = 0; i < matr.Length; i++)
//     {
//         matr[i] = Convert.ToString((new Random().Next(0, 10)), (new Random().Next(0, 10)));
//     }
// }

// string[] shape = new string[4];
// FillArray(shape);
// PrintArray(shape);
