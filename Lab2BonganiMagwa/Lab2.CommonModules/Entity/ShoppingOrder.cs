using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.CommonModules.Entity
{
    internal class ShoppingOrder
    {
        public int order_ID { get; set; }
        public int customer { get; set; }
        public DateTime date { get; set; }
    }
}
