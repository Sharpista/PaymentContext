using System;
using PayementContext.Domain.ValueObjects;

namespace PayementContext.Domain.Entities
{
    public class PaypalPayment : Payment
    {
        public PaypalPayment(string transactionNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Email email, Adress adress)
        : base( paidDate,  expireDate,  total,  totalPaid,  payer,  document,  email, adress)
        {
            TransactionNumber = transactionNumber;
        }

        public string TransactionNumber { get; private set; }
    }
}