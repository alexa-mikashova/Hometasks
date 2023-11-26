namespace Homework9._1
{
    internal class Truck : Vehicle
    {
        public int LiftingCapacity { get; set; }

        public Truck(double weight, double maxSpeed, int liftingCapacity) : base(weight, maxSpeed)
        {
            LiftingCapacity = liftingCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Грузоподъёмность: {LiftingCapacity}");
        }
    }
}
