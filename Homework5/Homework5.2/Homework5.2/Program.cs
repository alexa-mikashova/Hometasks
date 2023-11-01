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
    string rezult = test.Replace('h', 'H');
    int firstHIndex = rezult.IndexOf("H");
    int lastHIndex = rezult.LastIndexOf("H");
    char[] rezultTest = rezult.ToCharArray();
    rezultTest[firstHIndex] = 'h';
    rezultTest[lastHIndex] = 'h';
    Console.WriteLine(new string(rezultTest));
}