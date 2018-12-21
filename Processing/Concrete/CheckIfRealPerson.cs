using CoffeeCRM_Demo.Processing.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeCRM_Demo.Object.Concrete;
using CoffeeCRM_Demo.MernisServicesReference;
using CoffeeCRM_Demo.ServicesAdapter.Abstract;

namespace CoffeeCRM_Demo.Processing.Concrete
{
    public class CheckIfRealPerson : IProcess
    {      
        public bool MakeTheProcess(Customer customer)
        {
            return true;
        }
    }
}
