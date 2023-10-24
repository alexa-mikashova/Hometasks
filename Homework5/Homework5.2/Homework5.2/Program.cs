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
    string replacedString = test.Substring(firstHIndex + 1, lastHIndex-firstHIndex-1);
    Console.WriteLine(replacedString.Replace("h", "H"));
    test = test.Remove(firstHIndex + 1, lastHIndex - firstHIndex - 1);
    test = test.Insert(firstHIndex + 1, replacedString.Replace("h", "H"));
    Console.WriteLine($"Преобразованная строка: '{test}'");
}

