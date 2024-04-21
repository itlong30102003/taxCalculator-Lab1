namespace taxCalculator
{
    //[TestClass]
    public class TaxCalculator
    {
        //[TestMethod]
        public static float Calculate(float salary, float income, float dependent)
        {
            float taxable_income = salary - (income * 0.105F) - 11000000 - (dependent * 4400000);
            Console.WriteLine("Taxable_income: " + taxable_income.ToString());

            if (taxable_income < 0)
                return 0;

            float taxRate = 0;
            float tax;
            switch (taxable_income)
            {
                case float n when (n <= 5000000):
                    taxRate = 0.05F;
                    break;
                case float n when (n <= 10000000):
                    taxRate = 0.1F;
                    break;
                case float n when (n <= 18000000):
                    taxRate = 0.15F;
                    break;
                case float n when (n <= 32000000):
                    taxRate = 0.20F;
                    break;
                case float n when (n <= 52000000):
                    taxRate = 0.25F;
                    break;
                case float n when (n <= 80000000):
                    taxRate = 0.30F;
                    break;
                default:
                    taxRate = 0.35F;
                    break;
            }
            if (taxRate == 0.05f)
                tax = taxable_income * 0.05f;
            else if (taxRate == 0.10f)
                tax = taxable_income * 0.10f - 250000;
            else if (taxRate == 0.15f)
                tax = taxable_income * 0.15f - 750000;
            else if (taxRate == 0.20f)
                tax = taxable_income * 0.20f - 1650000;
            else if (taxRate == 0.25f)
                tax = taxable_income * 0.25f - 3250000;
            else if (taxRate == 0.30f)
                tax = taxable_income * 0.30f - 5850000;
            else if (taxRate == 0.35f)
                tax = taxable_income * 0.35f - 9850000;
            else
                tax = 0;

            return tax;
        }
    }
}