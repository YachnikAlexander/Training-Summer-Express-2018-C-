using System;
using NUnit.Framework;
using CustomeFormat;
using System.Globalization;

namespace Customers.Tests
{
    [TestFixture]
    public class CusomerTests
    {

        [TestCase("Sasha Yachnik", 100000,"8578399", ExpectedResult = "Name_Revenue_ContactPhone:Sasha Yachnik,100000,00,8578399")]

        [Test]
        public string Customer_Name_Revenue_ContactPhone_Tests(string name, decimal revenue, string contactPhone)
        {
            Customer temp = new Customer(name, revenue, contactPhone);

            return temp.ToString("Name_Revenue_ContactPhone");
        }

        [TestCase("Sasha Yachnik", 100000, "8578399", ExpectedResult = "Sasha Yachnik,100000")]

        [Test]
        public string Customer_Name_Revenue_Tests(string name, decimal revenue, string contactPhone)
        {
            Customer temp = new Customer(name, revenue, contactPhone);

            return temp.ToString("Name_Revenue");
        }

        [TestCase("Sasha Yachnik", 100000, "8578399", ExpectedResult = "Sasha Yachnik")]

        [Test]
        public string Customer_Name_Tests(string name, decimal revenue, string contactPhone)
        {
            Customer temp = new Customer(name, revenue, contactPhone);

            return temp.ToString("Name");
        }

        [TestCase("Sasha Yachnik", 100000, "8578399", ExpectedResult = "100000,00")]

        [Test]
        public string Customer_Revenue_Tests(string name, decimal revenue, string contactPhone)
        {
            Customer temp = new Customer(name, revenue, contactPhone);

            return temp.ToString("Revenue");
        }

        [TestCase("Sasha Yachnik", 100000, "8578399", ExpectedResult = "8578399")]

        [Test]
        public string Customer_ContactPhone_Tests(string name, decimal revenue, string contactPhone)
        {
            Customer temp = new Customer(name, revenue, contactPhone);

            return temp.ToString("ContactPhone");
        }

        [TestCase(null, 16, "8578399")]
        public void Customer_ArgumentNullException_Tests(string name, decimal revenue, string contactPhone)
        {
            Assert.Throws<ArgumentNullException>(() => new Customer(name, revenue, contactPhone));
        }

        [TestCase("sasha", -16, "8578399")]
        public void Customer_ArgumentException1_Tests(string name, decimal revenue, string contactPhone)
        {
            Assert.Throws<ArgumentException>(() => new Customer(name, revenue, contactPhone));
        }

        [TestCase("sasha", 16, null)]
        public void Customer_ArgumentNullException2_Tests(string name, decimal revenue, string contactPhone)
        {
            Assert.Throws<ArgumentNullException>(() => new Customer(name, revenue, contactPhone));
        }

        [TestCase("sasha", 16, "+67678300")]
        public void Customer_ArgumentException2_Tests(string name, decimal revenue, string contactPhone)
        {
            Assert.Throws<ArgumentException>(() => new Customer(name, revenue, contactPhone));
        }

    }
}
