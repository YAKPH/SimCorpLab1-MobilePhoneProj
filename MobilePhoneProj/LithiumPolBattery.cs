using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
   public class LithiumPolBattery: LithiumLikeBattery
    {
        public override void ShowChargingTime(IBatteryCapacity batteryCapacity)
        {
            //here logic that calculates charging time of LithiumPolBattery based on capacity can be shown
        }
        public override string ReturnBatteryType()
        {
            return "Lithium Polymer Battery";
        }
    }
}
