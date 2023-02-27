using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem
{
    class Product
    {
        int _productid;

        public int Productid
        {
            get { return _productid; }
            set { _productid = value; }
        }
        
        string _productname;

        public string Productname
        {
            get { return _productname; }
            set { _productname = value; }
        }
        int _unitprice;

        public int Unitprice
        {
            get { return _unitprice; }
            set { _unitprice = value; }
        }
        int _taxcategory;

        public int Taxcategory
        {
            get { return _taxcategory; }
            set { _taxcategory = value; }
        }
        string _status;

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
