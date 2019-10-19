using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm
{
    class EmployeeViewModel : NotificationBase
    {
        Employee employee;

        public EmployeeViewModel()
        {
            employee = new Employee() { UserName = "马云", CompanyName = "阿里巴巴" };
        }

        public string UserName
        {
            get { return employee.UserName; }
            set
            {
                employee.UserName = value;
                RaisePropertyChanged("UserName");
            }
        }

        public string CompanyName
        {
            get { return employee.CompanyName; }
            set
            {
                employee.CompanyName = value;
                RaisePropertyChanged("CompanyName");
            }
        }

    }

    public class NotificationBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
