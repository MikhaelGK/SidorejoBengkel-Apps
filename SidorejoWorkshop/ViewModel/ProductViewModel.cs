using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SidorejoWorkshop.ViewModel
{
    public class ProductViewModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public string CostPrice { get; set; }
        public string Price { get; set; }
    }
}
