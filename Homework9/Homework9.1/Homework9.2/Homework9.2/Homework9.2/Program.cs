using Homework9._2;
List<IMultimediaDevice> devices = new List<IMultimediaDevice>
      {
          new MP3Player(),
          new DVDPlayer(),
          new Radio()
      };
int deviceNumber;
while (true)
{
    Console.WriteLine("Введите номер устройства (1-3) или 0 для выхода из программы:");
    deviceNumber = Convert.ToInt32(Console.ReadLine());

    if (deviceNumber == 0)
    {
        break;
    }

    if (deviceNumber >= 1 && deviceNumber <= 3)
    {
        IMultimediaDevice device = devices[deviceNumber - 1];
        DeviceManagement manager = new DeviceManagement();
        manager.ManageDevice(device);
    }
    else
    {
        Console.WriteLine("Введён неверный номер устройства. Попробуйте еще раз.");
    }
}