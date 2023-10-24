Console.Write("Введите строку: ");
string text = Console.ReadLine();
Console.Write("Введите шаг  для шифрования/дешифрования: ");
int step = int.Parse(Console.ReadLine());
if (!string.IsNullOrWhiteSpace(text))
{
    string lowerCaseText = text.ToLower();
    string alphRu = "абвгдеёжзийклмнопрстуфхцчшщъьэюя";
    string alphEn = "abcdefghijklmnopqrstuvwxyz";
    string alphCheck = alphEn;
    for (int i = 0; i < lowerCaseText.Length; i++)
    {
        if (alphEn.IndexOf(lowerCaseText[i]) < 0)
        {
            alphCheck = alphRu;
            break;
        }
    }

    char[] chars = lowerCaseText.ToCharArray();
    char[] charsAlph = alphCheck.ToCharArray();
    int numberOfSymbol = 0;
    for (int i = 0; i < chars.Length; i++)
    {
        for (int j = 0; j < charsAlph.Length; j++)
        {
            if (chars[i] == charsAlph[j])
            {
                numberOfSymbol = j;
                break;
            }
        }
        if (numberOfSymbol + step < charsAlph.Length && chars[i] != ' ')
        {
            chars[i] = charsAlph[numberOfSymbol + step];
        }
        else if (chars[i] == ' ')
        {
            chars[i] = ' ';
        }
        else
        {
            numberOfSymbol = numberOfSymbol - charsAlph.Length;
            chars[i] = charsAlph[numberOfSymbol + step];
        }
    }

    string encryptedString = string.Concat(chars);
    Console.WriteLine($"Зашифрованная строка: {encryptedString}");
    for (int i = 0; i < chars.Length; i++)
    {
        for (int j = 0; j < charsAlph.Length; j++)
        {
            if (chars[i] == charsAlph[j])
            {
                numberOfSymbol = j;
                break;
            }
        }
        if (numberOfSymbol - step >= 0 && chars[i] != ' ')
        {
            chars[i] = charsAlph[numberOfSymbol - step];
        }
        else if (chars[i] == ' ')
        {
            chars[i] = ' ';
        }
        else
        {
            numberOfSymbol = alphCheck.Length - (step - numberOfSymbol);
            chars[i] = charsAlph[numberOfSymbol];
        }
    }

    string decryptedString = string.Concat(chars);
    Console.WriteLine($"Расшифрованная строка: {decryptedString}");
}
else
{
    Console.WriteLine("Введена пустая строка или строка пробелов!");
}



