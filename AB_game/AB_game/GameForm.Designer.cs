namespace AB_game
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codemakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codebreakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.userGuessLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitButton = new System.Windows.Forms.Button();
            this.lstGuesses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentGuess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.lstGuessHistory = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameModeToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameModeToolStripMenuItem
            // 
            this.gameModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codemakerToolStripMenuItem,
            this.codebreakerToolStripMenuItem});
            this.gameModeToolStripMenuItem.Name = "gameModeToolStripMenuItem";
            this.gameModeToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.gameModeToolStripMenuItem.Text = "Game Mode";
            // 
            // codemakerToolStripMenuItem
            // 
            this.codemakerToolStripMenuItem.Checked = true;
            this.codemakerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.codemakerToolStripMenuItem.Name = "codemakerToolStripMenuItem";
            this.codemakerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.codemakerToolStripMenuItem.Text = "Codemaker";
            this.codemakerToolStripMenuItem.Click += new System.EventHandler(this.codemakerToolStripMenuItem_Click);
            // 
            // codebreakerToolStripMenuItem
            // 
            this.codebreakerToolStripMenuItem.Name = "codebreakerToolStripMenuItem";
            this.codebreakerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.codebreakerToolStripMenuItem.Text = "Codebreaker";
            this.codebreakerToolStripMenuItem.Click += new System.EventHandler(this.codebreakerToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeScreenToolStripMenuItem,
            this.scoreLogToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // welcomeScreenToolStripMenuItem
            // 
            this.welcomeScreenToolStripMenuItem.Name = "welcomeScreenToolStripMenuItem";
            this.welcomeScreenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.welcomeScreenToolStripMenuItem.Text = "Welcome Screen";
            this.welcomeScreenToolStripMenuItem.Click += new System.EventHandler(this.welcomeScreenToolStripMenuItem_Click);
            // 
            // scoreLogToolStripMenuItem
            // 
            this.scoreLogToolStripMenuItem.Name = "scoreLogToolStripMenuItem";
            this.scoreLogToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.scoreLogToolStripMenuItem.Text = "Score Log";
            this.scoreLogToolStripMenuItem.Click += new System.EventHandler(this.scoreLogToolStripMenuItem_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(173, 169);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 20);
            this.txtGuess.TabIndex = 1;
            // 
            // userGuessLabel
            // 
            this.userGuessLabel.AutoSize = true;
            this.userGuessLabel.Location = new System.Drawing.Point(170, 153);
            this.userGuessLabel.Name = "userGuessLabel";
            this.userGuessLabel.Size = new System.Drawing.Size(92, 13);
            this.userGuessLabel.TabIndex = 2;
            this.userGuessLabel.Text = "Enter your guess: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.resetGameToolStripMenuItem.Text = "Reset Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(279, 163);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(67, 26);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // lstGuesses
            // 
            this.lstGuesses.FormattingEnabled = true;
            this.lstGuesses.Location = new System.Drawing.Point(173, 195);
            this.lstGuesses.Name = "lstGuesses";
            this.lstGuesses.Size = new System.Drawing.Size(131, 134);
            this.lstGuesses.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codemaker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Codebreaker";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCurrentGuess
            // 
            this.txtCurrentGuess.Location = new System.Drawing.Point(475, 160);
            this.txtCurrentGuess.Name = "txtCurrentGuess";
            this.txtCurrentGuess.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentGuess.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Current guess: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Feedback Input:";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(475, 214);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(100, 20);
            this.txtFeedback.TabIndex = 11;
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.Location = new System.Drawing.Point(590, 212);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitFeedback.TabIndex = 12;
            this.btnSubmitFeedback.Text = "Submit";
            this.btnSubmitFeedback.UseVisualStyleBackColor = true;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // lstGuessHistory
            // 
            this.lstGuessHistory.FormattingEnabled = true;
            this.lstGuessHistory.Location = new System.Drawing.Point(475, 241);
            this.lstGuessHistory.Name = "lstGuessHistory";
            this.lstGuessHistory.Size = new System.Drawing.Size(120, 134);
            this.lstGuessHistory.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter your name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Enter your name: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(475, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstGuessHistory);
            this.Controls.Add(this.btnSubmitFeedback);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurrentGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstGuesses);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.userGuessLabel);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameForm";
            this.Text = "AB Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codemakerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codebreakerToolStripMenuItem;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label userGuessLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomeScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreLogToolStripMenuItem;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ListBox lstGuesses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentGuess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Button btnSubmitFeedback;
        private System.Windows.Forms.ListBox lstGuessHistory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
    }
}