using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.CommonModules.Entity
{
    internal class TransactionReport
    {
        public int transactionReport_ID { get; set; }
        public int cutomer_ID { get; set; }
        public int order_ID { get; set; }
        public int propduct_ID { get; set; }
        public int  payment_ID { get; set; }

    }
}
