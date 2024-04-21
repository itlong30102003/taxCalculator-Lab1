using taxCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testlab1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculate_1()
        {
            float salary = 10000000; // 10,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 0; // 0 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);
            float expectedTax = 0;

            Assert.AreEqual(expectedTax, tax, 0.01, "Tax calculated is incorrect for salary.");
        }
        [TestMethod]
        public void TestCalculate_2()
        {
            float salary = 10000000; // 10,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 1; // 1 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);
            float expectedTax = 0;

            Assert.AreEqual(expectedTax, tax, 0.01, "Tax calculated is incorrect for salary.");
        }
        [TestMethod]
        public void TestCalculate_3()
        {
            float salary = 15000000; // 15,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 0; // 0 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);
            float expectedTax = 168500;

            Assert.AreEqual(expectedTax, tax, 0.01, "Tax calculated is incorrect for salary.");
        }
        [TestMethod]
        public void TestCalculate_4()
        {
            float salary = 15000000; // 15,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 1; // 1 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);
            float expectedTax = 0;

            Assert.AreEqual(expectedTax, tax, 0.01, "Tax calculated is incorrect for salary.");
        }
        [TestMethod]
        public void TestCalculate_5()
        {
            float salary = 20000000; // 20,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 0; //  0 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);
            float expectedTax = 587000;

            Assert.AreEqual(expectedTax, tax, 0.01, "Tax calculated is incorrect for salary.");
        }
        [TestMethod]
        public void TestCalculate_6()
        {
            float salary = 20000000; //20,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 1; // 1 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);
            float expectedTax = 198500;

            Assert.AreEqual(expectedTax, tax, 0.01, "Tax calculated is incorrect for salary.");
        }
        [TestMethod]
        public void TestCalculate_7()
        {
            float salary = 40000000; // 40,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 0; //  0 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);
            float expectedTax = 4024000;

            Assert.AreEqual(expectedTax, tax, 0.01, "Tax calculated is incorrect for salary.");
        }
        [TestMethod]
        public void TestCalculate_8()
        {
            float salary = 40000000; // 40,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 1; // 1 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);
            float expectedTax = 3144000;

            Assert.AreEqual(expectedTax, tax, 0.01, "Tax calculated is incorrect for salary.");
        }
        [TestMethod]
        public void TestCalculate_9()
        {
            float salary = 60000000; // 60,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 0; // 0 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);
            float expectedTax = 8842500;

            Assert.AreEqual(expectedTax, tax, 0.01, "Tax calculated is incorrect for salary.");
        }
        [TestMethod]
        public void TestCalculate_10()
        {
            float salary = 60000000; // 60,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 1; // 1 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);
            float expectedTax = 7742500;

            Assert.AreEqual(expectedTax, tax, 0.01, "Tax calculated is incorrect for salary.");
        }
        [TestMethod]
        public void TestCalculate_11()
        {
            float salary = 90000000; // 90,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 0; // 1 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);
            float expectedTax = 17661000;

            Assert.AreEqual(expectedTax, tax, 0.01, "Tax calculated is incorrect for salary.");
        }
        [TestMethod]
        public void TestCalculate_12()
        {
            float salary = 90000000; // 90,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 1; // 1 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);
            float expectedTax = 16341000;

            Assert.AreEqual(expectedTax, tax, 0.01, "Tax calculated is incorrect for salary.");
        }
    }
}