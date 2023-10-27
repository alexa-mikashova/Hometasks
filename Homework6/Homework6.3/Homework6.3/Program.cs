using Homework6._3;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
Console.Write("Введите марку автомобиля: ");
string type = Console.ReadLine();
Console.Write("Введите цвет автомобиля: ");
string color = Console.ReadLine();
bool isParceSuccessOne;
int year;
do
{
    Console.Write("Введите год выпуска автомобиля: ");
    isParceSuccessOne = int.TryParse(Console.ReadLine(), out year);
}
while (!isParceSuccessOne || year < 1900 || year > 2023);
Car car = new(type, color, year);
car.CarStarting();
car.TurningOffTheCar();
car.CarType();
car.CarColor();
car.CarYear();
car.CarInformation();
