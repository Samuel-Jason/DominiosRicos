using DominiosRicos.Entities;

namespace DominiosRicos.Entities
{
    public class PaypalPaymentPayment : Payment
    {
        public PaypalPaymentPayment(
            string transactionCode,
            DateTime date,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string owner,
            string document,
            string address,
            string email) : base(
                date,
                expireDate,
                total,
                totalPaid,
                owner,
                document,
                address,
                email)
        {
            TransactionCode = transactionCode;
        }
        public string TransactionCode { get; private set; }
    }
}
