using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.CommonModules.Entity
{
    internal class Delivery
    {
        public int delivery_ID { get; set; }
        public int customer_ID { get; set; }
        public DateTime date { get; set; }
    }
}
