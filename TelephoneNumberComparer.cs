using HRLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HRLibrary2
{
   
    public class TelephoneNumberComparer: IComparer<Subscriber>
    {
        public int Compare(Subscriber sub1, Subscriber sub2)
        {

            return (int)sub1.PhoneNumber - (int)sub2.PhoneNumber;

        }
    }
}
