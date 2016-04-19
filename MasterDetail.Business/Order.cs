﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.Business
{
    public class Order
    {
        public int ID { get; set; }
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public List<LineItem> LineItems { get; set; }
    }
}