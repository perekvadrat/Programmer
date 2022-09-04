// Работа с текстом. Дан текст.
// Заменить буквы "к" на "К"
// Заменить буквы "С" на "с"

string text = "йцук енгш щзхъ"
            + "фыва прол джэ"
            + "ячсм ить бю";

string Replace(string text, char OldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == OldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '_');

Console.WriteLine(newText);
Console.WriteLine();
string newText1 = Replace(newText, 'к', 'К');
Console.WriteLine(newText1);