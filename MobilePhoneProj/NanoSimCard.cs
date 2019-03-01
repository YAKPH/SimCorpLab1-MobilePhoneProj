using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    class NanoSimCard:SimcardBase
    {
        public NanoSimCard()
        {
          Width =8.8;
          Length = 12.3;
          Phonenumber = "+380959999999";
        }

        public override string ToString()
        {
            return "Nano sim";
        }

        public override string Show()
        {
            string message = $"Nano sim phonenumber {Phonenumber}, width {Width}, length {Length}";
            return message;
        }
    }
}
