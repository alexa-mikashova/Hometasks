namespace Homework8._2
{
    public class Bus
    {
        private int MaxNumberOfSeats = 3;
        private double MaxSpeed = 65;
        private double Speed = 0;
        private List<string> passagers = new List<string>();
        private Dictionary<int, string> seats = new Dictionary<int, string>();
        private bool _freeSpaceFlag = true;

        public string BoardingPassengers(params string[] people)
        {
            foreach (var person in people)
            {
                if (passagers.Count < MaxNumberOfSeats)
                {
                    passagers.Add(person);
                    seats.Add(seats.Count, person);
                }
                else
                {
                    _freeSpaceFlag = false;
                    break;
                }
            }
            return $"В автобус на остановке сели: {string.Join(", ", passagers)}";
        }

        public string PassengerDisembarkation(params string[] peopleOutside)
        {
            foreach (var person in peopleOutside)
            {
                passagers.Remove(person);
                foreach (var seat in seats)
                {
                    if (person == seat.Value)
                    {
                        seats.Remove(seat.Key);
                        break;
                    }
                }
            }
            return $"После остановки в автобусе остались: {string.Join(", ", passagers)}";
        }

        public string SpeedIncrease(double accelerate)
        {
            Speed += accelerate;
            if (Speed > MaxSpeed)
            {
                Speed = MaxSpeed;
                return $"Скорость увеличена до максимума = {MaxSpeed} км/ч";
            }
            else
            {
                return $"Увеличенная скорость = {Speed} км/ч";
            }
        }

        public string SpeedReduction(double decrease)
        {
            Speed -= decrease;
            if (Speed < 0)
            {
                Speed = 0;
                return $"Скорость уменьшена до минимума = 0 км/ч";
            }
            else
            {
                return $"Уменьшенная скорость = {Speed} км/ч";
            }
        }
    }
}

