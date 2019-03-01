using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    class RetinaScreen:ColorfulScreen
    {
        public override void Show(IScreenImage screenimage)
        {
            //here logic that draws Retina image can be added 
        }

        public override void Show(IScreenImage screenimage, int brightness)
        {
            //here logic that draws Retina image with different degrees of brightness can be added 
        }

        public override string ToString()
        {
            return "Retina Colorful Screen";
        }
    }
}
