using taxCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

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
            
            tax.Should().Be(0);
        }
        [TestMethod]
        public void TestCalculate_2()
        {
            float salary = 10000000; // 10,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 1; // 1 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);

            tax.Should().Be(0);
        }
        [TestMethod]
        public void TestCalculate_3()
        {
            float salary = 15000000; // 15,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 0; // 0 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);
            
            tax.Should().Be(168500);
        }
        [TestMethod]
        public void TestCalculate_4()
        {
            float salary = 15000000; // 15,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 1; // 1 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);

            tax.Should().Be(0);
        }
        [TestMethod]
        public void TestCalculate_5()
        {
            float salary = 20000000; // 20,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 0; //  0 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);

            tax.Should().Be(587000);
        }
        [TestMethod]
        public void TestCalculate_6()
        {
            float salary = 20000000; //20,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 1; // 1 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);

            tax.Should().Be(198500);
        }
        [TestMethod]
        public void TestCalculate_7()
        {
            float salary = 40000000; // 40,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 0; //  0 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);

            tax.Should().Be(4024000);
        }
        [TestMethod]
        public void TestCalculate_8()
        {
            float salary = 40000000; // 40,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 1; // 1 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);

            tax.Should().Be(3144000);
        }
        [TestMethod]
        public void TestCalculate_9()
        {
            float salary = 60000000; // 60,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 0; // 0 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);

            tax.Should().Be(8842500);
        }
        [TestMethod]
        public void TestCalculate_10()
        {
            float salary = 60000000; // 60,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 1; // 1 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);

            tax.Should().Be(7742500);
        }
        [TestMethod]
        public void TestCalculate_11()
        {
            float salary = 90000000; // 90,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 0; // 1 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);

            tax.Should().Be(17661000);
        }
        [TestMethod]
        public void TestCalculate_12()
        {
            float salary = 90000000; // 90,000,000 VND
            float income = 6000000; // 6,000,000 VND
            float dependent = 1; // 1 nguoi phu thuoc

            float tax = TaxCalculator.Calculate(salary, income, dependent);

            tax.Should().Be(16341000);
        }
    }
}