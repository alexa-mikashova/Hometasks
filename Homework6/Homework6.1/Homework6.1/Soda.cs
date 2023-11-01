namespace Homework6._1
{
    public class Soda
    {
        private string _taste;
        public Soda(string taste)
        {
            _taste = taste;
        }
        public string SodaTaste()
        {
            if (string.IsNullOrWhiteSpace(_taste))
            {
                return "Введена пустая строка или строка пробелов!";
            }
            else if (_taste == "НЕТ" || _taste == "нет")
            {
                return "У Вас обычная газировка";
            }
            else
            {
                return $"У Вас газировка с {_taste} вкусом";
            }
        }
    }
}
