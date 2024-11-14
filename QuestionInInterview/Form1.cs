using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic;
using static System.Windows.Forms.LinkLabel;
using System.Drawing;
using System.Threading.Tasks;
using System.DirectoryServices.ActiveDirectory;
using System.ComponentModel;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Threading;
using System.Drawing.Drawing2D;

namespace QuestionInInterview
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            List<string> wordsToSearch = new List<string> { "cold", "wind", "snow", "chill" };
            string[] matrix = {
            "abcgc",
            "fgwio",
            "chill",
            "pqnsd",
            "uvdxy"
        };
            // Initialize WordMatrixFinder with the given matrix
            WordFinder finder = new WordFinder(matrix);

            // Get the count of occurrences for each word
            var wordCounts = finder.Find(wordsToSearch);

            string resultText = "";

            // Output the results
            // order by descending to get the most apeared word and take the top 10 of them 
            Console.WriteLine("Word Occurrences in the Matrix:");
            wordCounts= wordCounts.Where(kvp => kvp.Value>0)
                        .OrderByDescending(kvp => kvp.Value) 
                        .Take(10)                            
                        .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var entry in wordCounts)
            {

                resultText += $"'{entry.Key}' \n";

                // if you like to show how many times a word appeard then use this 
                //resultText += $"'{entry.Key}' appears {entry.Value} times \n";
            }
            MessageBox.Show(resultText);
           
        }
    }
}

