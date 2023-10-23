Console.Write("Введите количество строк и столбцов квадратной матрицы (>1): ");
bool isParceSuccess = int.TryParse(Console.ReadLine(), out int arrayLength);
if (isParceSuccess && arrayLength > 1)
{
    int[,] matrix = new int[arrayLength, arrayLength];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine($"Введите {j + 1} элемент массива в {i + 1} строку");
            matrix[i, j] = int.Parse(Console.ReadLine());
        }
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }

        Console.WriteLine("\n");
    }

    int sumDiagonal = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumDiagonal += matrix[i, matrix.GetLength(0) - 1 - i];
    }

    Console.WriteLine($"Сумма элементов побочной диагонали = {sumDiagonal}");
    int sumBelow = 0;
    int accountOffset;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        accountOffset = matrix.GetLength(0) - 1 - i;
        for (int j = accountOffset + 1; j < matrix.GetLength(1); j++)
        {
            sumBelow += matrix[i, j];
        }
    }

    Console.WriteLine($"Сумма элементов под побочной диагональю = {sumBelow}");
}
else
{
    Console.Write("Длина массива введена некорректно!");
}
