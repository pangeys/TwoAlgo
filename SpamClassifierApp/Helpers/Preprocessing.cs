using SpamClassifierApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamClassifierApp.Helpers
{
    public static class Preprocessing
    {
        public static string Preprocess(string input)
        {
            return TextCleaner.CleanText(input);
            // You can add tokenization, stop word removal here later
        }
    }
}
