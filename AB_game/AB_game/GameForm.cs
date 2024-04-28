﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB_game
{
    public partial class GameForm : Form
    {
        private ABGame abGame;
        private GameLogger gameLogger;
        private string secretNumber;
        private List<string> possibleNumbers;
        private string currentGuess;

        public GameForm()
        {
            InitializeComponent();
            UpdateGameMode();
            abGame = new ABGame(); // Instantiate ABGame class
            gameLogger = new GameLogger(); // Instantiate GameLogger class
        }

        private void UpdateGameMode()
        {
            if (codemakerToolStripMenuItem.Checked)
            {
                InitializeCodemakerMode();
            }
            else if (codebreakerToolStripMenuItem.Checked)
            {
                InitializeCodebreakerMode();
            }
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

        private void welcomeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void scoreLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreForm scoreForm = new ScoreForm();
            scoreForm.Show();
        }

        private void codemakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codemakerToolStripMenuItem.Checked = true;
            codebreakerToolStripMenuItem.Checked = false;
            UpdateGameMode();
        }

        private void InitializeCodemakerMode()
        {
            label2.Visible = false;
            label6.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            txtCurrentGuess.Visible = false;
            label4.Visible = false;
            txtFeedback.Visible = false;
            btnSubmitFeedback.Visible = false;
            lstGuessHistory.Visible = false;

            label1.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            userGuessLabel.Visible = true;
            txtGuess.Visible = true;
            submitButton.Visible = true;
            lstGuesses.Visible = true;
            if (codemakerToolStripMenuItem.Checked)
            {
                string secretNumber = GenerateSecretNumber();
                InitializePossibleNumbers();
            }
        }

        private string GenerateSecretNumber()
        {
            Random random = new Random();
            int[] digits = new int[4];

            // Generate random non-repeating digits
            for (int i = 0; i < 4; i++)
            {
                int digit;
                do
                {
                    digit = random.Next(0, 10);
                } while (Array.IndexOf(digits, digit) != -1);

                digits[i] = digit;
            }

            // Convert digits to string
            secretNumber = string.Join("", digits);
            return secretNumber;
        }

        public string EvaluateGuess(string guess)
        {
            int aCount = 0;
            int bCount = 0;

            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == secretNumber[i])
                {
                    aCount++;
                }
                else if (secretNumber.Contains(guess[i]))
                {
                    bCount++;
                }
            }

            return $"{aCount}A{bCount}B";
        }

        private void codebreakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codebreakerToolStripMenuItem.Checked = true;
            codemakerToolStripMenuItem.Checked = false;
            UpdateGameMode();
        }

        private void InitializeCodebreakerMode()
        {
            
            label2.Visible = true;
            label6.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            txtCurrentGuess.Visible = true;
            label4.Visible = true;
            txtFeedback.Visible = true;
            btnSubmitFeedback.Visible = true;
            lstGuessHistory.Visible = true;

            
            label1.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            userGuessLabel.Visible = false;
            txtGuess.Visible = false;
            submitButton.Visible = false;
            lstGuesses.Visible = false;
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string userGuess = txtGuess.Text.Trim();

            if (userGuess.Length != 4 || !userGuess.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid four-digit number with no repeated digits.");
                return;
            }

            string hint = EvaluateGuess(userGuess);
            lstGuesses.Items.Add($"{userGuess} - {hint}");

            txtGuess.Clear(); // Clear the textbox for the next guess
            txtGuess.Focus(); // Set focus back to the textbox
        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            string feedback = txtFeedback.Text.Trim();
            if (!IsValidFeedback(feedback))
            {
                MessageBox.Show("Please enter feedback in the format xAxB.");
                return;
            }

            lstGuessHistory.Items.Add($"{currentGuess} - {feedback}");
            currentGuess = ProcessFeedbackAndMakeNextGuess(currentGuess, feedback);
            if (currentGuess == null)
            {
                MessageBox.Show("No more possible numbers, or the correct number was guessed!");
                btnSubmitFeedback.Enabled = false; // Disable the button, as the game is over
                return;
            }

            txtCurrentGuess.Text = currentGuess;
            txtFeedback.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Your label1 click event handler code here
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Your label2 click event handler code here
        }
    }
}
