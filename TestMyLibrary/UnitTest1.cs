using NUnit.Framework;
using MyLibrarry;
using System;


namespace TestMyLibrary
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testaddd()
        {
            double fist = 5.1;
            double second = 7.1;
            double result = Calc.Add(fist, second);
            Assert.AreEqual(result,12.2);
        }
        [Test]
        public void TestIdentity()
        {
            Client client = new Client
            {
                FirstName = "петрОВ",
                LastName = "игорь",
                Polynomic = "васильевич"
            };
            DateTime dateTime = DateTime.Now;
            Class2 class2 = new Class2();
            string pattern = "Петров_И.В._" + dateTime.ToString("MM.dd.yyyy_HH_mm");
            string result = class2.Identity(client, dateTime);
            Assert.AreEqual(result, pattern);
        }
    }
}