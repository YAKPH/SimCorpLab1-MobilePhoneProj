using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    public abstract class ScreenBase
    {
        int resulution;
        double diagonal;
        public abstract void Show(IScreenImage screenimage);
        public abstract void Show(IScreenImage screenimage, int brightness);
    }
}
