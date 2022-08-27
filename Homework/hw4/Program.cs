// Выяснить является ли число чётным

int number = new Random().Next(1,1000);
Console.WriteLine(number);
if (number % 2 == 0){
    Console.WriteLine($"Число {number} чётное");
} else {
    Console.WriteLine($"Число {number} НЕчётное");
}

// string result = (number % 2 == 0) ? $"Число {number} чётное" : $"Число {number} НЕчётное";
// Console.WriteLine(result);