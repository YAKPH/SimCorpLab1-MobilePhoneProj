using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    public class Camera
    {
        public int MegaPixels;
        public int IndivPixelSize;

        public ZoomTypes ZoomType;
        public LensTypes LensType;

        public enum ZoomTypes { Digital,Optical };
        public enum LensTypes { One,Dual,Multi };

        public override string ToString()
        {
            var returnstr = $"pixels = {MegaPixels}, individual pixel size = {IndivPixelSize}, lens type = {LensType}, zoom = {ZoomType}";
            return returnstr;
        }
    }
}
