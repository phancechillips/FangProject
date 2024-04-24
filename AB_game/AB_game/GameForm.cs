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
        public GameForm()
        {
            InitializeComponent();
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
            InitializeCodemakerMode();
        }
        private void InitializeCodemakerMode()
        {
            // Example: Hide controls related to codebreaker mode
            // codebreakerControls.Visible = false;

            // Example: Show controls related to codemaker mode
            // codemakerControls.Visible = true;

            // Example: Generate secret number
            string secretNumber = GenerateSecretNumber();
            MessageBox.Show($"Secret Number: {secretNumber}", "Codemaker Mode");
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
            string secretNumber = string.Join("", digits);
            return secretNumber;
        }

        private void codebreakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeCodebreakerMode();
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
    }
}
