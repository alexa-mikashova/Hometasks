namespace Homework9._1
{
    internal class Vehicle
    {
        public double Weight { get; set; }

        public double MaxSpeed { get; set; }

        public Vehicle(double weight, double maxSpeed)
        {
            Weight = weight;
            MaxSpeed = maxSpeed;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Вес: {Weight}, Максимальная скорость: {MaxSpeed}");
        }
    }
}
