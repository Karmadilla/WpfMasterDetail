using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.Business
{
    public class LineItem
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public string PartNumber { get; set; }
        public int Cost { get; set; }
    }
}