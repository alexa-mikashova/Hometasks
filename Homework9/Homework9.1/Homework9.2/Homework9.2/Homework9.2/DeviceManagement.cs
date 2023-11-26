namespace Homework9._2
{
    public class DeviceManagement
    {
        public void ManageDevice(IMultimediaDevice device)
        {
            device.Play();
            device.Pause();
            device.Stop();
            device.Next();
            device.IncreaseVolume();
            device.DecreaseVolume();
        }
    }
}
