Console.Write ("Введите имя пользователя ");
string username = Console.ReadLine();
if (username.ToLower() == "пётр")
{
    Console.WriteLine("Ура, это же ПЁТР!");
}
else
{
    Console.Write("Привет, обычный ");
    Console.WriteLine(username);
};