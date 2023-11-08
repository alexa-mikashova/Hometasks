using System.Globalization;

bool isParceSuccessOne;
double firstNumber;
double secondNumber;
int actionSelection = 0;
do
{
    Console.Write("Введите первое число: ");
    isParceSuccessOne = double.TryParse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture, out firstNumber);
}
while (!isParceSuccessOne);

do
{
    Console.Write("Введите второе число: ");
    isParceSuccessOne = double.TryParse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture, out secondNumber);
}
while (!isParceSuccessOne);

do
{
    Console.Write("Введите номер математического действия для чисел: сложение - 0, вычитание - 1, умножение - 2, деление - 3: ");
    isParceSuccessOne = int.TryParse(Console.ReadLine(), out actionSelection);
}
while (!isParceSuccessOne || actionSelection < 0 || actionSelection > 3);

Homework6._2.Math math = new();
switch (actionSelection)
{
    case 0:
        Console.WriteLine(math.Add(firstNumber, secondNumber));
        break;
    case 1:
        Console.WriteLine(math.Subtract(firstNumber, secondNumber));
        break;
    case 2:
        Console.WriteLine(math.Multiply(firstNumber, secondNumber));
        break;
    case 3:
        if (secondNumber != 0)
        {
            Console.WriteLine(math.Divide(firstNumber, secondNumber));

        }
        else
        {
            Console.WriteLine("На нуль делить нельзя!");
        }
        break;
}

