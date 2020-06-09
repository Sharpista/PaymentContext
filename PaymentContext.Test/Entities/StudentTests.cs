using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entites;
using PaymentContext.Domain.Entities;
using PayementContext.Domain.Enums;
using PayementContext.Domain.Entities;
using System;
using PayementContext.Domain.ValueObjects;

namespace PayementContext.Test
{
    [TestClass]
    public class StudentTests
    {
        private readonly Student _student;
        private readonly Subscription _subscription;
        private readonly Name _name;
        private readonly Document _document;
        private readonly Adress _address;
        private readonly Email _email;

        public StudentTests()
        {
            _name = new Name("Alexandre", "Filho");
            _document = new Document("12345607714", EDocumentType.CPF);
            _email = new Email("alexandre@flho.com");
            _student = new Student(_name, _document, _email);
            _subscription = new Subscription(null);
            _address = new Adress("Rua Palas", "52", "Pavuna", "Rio de Janeiro","RJ", "BR", "1234567" );
            
        }
        [TestMethod]
        public void ShouldReturnErroWhenHadActiveSubscription()
        {  
            var payment = new PaypalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5),10,10, "ARX DEV", _document, null, _address);
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Invalid);

        }
        /* REFATORAR TESTES 
        [TestMethod]
        public void ShouldReturnSuccessWhenHadActiveSubscription()
        {  
            var payment = new PaypalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5),10,10, "ARX DEV", _document, null, _address);
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Valid);
        }
        [TestMethod]
        public void ShouldReturnErrorWhenSubscriptionHasNoPayment()
        {  
            _student.AddSubscription(_subscription);
            Assert.IsTrue( _student.Invalid);
        }
        [TestMethod]
        public void ShouldReturnSuccessWhenAddSubscription()
        {  
               var payment = new PaypalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5),10,10, "ARX DEV", _document, null, _address);
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
       

            Assert.IsTrue(_student.Valid);
        }
        */
    }
}