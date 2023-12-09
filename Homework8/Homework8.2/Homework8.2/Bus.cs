namespace Homework8._2
{
    public class Bus
    {
        private double _maxSpeed;
        private int _maxNumberOfSeats;
        private double _speed;

        public double Speed
        {
            get { return _speed; }
            set
            {
                _speed = Math.Min(Math.Max(value, 0), _maxSpeed);
            }
        }

        public double MaxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                if (value > 0)
                {
                    _maxSpeed = value;
                }
                else
                {
                    throw new ArgumentException("Введено значение меньше нуля", nameof(value));
                }
            }
        }

        public int MaxNumberOfSeats
        {
            get { return _maxNumberOfSeats; }
            set
            {
                if (value > 0)
                {
                    _maxNumberOfSeats = value;
                }
                else
                {
                    throw new ArgumentException("Введено значение меньше нуля", nameof(value));
                }
            }
        }

        public bool HasEmptySeats { get; set; }

        public List<string> Passangers { get; set; }

        public Dictionary<string, string> Seats { get; set; }
        public Bus(double maxSpeed, int maxNumberOfSeats)
        {
            MaxSpeed = maxSpeed;
            MaxNumberOfSeats = maxNumberOfSeats;
            Speed = 0;
            HasEmptySeats = true;
            Passangers = new List<string>();
            Seats = new Dictionary<string, string>();
        }

        public string BoardingPassengers(params string[] people)
        {
            foreach (var person in people)
            {
                if (Passangers.Count < MaxNumberOfSeats)
                {
                    Passangers.Add(person);
                    Seats.Add(person, person);
                }
                else
                {
                    HasEmptySeats = false;
                    break;
                }
            }
            return $"В автобус на остановке сели: {string.Join(", ", Passangers)}";
        }

        public string PassengerDisembarkation(params string[] peopleOutside)
        {
            foreach (var person in peopleOutside)
            {
                Passangers.Remove(person);
                foreach (var seat in Seats)
                {
                    if (person == seat.Value)
                    {
                        Seats.Remove(seat.Key);
                        break;
                    }
                }
            }
            return $"После остановки в автобусе остались: {string.Join(", ", Passangers)}";
        }

        public string SpeedIncrease(double accelerate)
        {
            Speed += accelerate;
            return $"Cкорость автобуса после увеличения = {Speed}";
        }

        public string SpeedReduction(double decrease)
        {
            Speed -= decrease;
            return $"Cкорость автобуса после уменьшения = {Speed}";
        }
    }
}

