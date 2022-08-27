// Найти максимальное из трех чисел

Console.WriteLine("Введите 3 числа через пробел");
string[] input = (Console.ReadLine() ?? "0").Split();

if (input.Length == 3) {
    int max = Math.Max(Math.Max(Int32.Parse(input[0]), Int32.Parse(input[1])), Int32.Parse(input[2]));
    Console.WriteLine($"Максимальное из введённых = {max}");
    
} else {
    Console.WriteLine("Вы допустили ошибку");
}
// int[] myInts = Array.ConvertAll(input, s => int.Parse(s));
// int max = Math.Max(Math.Max(myInts[0], myInts[1]), myInts[2]);
