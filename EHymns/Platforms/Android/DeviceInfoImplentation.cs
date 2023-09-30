using Android.Content.PM;

using LocalHymns.Platforms.Android;

using Application = Android.App.Application;

namespace LocalHymns.Interfaces
{
    public class DeviceInfoImplementation : LocalHymns.Interfaces.IMyDeviceInfo
    {
        public bool IsWhatsAppInstalled()
        {
            try
            {
                var pm = Application.Context.PackageManager;
                pm.GetPackageInfo("com.whatsapp", PackageInfoFlags.MatchAll);
                return true;
            }
            catch (PackageManager.NameNotFoundException)
            {
                return false;
            }
        }
    }
}
