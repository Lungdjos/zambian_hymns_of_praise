using LocalHymns.Platforms.iOS;
using LocalHymns.Shared;

using Foundation;

using System;
using System.Collections.Generic;
using System.Text;

using UIKit;




namespace LocalHymns.Interfaces
{
    public class DeviceInfoImplementation : LocalHymns.Interfaces.IMyDeviceInfo
    {
        public bool IsWhatsAppInstalled()
        {
            return UIApplication.SharedApplication.CanOpenUrl(new NSUrl(new NSString("whatsapp://")));

        }
    }
}
