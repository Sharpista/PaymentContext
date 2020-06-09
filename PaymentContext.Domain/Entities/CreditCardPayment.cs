using System;
using PayementContext.Domain.ValueObjects;

namespace PayementContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string cardHolderName, string lastThreeCardNumber, string lastTransactionNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Email email, Adress adress)
        :base(paidDate, expireDate, total, totalPaid, payer, document, email, adress)
        {
            CardHolderName = cardHolderName;
            LastThreeCardNumber = lastThreeCardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string LastThreeCardNumber { get;  private set; }
        public string LastTransactionNumber { get; private set; }
    }
}