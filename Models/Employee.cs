using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_MPA.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Salary { get; set; }
        public ICollection<Store> Stores { get; set; }
    }
}