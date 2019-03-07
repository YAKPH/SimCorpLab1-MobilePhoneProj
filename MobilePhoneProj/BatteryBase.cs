using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
   public class BatteryBase
    {
        public int vBatteryCapacityMAh { get; }
        private BatteryTypes vBatteryType;
        public enum BatteryTypes {LithiumPolBattery, LithiumIonBattery, NickelCadmiumBattery};

        public BatteryBase (BatteryTypes batteryType, int batteryCapacityMAh)
	    { vBatteryType=batteryType;
          vBatteryCapacityMAh=batteryCapacityMAh;
	    }

        public double ShowChargingTime(int chargerCapacityMAh)
        {   
            double hours=0;
            if (chargerCapacityMAh !=0)
            {hours=vBatteryCapacityMAh/chargerCapacityMAh;}
            return hours;
        }
        
        public override string ToString()
        {   int chargerCapacityMAh=300;
            var hours= ShowChargingTime(chargerCapacityMAh);
            string message = $"Type {vBatteryType.ToString()}, charging time {hours} hours";
            return message;
        }
    }
}
