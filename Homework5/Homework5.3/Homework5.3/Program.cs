Console.Write("Введите строку: ");
string text = Console.ReadLine();
Console.Write("Введите положительный шаг для шифрования или отрицательный шаг для дешифрования: ");
int step = int.Parse(Console.ReadLine());
if (!string.IsNullOrWhiteSpace(text))
{
    text = text.ToLower();
    string alphEn = "abcdefghijklmnopqrstuvwxyz";
    string alphRu = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
    string result = "";
    foreach (char symbol in text)
    {
        if (alphEn.Contains(symbol))
        {
            int index = alphEn.IndexOf(symbol);
            int newIndex = (index + step + alphEn.Length) % alphEn.Length;
            result += alphEn[newIndex];
        }
        else if (alphRu.Contains(symbol))
        {
            int index = alphRu.IndexOf(symbol);
            int newIndex = (index + step + alphRu.Length) % alphRu.Length;
            result += alphRu[newIndex];
        }
        else
        {
            result += symbol;
        }
    }

    if (step >= 0)
    {
        Console.WriteLine($"Зашифрованная строка: {result}");
    }
    else
    {
        Console.WriteLine($"Расшифрованная строка: {result}");
    }
}
else
{
    Console.WriteLine("Введена пустая строка или строка пробелов!");
}

