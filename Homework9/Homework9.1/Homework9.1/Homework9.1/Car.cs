namespace Homework9._1
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public string FuelType { get; set; }

        public Car(double weight, double maxSpeed, int numberOfDoors, string fuelType) : base(weight, maxSpeed)
        {
            NumberOfDoors = numberOfDoors;
            FuelType = fuelType;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Количество дверей: {NumberOfDoors}, Тип топлива: {FuelType}");
        }
    }
}
