using System;
using Flunt.Validations;
using PayementContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PayementContext.Domain.Entities {
    public abstract class Payment : Entity {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Email email, Adress adress)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Email = email;
            Adress = adress;
            AddNotifications(new Contract()
            .Requires()
            .IsLowerThan(0,Total,"Payment.Total", "O total não pode ser zero")
            .IsGreaterOrEqualsThan(Total, TotalPaid,"Payment.TotalPaid", "o valor pago é menor que o total" )
            );
        }

        public string Number { get; set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get;  private set; }
        public decimal TotalPaid { get; private set; }
        public string Payer { get; private set; }
        public Document Document { get; private set; } 
        public Email Email { get; private set; }
        public Adress Adress { get; private set; }
    }
}