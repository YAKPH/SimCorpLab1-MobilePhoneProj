using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneProj
{
    public class SimcardBase
    {
        private string vPhoneNumber;
        private int vPinCode;
        private double Length;
        private double Width;
        private SimFormats vSimFormat;
        public enum SimFormats {Embedded, Nano, Micro, Mini, FullSize};

        public string PhoneNumber { get { return vPhoneNumber; }}

        public int PinCode
        {
            get { return vPinCode; }
            set { vPinCode = value; }
        }

        public SimcardBase ( string phoneNumber, SimFormats simFormat)
	    { 
            vPhoneNumber = phoneNumber;   
            vSimFormat = simFormat;
	    }

        public string GetSimFormatDetails( SimFormats simFormat)
        { 
            switch (simFormat)
	      { case SimFormats.Embedded : { 
            Width =5;
            Length = 6;
            break;
            }
            case SimFormats.Nano : {
          Width =8.8;
          Length = 12.3;
          break;
         }
            case SimFormats.Micro : {
          Width =12;
          Length = 15;
          break;
         }
      case SimFormats.Mini :{
          Width =15;
          Length = 25;
          break;
         }
      case SimFormats.FullSize:{
          Width =53.98;
          Length = 85.60;
          break;
         }
	    }   
            return $"{simFormat.ToString()}: width {Width}, length {Length}";
        }

        public override string ToString()
        {
            string message = $"Phonenumber {PhoneNumber}, ";
            message+= GetSimFormatDetails(vSimFormat);
            return message;
        }

    }
}
