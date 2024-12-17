using System;
using System.Collections.Generic;

namespace AutomationCore.Helpers
{
    public static class Randomizer
    {
        private static readonly Random _random = new Random();

        /// <summary>
        /// Generates a random integer within the specified range.
        /// </summary>
        /// <param name="min">Minimum value (inclusive).</param>
        /// <param name="max">Maximum value (exclusive).</param>
        /// <returns>A random integer.</returns>
        public static int GetRandomInt(int min, int max)
        {
            return _random.Next(min, max);
        }

        /// <summary>
        /// Generates a random double between 0.0 and 1.0.
        /// </summary>
        /// <returns>A random double.</returns>
        public static double GetRandomDouble()
        {
            return _random.NextDouble();
        }

        /// <summary>
        /// Generates a random string of the specified length using alphanumeric characters.
        /// </summary>
        /// <param name="length">Length of the random string.</param>
        /// <returns>A random string.</returns>
        public static string GetRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = chars[_random.Next(chars.Length)];
            }
            return new string(result);
        }

        /// <summary>
        /// Shuffles an array of items randomly.
        /// </summary>
        /// <typeparam name="T">Type of the array elements.</typeparam>
        /// <param name="array">Array to shuffle.</param>
        public static void ShuffleArray<T>(T[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = _random.Next(i + 1);
                // Swap array[i] with array[j]
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        /// <summary>
        /// Generates a random email address.
        /// </summary>
        public static string GetRandomEmail()
        {
            string user = GetRandomString(_random.Next(5, 10)); // Random user name
            string domain = GetRandomString(_random.Next(5, 8)); // Random domain
            string tld = GetRandomString(3); // Top-level domain (e.g., com, net)
            return $"{user}@{domain}.{tld}";
        }

        /// <summary>
        /// Generates a random phone number.
        /// </summary>
        public static string GetRandomPhoneNumber()
        {
            //string countryCode = "891"; // Example: for India, change as needed
            string phone = $"{_random.Next(600, 999)}{_random.Next(1000000, 9999999)}";
            return $"{phone}";
        }

        /// <summary>
        /// Selects a random value from a given list.
        /// </summary>
        public static T GetRandomValue<T>(List<T> values)
        {
            if (values == null || values.Count == 0)
            {
                throw new ArgumentException("The values list must not be null or empty.");
            }

            int index = _random.Next(values.Count);
            return values[index];
        }
    }
}