using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeCRM_Demo.Object.Concrete;

namespace CoffeeCRM_Demo.Coffee.Abstract
{
    public abstract class CustomerBaseManager : ICustomerManager
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Customer saved to database");
        }
    }
}
