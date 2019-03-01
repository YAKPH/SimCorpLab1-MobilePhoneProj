using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    public abstract class SimcardBase: ISimCard
    {
        private string phonenumber;

        public string Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        private int pincode;

        public int PinCode
        {
            get { return pincode; }
            set { pincode = value; }
        }


        private double length;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        private double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public virtual string Show()
        {
            string message = $"'Phonenumber- {Phonenumber}";
            return message;
        }

    }
}
