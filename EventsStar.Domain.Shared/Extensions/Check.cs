﻿namespace EventsStar.Domain.Shared.Extensions
{
    public static class Check
    {
        public static string NotNullOrWhiteSpace(string value, string parameterName, int maxLength = int.MaxValue, int minLength = 0)
        {
            if (value.IsNullOrWhiteSpace())
            {
                throw new ArgumentException(parameterName + " can not be null, empty or white space!", parameterName);
            }

            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{parameterName} length must be equal to or lower than {maxLength}!", parameterName);
            }

            if (minLength > 0 && value.Length < minLength)
            {
                throw new ArgumentException($"{parameterName} length must be equal to or bigger than {minLength}!", parameterName);
            }

            return value;
        }

        public static string NotNullOrEmpty(string value, string parameterName, int maxLength = int.MaxValue, int minLength = 0)
        {
            if (value.IsNullOrEmpty())
            {
                throw new ArgumentException(parameterName + " can not be null or empty!", parameterName);
            }

            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{parameterName} length must be equal to or lower than {maxLength}!", parameterName);
            }

            if (minLength > 0 && value.Length < minLength)
            {
                throw new ArgumentException($"{parameterName} length must be equal to or bigger than {minLength}!", parameterName);
            }

            return value;
        }


    }
}
