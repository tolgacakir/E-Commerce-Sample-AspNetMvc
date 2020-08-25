using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ECommerceSample.Core.Utilities
{
    public static class StringHelper
    {
        public static string SelectTextByMaxLength(this string value, int maxLength)
        {
            value = value.RemoveHtml();
            return value.Length < maxLength ? value : value.Substring(0, maxLength) + "...";
        }
        public static string RemoveHtml(this string value)
        {
            return string.IsNullOrEmpty(value) ? string.Empty : Regex.Replace(value, "<.*?>", String.Empty);
        }
        public static string ToUrlFriendly(this string value)
        {
            value = value.ToLower().Replace("&", "").Replace(".", "-").Replace("ş", "s").Replace("ü", "u").Replace("ö", "o").Replace("ı", "i").Replace("ğ", "g").Replace("ç", "c").Replace(",", "").Replace(".", "").Replace("'", "").Replace("(", "").Replace(")", "").Replace("!", "");
            value = Regex.Replace(value, @"\s+", " ", RegexOptions.Compiled).Replace(" ", "-");
            return value;
        }
    }
}
