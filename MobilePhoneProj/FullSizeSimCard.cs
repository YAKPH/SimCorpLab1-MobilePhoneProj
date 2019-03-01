using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    class FullSizeSimCard:SimcardBase
    {
        public FullSizeSimCard()
        {
            Width = 15;
            Length = 25;
        }
        public override string ToString()
        {
            return "Full size sim";
        }
        public override string Show()
        {
            string message = $"Full size sim phonenumber- {Phonenumber}, width {Width}, length {Length}";
            return message;
        }
    }
}
