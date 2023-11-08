using Homework7._1;
using System.Globalization;
using System.Text.RegularExpressions;
string pattern = "(^[0-9]*[.,]?[0-9]*$)|(^[\\s]*$)";
string value;
double radius;
double x;
double y;
double z;
do
{
    Console.Write("Введите радиус сферы: ");
    value = Console.ReadLine().Replace(",", ".");
    radius = double.Parse(value, CultureInfo.InvariantCulture);
}
while (!Regex.IsMatch(value, pattern) || radius == 0);

do
{
    Console.Write("Введите абсциссу х  центра сферы: ");
    value = Console.ReadLine().Replace(",", ".");
    x = double.Parse(value, CultureInfo.InvariantCulture);
}
while (!Regex.IsMatch(value, pattern));

do
{
    Console.Write("Введите ординату y центра сферы: ");
    value = Console.ReadLine().Replace(",", ".");
    y = double.Parse(value, CultureInfo.InvariantCulture);
}
while (!Regex.IsMatch(value, pattern));

do
{
    Console.Write("Введите аппликату z центра сферы: ");
    value = Console.ReadLine().Replace(",", ".");
    z = double.Parse(value, CultureInfo.InvariantCulture);
}
while (!Regex.IsMatch(value, pattern));

Sphere sphere = new Sphere(radius, x, y, z);
