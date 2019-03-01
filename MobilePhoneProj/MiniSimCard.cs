using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    class MiniSimCard:SimcardBase
    {
        public MiniSimCard()
        {
            Width = 9;
            Length = 11;
        }

        public override string ToString()
        {
            return "Mini sim";
        }
        public override string Show()
        {
            string message = $"Nano sim phonenumber- {Phonenumber}, width {Width}, length {Length}";
            return message;
        }

    }
}
