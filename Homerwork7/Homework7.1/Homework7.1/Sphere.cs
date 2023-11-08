using System.Globalization;
using System.Text.RegularExpressions;
namespace Homework7._1
{
    public class Sphere
    {
        public double Radius { get; set; } = 1;
        private double _x = 0;
        private double _y = 0;
        private double _z = 0;
        private double distance;
        private string _pattern = "^[\\s]*$";

        public Sphere(string radius, string x, string y, string z)
        {
            if (!Regex.IsMatch(radius, _pattern))
            {
                Radius = double.Parse(radius, CultureInfo.InvariantCulture);
            }

            if (!Regex.IsMatch(x, _pattern))
            {
                _x = double.Parse(x, CultureInfo.InvariantCulture);
            }

            if (!Regex.IsMatch(y, _pattern))
            {
                _y = double.Parse(y, CultureInfo.InvariantCulture);
            }

            if (!Regex.IsMatch(z, _pattern))
            {
                _z = double.Parse(z, CultureInfo.InvariantCulture);
            }
        }

        public double GetVolume()
        {
            return 4.0 / 3 * Math.PI * Radius * Radius * Radius;
        }

        public double GetSquare()
        {
            return 4 * Math.PI * Radius * Radius;
        }

        public string GetCenter()
        {
            return $"Координаты центра сферы: ({_x}, {_y}, {_z})";
        }

        public void SetCenter(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public bool IsPointInside(double x, double y, double z)
        {
            distance = Math.Sqrt((x - _x) * (x - _x) + (y - _y) * (y - _y) + (z - _z) * (z - _z));
            Console.WriteLine(distance);
            return distance < Radius;
        }
    }
}
