using CoffeeCRM_Demo.Object.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCRM_Demo.Object.Concrete
{
   public class Customer:IEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string NationalityID { get; set; }
        
       //Veritabanı tablosuna temsil eden sınıf diyebiliriz.Bu temsil eden sınıf IEntity denilen temel yapıdan miras almış.
    }
}
