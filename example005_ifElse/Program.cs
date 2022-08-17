console.while ("Введите имя пользователя");
string username = console.Readline();
if (username.ToLower() == "Пётр");
{
    Console.WriteLine("Ура, это же ПЁТР!");
}
else
{
    Console.Write("Привет, обычный ");
    Console.WriteLine(username);
}