using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Utility
{

    public static class UniqueCodeGenerator
    {
        private static readonly char[] Base32Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567".ToCharArray();

        public static string GenerateUniqueCodeFromTimestamp()
        {
            // Get the current timestamp in ticks
            long ticks = DateTime.UtcNow.Ticks;

            // Convert ticks to Base32
            string base32String = ConvertToBase32(ticks);

            // Ensure the code is exactly 7 characters long
            // If shorter, pad with 'A'; if longer, truncate
            return base32String.Length >= 7 ? base32String.Substring(0, 7) : base32String.PadRight(7, 'A');
        }

        private static string ConvertToBase32(long input)
        {
            char[] buffer = new char[13]; // Max length for 64-bit number in Base32
            int i = 12;
            do
            {
                buffer[i--] = Base32Chars[input % 32];
                input /= 32;
            } while (input != 0);

            return new string(buffer, i + 1, 12 - i);
        }
    }
    }
