using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    class MicroSimCard:SimcardBase
    {
        public MicroSimCard()
        {
            Width = 12;
            Length = 15;
        }
        public override string ToString()
        {
            return "Micro sim";
        }
        public override string Show()
        {
            string message = $"Micro sim phonenumber- {Phonenumber}, width {Width}, length {Length}";
            return message;
        }
    }
}
