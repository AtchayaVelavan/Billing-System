using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem
{
   public class bill
    {
        List<customer> cust = new List<customer>();

        public List<customer> Cust
        {
            get { return cust; }
            set { cust = value; }
        }
    }
}
