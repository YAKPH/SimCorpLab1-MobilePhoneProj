using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    public abstract class Mobile
    {

        public abstract ScreenBase Screen { get; }
        public abstract BatteryBase Battery { get; }
        public abstract Camera Camera { get; }
        public abstract SimcardBase Simcard { get; }
        private void Show(IScreenImage screenImage)
        {
            Screen.Show(screenImage);
        }

        private void ShowChargingTime(IBatteryCapacity batteryCapacity)
        {
            Battery.ShowChargingTime(batteryCapacity);
        }


        public string GetDescription()
        {
            var descrBuilder = new StringBuilder();
            descrBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descrBuilder.AppendLine($"Battery Type: {Battery.ReturnBatteryType()}");
            descrBuilder.AppendLine($"Camera Parameters: {Camera.ToString()}");
            descrBuilder.AppendLine($"Sim Card: {Simcard.ToString()}, {Simcard.Show()}");
            return descrBuilder.ToString();
        }
    }
}
