using NUnit.Framework;

namespace HRLibrary.UnitTests_
{
    [TestFixture]
    public class Tests
    {
        static Subscriber sub;

        [SetUp]
        public void Setup()
        {
            sub = new Subscriber("Jonh", "Smith", 8119480348, 54542);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(sub.Name, Is.EqualTo("John")); 
            Assert.That(sub.Surname, Is.EqualTo("Smith")); 
            Assert.That(sub.PhoneNumber, Is.EqualTo(8119480348));
            Assert.That(sub.ContractNumber, Is.EqualTo(54542));
        }

        [Test] 
        public void TariffNameGetter_Subscriber() 
        { 
            Assert.That(sub.TariffName, Is.EqualTo("Smart")); 
        }

        [Test]
        public void PaymentTypeGetter_Subscriber()
        {
            Assert.That(sub.PaymentType, Is.EqualTo(PaymentType.Credit));
        }

        public void SumGetter_Subscriber()
        {
            Assert.That(sub.Sum, Is.EqualTo(1223));
        }

        [Test] 
        public void GetInfo_Subscriber_ValuesString() 
        { 
            string expectedInfo = "John Smith. "; 
            expectedInfo += "Телефонный номер: 8119480348. "; 
            expectedInfo += "Номер договора: 54542. "; 
            expectedInfo += $"Название тарифа: Smart. ";
            expectedInfo += $"Тип оплаты: {PaymentType.Credit}. ";
            expectedInfo += $"Сумма на личном счете: 1223.";
            Assert.That(sub.GetInfo(), Is.EqualTo(expectedInfo)); }
    }
}