using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CIS3433
{
    public class ABGame
    {
        private List<string> possibleNumbers;

        public ABGame()
        {
            InitializePossibleNumbers();
        }

        private void InitializePossibleNumbers()
        {
            possibleNumbers = new List<string>();
            for (int i = 0; i < 10000; i++)
            {
                string candidate = i.ToString("D4");
                if (candidate.Distinct().Count() == 4)
                {
                    possibleNumbers.Add(candidate);
                }
            }
        }

        public string MakeInitialGuess()
        {
            return possibleNumbers[0]; // Return the first possibility
        }

        public string ProcessFeedbackAndMakeNextGuess(string currentGuess, string feedback)
        {
            // Ensure that possibleNumbers is initialized if it's found to be null.
            if (possibleNumbers == null)
            {
                InitializePossibleNumbers();
            }

            // Now we are sure possibleNumbers is not null, proceed with filtering.
            possibleNumbers = possibleNumbers.Where(num => MatchFeedback(num, currentGuess, feedback)).ToList();
            return possibleNumbers.FirstOrDefault(); // This will be null if no possibilities remain
        }

        private bool MatchFeedback(string candidate, string guess, string feedback)
        {
            int aCount = 0;
            int bCount = 0;
            for (int i = 0; i < 4; i++)
            {
                if (candidate[i] == guess[i])
                {
                    aCount++;
                }
                else if (guess.Contains(candidate[i]))
                {
                    bCount++;
                }
            }
            return $"{aCount}A{bCount}B" == feedback;
        }

        public bool IsValidFeedback(string feedback)
        {
            return Regex.IsMatch(feedback, @"^[0-4]A[0-4]B$");
        }
    }
}
