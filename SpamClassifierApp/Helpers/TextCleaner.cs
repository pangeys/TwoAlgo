using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpamClassifierApp.Helpers
{
    public static class TextCleaner
    {
        public static string CleanText(string input)
        {
            input = input.ToLower();
            input = Regex.Replace(input, @"[^\w\s]", ""); // Remove punctuation
            input = Regex.Replace(input, @"\d", "");      // Remove digits
            input = Regex.Replace(input, @"\s+", " ");    // Normalize spaces
            return input.Trim();
        }
    }
}
