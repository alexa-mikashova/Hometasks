namespace Homework9._1
{
    internal class ElectricCar : Car
    {
        public double RangeOnOneCharge { get; set; }

        public double CarCharge { get; set; }

        public ElectricCar(double weight, double maxSpeed, int numberOfDoors, string fuelType, double rangeOnOneCharge, double carCharge) : base(weight, maxSpeed, numberOfDoors, fuelType)
        {
            RangeOnOneCharge = rangeOnOneCharge;
            CarCharge = carCharge;
        }

        public new void DisplayInfo()
        {
            Console.WriteLine($"Дальность хода на одном заряде: {RangeOnOneCharge}, Заряд батареи: {CarCharge}");
        }
    }
}
