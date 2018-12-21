using CoffeeCRM_Demo.Object.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCRM_Demo.Coffee.Abstract
{
    public interface ICustomerManager
    {
        void Save(Customer customer);
    }
}
