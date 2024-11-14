using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionInInterview
{
    internal class WordFinder
    {
        private readonly char[][] matrix;
        private readonly int numRows;
        private readonly int numCols;

        // Constructor to initialize the matrix
        public WordFinder(string[] matrixInput)
        {
            matrix = new char[matrixInput.Length][];
            for (int i = 0; i < matrixInput.Length; i++)
            {
                matrix[i] = matrixInput[i].ToCharArray();
            }
            numRows = matrix.Length;
            numCols = matrix[0].Length;
        }

        // Method to count occurrences of multiple words in the matrix
        public Dictionary<string, int> Find(IEnumerable<string> words)
        {
            var wordCountDict = new Dictionary<string, int>();

            // Count occurrences for each word in the list
            foreach (var word in words)
            {
                int count = CountWordOccurrences(word);
                wordCountDict[word] = count;
            }

            return wordCountDict;
        }

        // Method to find the number of repetitions of a single word in the matrix
        private int CountWordOccurrences(string word)
        {
            int count = 0;
            int wordLength = word.Length;

            // Traverse each cell in the matrix
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    // Check horizontally (to the right)
                    if (col + wordLength <= numCols && IsHorizontalMatch(row, col, word))
                        count++;

                    // Check vertically (downward)
                    if (row + wordLength <= numRows && IsVerticalMatch(row, col, word))
                        count++;
                }
            }

            return count;
        }

        // Check for a horizontal match starting at (row, col)
        private bool IsHorizontalMatch(int row, int col, string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (matrix[row][col + i] != word[i])
                    return false;
            }
            return true;
        }

        // Check for a vertical match starting at (row, col)
        private bool IsVerticalMatch(int row, int col, string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (matrix[row + i][col] != word[i])
                    return false;
            }
            return true;
        }
    }
}
