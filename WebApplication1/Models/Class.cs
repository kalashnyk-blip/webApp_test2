using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Person
    {
        public Person()
        {
            OnweredCar = new List<Car>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Car> OnweredCar { get; set; }
    }
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual Person Onwer{ get; set; }
    }
}
