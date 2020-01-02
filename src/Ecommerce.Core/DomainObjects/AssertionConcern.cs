﻿using System.Text.RegularExpressions;

namespace Ecommerce.Core.DomainObjects
{
    public class AssertionConcern
    {
        public static void ValidateIfEqual(object object1, object object2, string message)
        {
            if (object1.Equals(object2))
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfDifferent(object object1, object object2, string message)
        {
            if (!object1.Equals(object2))
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfDifferentByRegex(string pattern, string value, string message)
        {
            var regex = new Regex(pattern);

            if (!regex.IsMatch(value))
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateSizeMax(string value, int max, string message)
        {
            var length = value.Trim().Length;
            if (length > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateSizeBetweenMinAndMax(string value, int min, int max, string message)
        {
            var length = value.Trim().Length;
            if (length < min || length > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfEmpty(string value, string message)
        {
            if (value == null || value.Trim().Length == 0)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfNull(object object1, string message)
        {
            if (object1 == null)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateBetweenMinAndMaxDouble(double value, double min, double max, string message)
        {
            if (value < min || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateBetweenMinAndMaxFloat(float value, float min, float max, string message)
        {
            if (value < min || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateBetweenMinAndMaxInt(int value, int min, int max, string message)
        {
            if (value < min || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateBetweenMinAndMaxLong(long value, long min, long max, string message)
        {
            if (value < min || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateBetweenMinAndMaxDecimal(decimal value, decimal min, long max, string message)
        {
            if (value < min || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfLessThanMinLong(long value, long min, string message)
        {
            if (value < min)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfLessThanMinDouble(double value, double min, string message)
        {
            if (value < min)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfLessThanMinDecimal(decimal value, decimal min, string message)
        {
            if (value < min)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfLessThanMinInt(int value, int min, string message)
        {
            if (value < min)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfFalse(bool boolvalue, string message)
        {
            if (!boolvalue)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfTrue(bool boolvalue, string message)
        {
            if (boolvalue)
            {
                throw new DomainException(message);
            }
        }
    }
}
