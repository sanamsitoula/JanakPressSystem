using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Utility
{
    public class ModalAutoIncrement
    {

        // Static field to keep track of the last product number
        private static int lastProductNumber = 0;

        // Property to store the product code of an instance
        public string ProductCode { get; private set; }

        // Property to store the product name
        public string ProductName { get; set; }

        // Constructor to initialize a new product
        public ModalAutoIncrement(string productName)
        {
            // Assign the new product code
            ProductCode = GenerateNextProductCode();
            ProductName = productName;
        }

        // Method to get the current fiscal year
        private static string GetFiscalYear()
        {
            DateTime now = DateTime.Now;
            if (now.Month >= 4) // Assuming fiscal year starts in April
            {
                return now.Year.ToString();
            }
            else
            {
                return (now.Year - 1).ToString();
            }
        }

        // Static method to generate the next product code (increments the counter)
        public static string GenerateNextProductCode()
        {
            // Increment the last product number
            lastProductNumber++;

            // Get the current fiscal year
            string fiscalYear = GetFiscalYear();

            // Format the product code as PROD-YYYY-XXXX
            return $"PROD-{fiscalYear}-{lastProductNumber:D4}";
        }
        // Static method to get the current product code without incrementing the counter
        public static string GetCurrentProductCode()
        {
            // Get the current fiscal year
            string fiscalYear = GetFiscalYear();

            // Format the current product code as PROD-YYYY-XXXX without incrementing
            return $"PROD-{fiscalYear}-{(lastProductNumber + 1):D4}";
        }
    }
}
