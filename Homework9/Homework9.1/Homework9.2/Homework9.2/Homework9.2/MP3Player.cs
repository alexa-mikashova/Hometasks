namespace Homework9._2
{
    public class MP3Player : IMultimediaDevice
    {
        public void Play()
        {
            Console.WriteLine("Включить MP3Player");
        }

        public void Stop()
        {
            Console.WriteLine("Выключить MP3Player");
        }

        public void Pause()
        {
            Console.WriteLine("Поставить на паузу MP3Player");
        }

        public void Next()
        {
            Console.WriteLine("Включить следующую песню у MP3Player");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Сделать звук громче у MP3Player");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("Сделать звук тише у MP3Player");
        }
    }
}
