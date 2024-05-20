using NepaliCalendarBS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ecom.Utility
{
    public static class CalendarBSAD
    {
        public static string FixDate(DateTime date)
        {
            // Convert the DateTime to NepaliDate and then to a string
            NepaliDate nepaliDate = new NepaliDate();
            // Implement the actual conversion logic here and format as needed
            // For demonstration, assuming NepaliDate has a meaningful ToString implementation
            return nepaliDate.ToString();
        }

        public static string FixDate(DateTime? date)
        {
            if (date.HasValue)
            {
                return FixDate(date.Value);
            }
            else
            {
                return string.Empty; // Handle null case appropriately
            }
        }
    }

}
