namespace Homework9._2
{
    internal class Radio : IMultimediaDevice
    {
        public void Play()
        {
            Console.WriteLine("Включить Radio");
        }

        public void Stop()
        {
            Console.WriteLine("Выключить Radio");
        }

        public void Pause()
        {
            Console.WriteLine("Поставить на паузу Radio");
        }

        public void Next()
        {
            Console.WriteLine("Включить следующую песню у Radio");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Сделать звук громче у Radio");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("Сделать звук тише у Radio");
        }
    }
}
