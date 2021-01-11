using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_MPA.Models
{
    public class Store
    {   
        public int StoreID { get; set; }
        public int EmployeeID { get; set; }
        public int ProductID { get; set; }

        public Employee Employee { get; set; }
        public Product Product { get; set; }
    }
}
