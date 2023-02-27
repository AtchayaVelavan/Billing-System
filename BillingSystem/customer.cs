using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem
{
    public class customer
    {
        string _custid;

        public string Custid
        {
            get { return _custid; }
            set { _custid = value; }
        }


        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        string _mobileno;

        public string Mobileno
        {
            get { return _mobileno; }
            set
            {
                    _mobileno = value;
               
            }
        }

     

        string _mailid;

        public string Mailid
        {
            get { return _mailid; }
            set { _mailid = value; }
        }

    
    
    
    }

 
}
