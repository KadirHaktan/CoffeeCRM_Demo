using CoffeeCRM_Demo.Processing.Abstract;
using CoffeeCRM_Demo.ServicesAdapter.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeCRM_Demo.Object.Concrete;
using CoffeeCRM_Demo.MernisServicesReference;

namespace CoffeeCRM_Demo.ServicesAdapter
{
    public class MernisServicesAdapter : IAdapter
    {
        public bool MakeTheProcess(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();

            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityID), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateofBirth.Year);
        }
    }
}
