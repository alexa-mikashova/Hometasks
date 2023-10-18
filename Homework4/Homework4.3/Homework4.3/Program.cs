Console.Write("Введите количество элементов массива (>2): ");
bool isParceSuccess = int.TryParse(Console.ReadLine(), out int arrayLength);
if (isParceSuccess && arrayLength > 2)
{
    int[] numbers = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        numbers[i] = int.Parse(Console.ReadLine());
    }
    int temp = 0;
    for (int i = 0; i < arrayLength; i++)
    {
        for (int j = i + 1; j < arrayLength; j++)
        {
            if (numbers[j] < numbers[i])
            {
                temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
        }
    }
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"{numbers[i]}  ");
    }
    Console.WriteLine();
    string name = null;
    for (int i = 0; i < arrayLength; i++)
    {
        string numbersString = numbers[i].ToString();
        if (numbersString == name)
        {
            continue;
        }
        else
        {
            name = numbersString;
            int count = 0;
            for (int j = 0; j < arrayLength; j++)
            {
                if ((numbers[j] == numbers[i]))
                {
                    count++;
                }
            }
            if (count > 1)
            {
                Console.WriteLine($"Число {numbers[i]} повторяется {count} раз(а) ");
            }
        }
    }
}
else
{
    Console.Write("Длина массива введена некорректно!");
}
