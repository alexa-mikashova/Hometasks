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
    int previousNumber = numbers[0];
    int count = 0;
    bool isCopy = false;
    for (int i = 0; i < arrayLength; i++)
    {
        if (previousNumber == numbers[i])
        {
            count++;
        }
        else
        {
            if (count > 1)
            {
                Console.WriteLine($"\nЧисло {previousNumber} повторяется {count} раз(а)");
                isCopy = true;
                count = 1;
            }

            previousNumber = numbers[i];
        }
    }
    if (count > 1)
    {
        Console.WriteLine($"\nЧисло {previousNumber} повторяется {count} раз(а)");
        isCopy = true;
    }
    if (!isCopy)
    {
        Console.WriteLine("\nВсе числа в массиве уникальны.");
    }
}
else
{
    Console.Write("Длина массива введена некорректно!");
}