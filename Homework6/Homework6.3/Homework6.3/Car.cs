namespace Homework6._3
{
    public class Car
    {
        private string _color;
        private string _type;
        private int _year;

        public Car(string color, string type, int year)
        {
            _color = color;
            _type = type;
            _year = year;
        }

        public string CarStarting()
        {
            return "Автомобиль заведён";
        }

        public string TurningOffTheCar()
        {
            return "Автомобиль заглушён";
        }

        public void CarColor()
        {
            _color = "черного";
        }

        public void CarType()
        {
            _type = "BMW";
        }

        public void CarYear()
        {
            _year = 2006;
        }

        public string CarInformation()
        {
            return $"Автомобиль {_type} {_color} цвета {_year} года выпуска";
        }
    }
}
