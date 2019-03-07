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

        public override string ToString()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Battery Type: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Camera Parameters: {Camera.ToString()}");
            descriptionBuilder.AppendLine($"Sim Card: {Simcard.ToString()}");
            return descriptionBuilder.ToString();
        }
    }
}
