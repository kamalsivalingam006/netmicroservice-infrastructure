using System;
using System.Text.RegularExpressions;

namespace netmicroservice.infrastructure.Utils
{
    public static class StringExtensions
    {
        public static bool IsAlphaNumeric(this string input)
        {
            Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
            return rg.IsMatch(input);
        }
    }
}
