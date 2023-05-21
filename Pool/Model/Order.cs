using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Model
{
    public class Order
    {
        public int OrderId { get; set; }

        public int SubscriptionID { get; set; }

        public int ClientID { get; set; }

        public int CustomerID { get; set; }

        public DateTime StartSubscription { get; set; }

        public DateTime EndSubscription { get; set; }

        public DateTime DayOfPurchase { get; set; }

        public decimal FullCost { get; set; }

        public DateTime PaymentDay { get; set; }

    }
}
