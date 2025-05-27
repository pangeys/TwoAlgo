using SpamClassifierApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SpamClassifierApp.Data
{
    public static class DataLoader
    {
        public static List<Email> LoadEmails(string csvFilePath)
        {
            var emails = new List<Email>();
            var lines = File.ReadAllLines(csvFilePath);

            // Skip header, parse each line as "content,label"
            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts.Length >= 2)
                {
                    emails.Add(new Email
                    {
                        Content = parts[0].Trim('\"'), // remove quotes
                        Label = parts[1].Trim()
                    });
                }
            }
            return emails;
        }
    }
}