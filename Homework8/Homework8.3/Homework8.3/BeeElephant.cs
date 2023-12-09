namespace Homework8._3
{
    public class BeeElephant
    {
        private int _beePart;
        private int _elephantPart;

        public BeeElephant(int beePart, int elephantPart)
        {
            _beePart = beePart;
            _elephantPart = elephantPart;
        }

        public bool Fly()
        {
            return _beePart >= _elephantPart;
        }

        public string Trumpet()
        {
            return _elephantPart >= _beePart ? "tu-tu-doo-doo" : "wzzzz";
        }

        public string Eat(string meal, int value)
        {
            switch (meal)
            {
                case "nectar":
                    _elephantPart = Math.Max(0, _elephantPart - value);
                    _beePart = Math.Min(100, _beePart + value);
                    return $"Часть пчелы - {_beePart}, часть слона - {_elephantPart}";
                case "grass":
                    _beePart = Math.Max(0, _beePart - value);
                    _elephantPart = Math.Min(100, _elephantPart + value);
                    return $"Часть пчелы - {_beePart}, часть слона - {_elephantPart}";
                default:
                    return "meal is not nectar or grass";
            }
        }
    }
}
