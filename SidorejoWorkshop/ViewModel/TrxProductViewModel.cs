using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SidorejoWorkshop.ViewModel
{
    public class TrxProductViewModel
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public int SellPrice { get; set; }
        public int Subtotal { get; set; }
    }
}
