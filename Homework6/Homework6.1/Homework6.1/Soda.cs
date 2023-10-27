namespace Homework6._1
{
    public class Soda
    {
        private string _taste;
        public Soda(string taste)
        {
            _taste = taste;
        }
        public void SodaTaste()
        {
            if (string.IsNullOrWhiteSpace(_taste))
            {
                Console.WriteLine("Введена пустая строка или строка пробелов!");
            }
            else if (_taste == "НЕТ" || _taste == "нет")
            {
                Console.WriteLine($"У Вас обычная газировка");
            }
            else
            {
                Console.WriteLine($"У Вас газировка с {_taste} вкусом");
            }
        }
    }
}
