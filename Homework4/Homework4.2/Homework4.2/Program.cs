Console.Write("Введите количество элементов массива (>2): ");
bool isParceSuccess = int.TryParse(Console.ReadLine(), out int arrayLength);
if (isParceSuccess && arrayLength > 2)
{
    int[] numbers = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива:");
        numbers[i] = int.Parse(Console.ReadLine());
    }
    int max = numbers[0];
    int min = numbers[0];
    for (int i = 1; i < arrayLength; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
        else
        {
            min = numbers[i];
        }
    }
    Console.WriteLine($"элемент {max} - максимальный");
    Console.WriteLine($"элемент {min} - минимальный");
    int numberDifference = max - min;
    Console.WriteLine($"Разность максимума и минимума = {numberDifference}");
}
else
{
    Console.WriteLine("Длина массива введена некорректно!");
}
