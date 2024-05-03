﻿

namespace DominiosRicos.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(
            string barCode,
            string boletoNumber,
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
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}
