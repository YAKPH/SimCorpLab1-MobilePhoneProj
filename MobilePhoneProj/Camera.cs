using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    public class Camera
    {
        public enum ZoomType {Digital,Optical};
        public ZoomType zoomType;
        public enum LensType { One,Dual,Multi };
        public LensType lensType;

        public  int megapixels;
        public  int inivpixelsize;

        public override string ToString()
        {
            var returnstr = $"pixels = {megapixels}, individual pixel size = {inivpixelsize}, lens type = {lensType}, zoom = {zoomType}.";
            return returnstr;
        }
    }
}
