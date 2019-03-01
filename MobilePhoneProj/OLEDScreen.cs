using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    class OLEDScreen:ColorfulScreen 
    {
        public override void Show(IScreenImage screenimage)
        {
            //here logic that draws OLED image can be added 
        }

        public override void Show(IScreenImage screenimage, int brightness)
        {
            //here logic that draws OLED image with different degrees of brightness can be added 
        }

        public override string ToString()
        {
            return "OLED Colorful Screen";
        }
    }
}
