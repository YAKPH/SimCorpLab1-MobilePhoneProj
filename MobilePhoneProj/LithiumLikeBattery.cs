using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    public class LithiumLikeBattery:BatteryBase
    {
        public override void ShowChargingTime(IBatteryCapacity batteryCapacity)
        {
            //here logic that calculates charging time of LithiumLikeBattery based on capacity can be shown
        }

        public override string ReturnBatteryType()
        {
            return "Lithium Like Battery";
        }
    }
}
