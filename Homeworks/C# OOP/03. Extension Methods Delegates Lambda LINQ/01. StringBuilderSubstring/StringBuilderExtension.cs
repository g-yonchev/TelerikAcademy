namespace StringBuilderSubstring
{
    using System;
    using System.Text;

    public static class StringBuilderExtension
    {
        public static StringBuilder StringBuilderSubstring(this StringBuilder strBuilder, int index, int length)
        {
            if (index < 0 || index > strBuilder.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            if (length < 0 || index + length > strBuilder.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            string builderToString = strBuilder.ToString();
            string result = builderToString.Substring(index, length);
            return new StringBuilder(result);
        }
    }
}
