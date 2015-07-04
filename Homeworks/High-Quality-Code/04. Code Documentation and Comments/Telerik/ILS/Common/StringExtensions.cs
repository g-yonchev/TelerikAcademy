﻿namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Static class providing various extension methods for the <see cref="System.String"/> class.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// String extension method which converts the input string to hash array.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns the hexadecimal string.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// String extension method which ckecks whether the input string contains a true-like value.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns whether the string contains true-like value.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// String extension method which tries to convert the input string into Int16 representation.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns variable of type Int16 if the string is a number, null - otherwise.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// String extension method which tries to convert the input string into Int32 representation.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns variable of type Int32 if the string is a number, null - otherwise.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// String extension method which tries to convert the input string into Int64 representation.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns variable of type Int64 if the string is a number, null - otherwise.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// String extension method which tries to convert the input string into DateTime representation.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns variable of type DateTime if the string can be parsed, null - otherwise.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// String extension method which capitalizes the first letter of the input string. 
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns the input string with capital first letter.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// String extension method which returns the substring between two given strings. 
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <param name="startString">Start of the substring.</param>
        /// <param name="endString">End of the substring.</param>
        /// <param name="startFrom">Index to start search from (optional).</param>
        /// <returns>Returns the substring between startString and endString. If the substrings are not cointained in the input string - returns an empty string.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// String extension method which converts the cyrillic letters from the input string into their latin representation. 
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns a converted cyrillic text to latin one.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// String extension method which converts the latin letters from the input string into their cyrillic representation. 
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns a converted latin text to cyrillic one.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// String extension method which replaces invalid symbols in the input string with an empty string and converts a valid filename.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns a new valid username.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// String extension method which replaces invalid symbols in the input string with an empty string and converts a valid filename.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns a new valid filename.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// String extension method which returns first N characters of the input string.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <param name="charsCount">The count of the characters to be returned.</param>
        /// <returns>Returns the beginning of the input string as a substring with lenght equals to charsCount. If the charsCount is greater than the lenght of the input string, returns whole string.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// String extension method which returns the extention of a given filename represented as a string.
        /// </summary>
        /// <param name="fileName">The filename represented as a string on which the method is invoked.</param>
        /// <returns>Returns the file extention of the filename. If the input string is null or whitespace, or the filename has no extension, returns an empty string.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// String extension method which returns the content type of a file determined by its extension.
        /// </summary>
        /// <param name="fileExtension">The extension of a filename represented as a string on which the method is invoked.</param>
        /// <returns>Returns the content type if known, "application/octet-stream" - otherwise.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// String extension method which converts the input string to a byte array.
        /// </summary>
        /// <param name="input">The string on which the method is invoked.</param>
        /// <returns>Returns a byte array of the input string</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
