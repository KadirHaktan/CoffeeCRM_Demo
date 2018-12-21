using CoffeeCRM_Demo.Object.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCRM_Demo.Processing.Abstract
{
    public interface IProcess
    {
        bool MakeTheProcess(Customer customer);
    }
}
