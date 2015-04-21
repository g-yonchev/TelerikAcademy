using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public static class ValidateData
    {
        public static void ValidateRequiredRule(string value, string parametar)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(string.Format("The {0} is required", parametar));
            }
            
        }

        internal static void ValidatePositiveRule(decimal value, string parametar)
        {
            if (value <= 0.0M)
            {
                throw new ArgumentException(string.Format("The {0} must be positive", parametar));
            }
        }

        internal static void ValidatePositiveRule(int value, string parametar)
        {
            if (value <= 0)
            {
                throw new ArgumentException(string.Format("The {0} must be positive", parametar));
            }
        }

        internal static void ValidateNonNegativeRule(int value, string parametar)
        {
            if (value < 0)
            {
                throw new ArgumentException(string.Format("The {0} must be non-negative", parametar));
            }
        }
    }
}
