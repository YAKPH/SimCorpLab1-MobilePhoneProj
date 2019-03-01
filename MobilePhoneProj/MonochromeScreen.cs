using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    public class MonochromeScreen: ScreenBase
    {
        public override void Show(IScreenImage screenimage)
        {
            //here logic that draws monochrome image can be added 
        }
        public override void Show(IScreenImage screenimage, int brightness)
        {
            //here logic that draws monochrome image with different degrees of brightness can be added 
        }

        public override string ToString()
        {
            return "Monochrome Screen";
        }
    }
}
