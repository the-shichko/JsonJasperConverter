using System.Diagnostics.CodeAnalysis;

namespace JsonJasperConverter.Extensions
{
    public static class StringExtensions
    {
        public static string FirstCharToLowerCase([NotNull] this string str)
        {
            if (string.IsNullOrEmpty(str) || char.IsLower(str[0]))
                return str;

            return char.ToLower(str[0]) + str[1..];
        }
        public static string FirstCharToUpperCase([NotNull] this string str)
        {
            if (string.IsNullOrEmpty(str) || char.IsUpper(str[0]))
                return str;

            return char.ToUpper(str[0]) + str[1..];
        }
        
    }
}