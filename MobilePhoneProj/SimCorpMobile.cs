using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    public class SimCorpMobile:Mobile
    {
        public override ScreenBase Screen { get { return vOLEDScreen; } }
        private readonly OLEDScreen vOLEDScreen = new OLEDScreen();

        public override BatteryBase Battery { get { return vLiIon; } }
        private readonly LithiumIonBattery vLiIon = new LithiumIonBattery();

        public override Camera Camera { get{ return vCam; } }
        private readonly Camera vCam = new Camera
        {
            megapixels = 2000,
            inivpixelsize = 1000,
            lensType=Camera.LensType.Dual,
            zoomType=Camera.ZoomType.Optical
            
        };

        public override SimcardBase Simcard { get { return vSim; } }
        private readonly NanoSimCard vSim = new NanoSimCard();
        
    }
}
