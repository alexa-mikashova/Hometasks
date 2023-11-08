namespace Homework7._1
{
    public class Sphere
    {
        private double _x = 0;
        private double _y = 0;
        private double _z = 0;

        public double Radius { get; set; }

        public Sphere()
        {
            Radius = 1;
            _x = 0;
            _y = 0;
            _z = 0;
        }

        public Sphere(double radius)
        {
            Radius = radius;
            _x = 0;
            _y = 0;
            _z = 0;
        }

        public Sphere(double radius, double x, double y, double z)
        {
            Radius = radius;
            _x = x;
            _y = y;
            _z = z;
        }

        public double GetVolume()
        {
            return 4.0 / 3.0 * Math.PI * Radius * Radius * Radius;
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
            return Math.Sqrt((x - _x) * (x - _x) + (y - _y) * (y - _y) + (z - _z) * (z - _z)) < Radius;
        }
    }
}
