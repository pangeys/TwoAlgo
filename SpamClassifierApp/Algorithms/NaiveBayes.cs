using SpamClassifierApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamClassifierApp.Algorithms
{
    public class NaiveBayes
    {
        private Dictionary<string, int> spamWordCounts = new Dictionary<string, int>();
        private Dictionary<string, int> hamWordCounts = new Dictionary<string, int>();
        private int spamEmailCount = 0;
        private int hamEmailCount = 0;
        private int spamTotalWords = 0;
        private int hamTotalWords = 0;
        private HashSet<string> vocabulary = new HashSet<string>();

        public void Train(List<Email> trainingData)
        {
            foreach (var email in trainingData)
            {
                var words = email.Content.Split(' ');
                if (email.Label == "spam")
                {
                    spamEmailCount++;
                    foreach (var word in words)
                    {
                        spamWordCounts[word] = spamWordCounts.ContainsKey(word) ? spamWordCounts[word] + 1 : 1;
                        spamTotalWords++;
                        vocabulary.Add(word);
                    }
                }
                else
                {
                    hamEmailCount++;
                    foreach (var word in words)
                    {
                        hamWordCounts[word] = hamWordCounts.ContainsKey(word) ? hamWordCounts[word] + 1 : 1;
                        hamTotalWords++;
                        vocabulary.Add(word);
                    }
                }
            }
        }

        public string Classify(string emailContent)
        {
            var words = emailContent.Split(' ');
            double pSpam = Math.Log((double)spamEmailCount / (spamEmailCount + hamEmailCount));
            double pHam = Math.Log((double)hamEmailCount / (spamEmailCount + hamEmailCount));
            int V = vocabulary.Count;

            foreach (var word in words)
            {
                int spamCount = spamWordCounts.ContainsKey(word) ? spamWordCounts[word] : 0;
                int hamCount = hamWordCounts.ContainsKey(word) ? hamWordCounts[word] : 0;

                pSpam += Math.Log((spamCount + 1.0) / (spamTotalWords + V));
                pHam += Math.Log((hamCount + 1.0) / (hamTotalWords + V));
            }

            return pSpam > pHam ? "spam" : "ham";
        }
    }
}
