using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    public class SimCorpMobile:Mobile
    {
        private readonly ScreenBase vScreen;
        private readonly BatteryBase vBattery;
        private readonly SimcardBase vSimcard;        
        private readonly Camera vCamera;
        
        public override ScreenBase Screen { get { return vScreen; } }
        public override BatteryBase Battery { get { return vBattery; } }
        public override SimcardBase Simcard { get { return vSimcard; } }
        public override Camera Camera { get{ return vCamera; } } 
        
        public SimCorpMobile ()
	{
            var type = BatteryBase.BatteryTypes.LithiumIonBattery;
            int capacityMAh = 2200;
            vBattery = new BatteryBase(type,capacityMAh) ;
            
            string number="+380959992299";
            var format = SimcardBase.SimFormats.Nano;
            vSimcard = new SimcardBase(number,format); 
            
            vCamera = new Camera
        {
            MegaPixels = 2000,
            IndivPixelSize = 1000,
            LensType=Camera.LensTypes.Dual,
            ZoomType=Camera.ZoomTypes.Optical  
        };       
            vScreen = new ScreenBase
          {
            HorizontalPixels = 640,
            VerticalPixels = 960,
            Diagonal=3.5,
            ScreenType=ScreenBase.ScreenTypes.LCD
        };
	}
        
    }
}
