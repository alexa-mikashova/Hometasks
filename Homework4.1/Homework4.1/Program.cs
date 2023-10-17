Console.Write("Введите количество элементов массива (>2): ");
bool isParceSuccess = int.TryParse(Console.ReadLine(), out int arrayLength);
if (isParceSuccess && arrayLength > 2)
{
    int sumOfElements = 0; int[] numbers = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива:"); numbers[i] = int.Parse(Console.ReadLine());
        sumOfElements += numbers[i];
    }
    Console.WriteLine($"Сумма элементов массива = {sumOfElements}");
}
else
{
    Console.WriteLine("Длина массива введена некорректно!");
}