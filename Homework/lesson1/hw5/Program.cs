// Показать четные числа от 1 до N

int number = new Random().Next(1,100);
Console.WriteLine($"n = {number}");
for(int i=1; i<=number; i++){
    if(i % 2 == 0){
        Console.Write($"{i} ");
    }
}
Console.Write("\n");
