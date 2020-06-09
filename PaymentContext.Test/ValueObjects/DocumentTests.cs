using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayementContext.Domain.Enums;
using PayementContext.Domain.ValueObjects;

namespace PayementContext.Test.ValueObjects
{
    [TestClass]
    public class DocumentTest
    {
        // se quiser se especializar mais sobre Testes Red, Green , Refactor
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var d = new Document("1234",EDocumentType.CNPJ);
            Assert.IsTrue(d.Invalid);

        }

        [TestMethod] 
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            var d = new Document("12345678901234",EDocumentType.CNPJ);
            Assert.IsTrue(d.Valid);

        }

        
        [TestMethod] 
        public void ShouldReturnSuccessWhenCPFIsInvalid()
        {
           var d = new Document("1234",EDocumentType.CPF);
            Assert.IsTrue(d.Invalid);

        }

        //CASO EU QUEIRA TESTAR MAIS DE UM.
        [TestMethod]
        [DataTestMethod]
        [DataRow("63558713060")]
        [DataRow("81489418075")]
        [DataRow("53816731082")]
        [DataRow("77613455033")]
        [DataRow("12714154026")]
        public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
        {
            var d = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(d.Valid);

        }
    
    
    }
}