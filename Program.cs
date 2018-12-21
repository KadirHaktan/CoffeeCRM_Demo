using CoffeeCRM_Demo.Coffee.Abstract;
using CoffeeCRM_Demo.Coffee.Concrete.Starbucks;
using CoffeeCRM_Demo.Object.Concrete;
using CoffeeCRM_Demo.ServicesAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCRM_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomerBaseManager manager = new StarBucksCustomersManager(new MernisServicesAdapter());

            try
            {
                manager.Save(new Customer
                {
                    DateofBirth = new DateTime(1999, 1, 14),
                    FirstName = "Kadir Haktan",
                    LastName = "Yücesoy",
                    NationalityID = "53122281420"
                });
            }
            
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            Console.ReadLine();
        }
    }
}
