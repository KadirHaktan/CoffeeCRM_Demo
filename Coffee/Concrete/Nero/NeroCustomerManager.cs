using CoffeeCRM_Demo.Coffee.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCRM_Demo.Coffee.Concrete.Nero
{
    public class NeroCustomerManager:CustomerBaseManager
    {
       private IProcess process { get; set; }

        public StarBucksCustomersManager(IProcess process)
        {
            this.process = process;
        }

        public override void Save(Customer customer)
        {
            if (process.MakeTheProcess(customer))
            {
                base.Save(customer);
            }

            else
            {
                throw new Exception("Not a valid type customer");
            }
            
        }
      
    }
}
