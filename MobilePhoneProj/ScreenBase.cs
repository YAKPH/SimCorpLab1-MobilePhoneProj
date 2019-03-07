using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    public class ScreenBase
    {   
        public double HorizontalPixels;
        public double VerticalPixels;
        public double Diagonal;  
        public ScreenTypes ScreenType;
        private double vPPI;
        public double PPI {get{return CalculatePixelDensity();}}
    
        public enum ScreenTypes {LCD, OLED, AMOLED, SuperAMOLED, TFT, IPS};
 
        public double CalculatePixelDensity()
          { double ppi=0;
            if ((this.HorizontalPixels != 0)&&(this.VerticalPixels != 0))
              if( this.Diagonal != 0)
                    if(this.Diagonal!=0)
                { var sum=Math.Pow(this.HorizontalPixels,2) + Math.Pow(this.VerticalPixels,2);
                  ppi=Math.Sqrt(sum)/this.Diagonal;}
            this.vPPI=ppi;
            return ppi;
          }

        public bool IsRetinaScreen()
            { if (this.vPPI>300)
              return true;
              else return false;}

        public override string ToString()
        {   
            string info= $" Type {ScreenType.ToString()}, Diagonal {Diagonal}, Pixel Density {this.PPI}";
            if (this.IsRetinaScreen())
                {info+=" it is Retina display";}
            return info;
        }
    }
}
