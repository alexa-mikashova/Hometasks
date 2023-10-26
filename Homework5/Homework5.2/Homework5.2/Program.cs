Console.Write("Введите строку: ");
string test = Console.ReadLine();
if (string.IsNullOrWhiteSpace(test))
{
    Console.WriteLine("Введена пустая строка или строка пробелов!");
}
else if (!test.Contains("h"))
{
    Console.WriteLine($"В строке '{test}' символа h нет.");
}
else
{
    int firstHIndex = test.IndexOf("h");
    int lastHIndex = test.LastIndexOf("h");
    if (lastHIndex - firstHIndex > 1)

    {
        for (int i = firstHIndex + 1; i < lastHIndex; i++)
        {
            if (test[i] == 'h')
            {
                test = test.Remove(i, 1).Insert(i, "H");
            }
        }
        Console.WriteLine($"Преобразованная строка: {test}");
    }
    else
    {
        Console.WriteLine("В введённой строке заменить нечего.");
    }
}

