Console.Write("Введите количество элементов массива (>2): ");
bool isParceSuccess = int.TryParse(Console.ReadLine(), out int arrayLength);
if (isParceSuccess && arrayLength > 2)
{
    int[] numbers = new int[arrayLength]; for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: "); numbers[i] = int.Parse(Console.ReadLine());
    }
    int[] duplicateCount = new int[arrayLength];
    string[] duplicateNumbers = new string[arrayLength];
    for (int i = 0; i < arrayLength; ++i)
    {
        int count = 0;
        bool isCopy = false;
        for (int l = 0; l < arrayLength; ++l)
        {
            if (numbers[i].ToString() == duplicateNumbers[l])
            {
                isCopy = true;
                break;
            }
        }

        for (int l = 0; l < arrayLength; ++l)
        {
            if (numbers[i] == numbers[l] && isCopy == false)
            {
                ++count;
            }
        }
        if (count > 1)
        {
            duplicateCount[i] = count;
            duplicateNumbers[i] = numbers[i].ToString();
        }
    }
    bool flag = false;
    for (int i = 0; i < arrayLength; ++i)
    {
        if (duplicateCount[i] > 0)
        {
            Console.WriteLine($"Элемент {duplicateNumbers[i]} повторяется {duplicateCount[i]} раз");
            flag = true;
        }
    }
    if (flag == false)
    {
        Console.WriteLine("Все элементы уникальны!");
    }
}
else
{
    Console.WriteLine("Длина массива введена некорректно!");
}