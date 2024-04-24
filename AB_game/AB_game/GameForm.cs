using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB_game
{
    public partial class GameForm : Form
    {

        private string secretNumber;

        public GameForm()
        {
            InitializeComponent();
            if (codemakerToolStripMenuItem.Checked )
            {
                InitializeCodemakerMode();
            }
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
        }
        private void InitializeCodemakerMode()
        {
            // Example: Hide controls related to codebreaker mode
            // codebreakerControls.Visible = false;

            // Example: Show controls related to codemaker mode
            // codemakerControls.Visible = true;

            // Example: Generate secret number
            if (codemakerToolStripMenuItem.Checked)
            {
                string secretNumber = GenerateSecretNumber();
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
            InitializeCodebreakerMode();
            codebreakerToolStripMenuItem.Checked = true;
            codemakerToolStripMenuItem.Checked = false;
        }
        private void InitializeCodebreakerMode()
        {
            // Example: Hide controls related to codemaker mode
            // codemakerControls.Visible = false;

            // Example: Show controls related to codebreaker mode
            // codebreakerControls.Visible = true;

            // Example: Clear any previous guesses
            // ClearPreviousGuesses();
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

    }
}
