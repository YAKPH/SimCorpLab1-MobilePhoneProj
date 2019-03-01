using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    interface ISimCard
    {
        string Phonenumber { get; set; }
        int PinCode { get; set; }

        double Length { get; set; }
        double Width { get; set; }

    }
}
