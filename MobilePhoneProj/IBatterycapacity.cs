using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
   public interface IBatteryCapacity
    {
        double milliamperehours { get; set; }
        TimeSpan timeinterval { get; set; }
    }
}
