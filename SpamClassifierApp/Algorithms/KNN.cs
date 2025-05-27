using SpamClassifierApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamClassifierApp.Algorithms
{
    public class KNN
    {
        private List<Email> trainingData;
        private HashSet<string> vocabulary;

        public void Train(List<Email> emails)
        {
            trainingData = emails;
            vocabulary = new HashSet<string>();

            foreach (var email in emails)
            {
                foreach (var word in email.Content.Split(' '))
                    vocabulary.Add(word);
            }

            Console.WriteLine("Vocabulary:");
            Console.WriteLine(string.Join(", ", vocabulary));
        }

        public (string label, int spamVotes, int hamVotes, List<(double distance, string label)> topKList) Classify(string input, int k = 3)
        {
            var inputVec = Vectorize(input);
            var distances = new List<(double distance, string label)>();

            foreach (var email in trainingData)
            {
                var emailVec = Vectorize(email.Content);
                double distance = EuclideanDistance(inputVec, emailVec);
                distances.Add((distance, email.Label));
            }

            var topK = distances.OrderBy(x => x.distance).Take(k).ToList();
            var spamVotes = topK.Count(x => x.label.ToLower() == "spam");
            var hamVotes = topK.Count(x => x.label.ToLower() == "ham");

            string label = spamVotes > hamVotes ? "spam" : "ham";
            return (label, spamVotes, hamVotes, topK);
        }


        private double[] Vectorize(string content)
        {
            var words = content.Split(' ');
            double[] vector = new double[vocabulary.Count];
            var vocabList = vocabulary.ToList();

            for (int i = 0; i < vocabList.Count; i++)
                vector[i] = words.Count(w => w == vocabList[i]);

            return vector;
        }

        private double EuclideanDistance(double[] vec1, double[] vec2)
        {
            double sum = 0;
            for (int i = 0; i < vec1.Length; i++)
                sum += Math.Pow(vec1[i] - vec2[i], 2);

            return Math.Sqrt(sum);
        }

        private void PrintVector(double[] vector)
        {
            Console.WriteLine("[ " + string.Join(", ", vector.Select(v => v.ToString("F0"))) + " ]");
        }
    }
}
