using Homework7._1;
using System.Text.RegularExpressions;
string pattern = "(^[0-9]*[.,]?[0-9]*$)|(^[\\s]*$)";
string radius;
string x;
string y;
string z;

do
{
    Console.Write("Введите радиус сферы: ");
    radius = Console.ReadLine();
}
while (!Regex.IsMatch(radius, pattern));

do
{
    Console.Write("Введите абсциссу х  центра сферы: ");
    x = Console.ReadLine();
}
while (!Regex.IsMatch(x, pattern));

do
{
    Console.Write("Введите ординату y центра сферы: ");
    y = Console.ReadLine();
}
while (!Regex.IsMatch(y, pattern));

do
{
    Console.Write("Введите аппликату z центра сферы: ");
    z = Console.ReadLine();
}
while (!Regex.IsMatch(z, pattern));

Sphere sphere = new Sphere(radius, x, y, z);