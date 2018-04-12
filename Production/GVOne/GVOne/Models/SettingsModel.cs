using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GVOne.Models
{
    public class SettingsModel
    {
        public bool? IsAlertNotificationEnable { get; internal set; }
        public bool? IsAllSettingEnable { get; internal set; }
        public bool? IsPushNotificationEnable { get; internal set; }
    }
}