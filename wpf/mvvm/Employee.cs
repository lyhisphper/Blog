using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm
{
    class Employee
    {
        string _userName;
        string _companyName;

        public string UserName
        {
            get{ return _userName; }
            set{ _userName = value; }
        }
        public string CompanyName
        {
            get{ return _companyName; }
            set{ _companyName = value; } 
        }
    }
}
