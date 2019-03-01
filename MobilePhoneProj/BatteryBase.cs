using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
   public abstract class BatteryBase
    {
        public abstract void ShowChargingTime(IBatteryCapacity batteryCapacity);
        public abstract string ReturnBatteryType();
    }
}
