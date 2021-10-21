using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPISQL.Models
{
    public class Payment
    {
        public int paymentId { get; set; }
        public string cardOwnerName { get; set; }
        public string cardNumber { get; set; }
        public DateTime expirationDate { get; set; }
        public string securityCode { get; set; }
    }
}
