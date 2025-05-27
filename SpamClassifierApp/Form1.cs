using SpamClassifierApp.Algorithms;
using SpamClassifierApp.Data;
using SpamClassifierApp.Helpers;
using SpamClassifierApp.Models;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;        
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpamClassifierApp
{
    public partial class Form1 : Form
    {
        private NaiveBayes naiveBayes = new NaiveBayes();
        private KNN knn = new KNN();
        private List<Email> emails;

        public Form1()
        {
            InitializeComponent();

            cmbAlgorithm.Items.AddRange(new[] { "Naive Bayes", "KNN", "Divide and Conquer" });
            cmbAlgorithm.SelectedIndex = 0;

            // Load and train on startup (example)
            emails = DataLoader.LoadEmails(@"Data/SampleEmails.csv");
            
            foreach (var e in emails)
                e.Content = Preprocessing.Preprocess(e.Content);

            naiveBayes.Train(emails);
            knn.Train(emails);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var rawEmail = txtEmail.Text;
            var cleanedEmail = Preprocessing.Preprocess(rawEmail);
            string result = "";
            txtDetails.Clear(); // Clear previous output

            if (cmbAlgorithm.SelectedItem.ToString() == "Naive Bayes")
            {
                result = naiveBayes.Classify(cleanedEmail);
                lblResult.Text = $"Prediction: {result.ToUpper()}";

                txtDetails.AppendText("Algorithm: Naive Bayes\r\n");
                txtDetails.AppendText($"Final Decision: {result.ToUpper()}\r\n");
            }
            else if (cmbAlgorithm.SelectedItem.ToString() == "KNN")
            {
                int k = (int)numK.Value; // Ensure you have a NumericUpDown named numK
                var knn = new KNN();
                knn.Train(emails); // make sure 'emails' is already preprocessed

                var (label, spamVotes, hamVotes, topKList) = knn.Classify(cleanedEmail, k);
                lblResult.Text = $"Prediction: {label.ToUpper()}";

                txtDetails.AppendText("Algorithm: KNN\r\n");
                txtDetails.AppendText($"Spam Votes: {spamVotes}\r\n");
                txtDetails.AppendText($"Ham Votes: {hamVotes}\r\n");
                txtDetails.AppendText($"Final Decision: {label.ToUpper()}\r\n");
                txtDetails.AppendText($"-- Top {k} Distances --\r\n");

                int index = 1;
                foreach (var (distance, voteLabel) in topKList)
                {
                    txtDetails.AppendText($"Distance {index}: {distance:F4}, Label: {voteLabel}\r\n");
                    index++;
                }
            }
            else
            {
                lblResult.Text = "Prediction: Unknown algorithm selected.";
                txtDetails.AppendText("Please select a valid algorithm.\r\n");
            }
        }
    }
}
