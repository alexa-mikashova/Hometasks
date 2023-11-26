namespace Homework9._2
{
    public class DVDPlayer : IMultimediaDevice
    {
        public void Play()
        {
            Console.WriteLine("Включить DVDPlayer");
        }

        public void Stop()
        {
            Console.WriteLine("Выключить DVDPlayer");
        }

        public void Pause()
        {
            Console.WriteLine("Поставить на паузу DVDPlayer");
        }

        public void Next()
        {
            Console.WriteLine("Включить следующее видео у DVDPlayer");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Сделать звук громче у DVDPlayer");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("Сделать звук тише у DVDPlayer");
        }
    }
}
