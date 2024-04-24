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
            this.userGuess = new System.Windows.Forms.TextBox();
            this.userGuessLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameModeToolStripMenuItem});
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
            this.codemakerToolStripMenuItem.Name = "codemakerToolStripMenuItem";
            this.codemakerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codemakerToolStripMenuItem.Text = "Codemaker";
            // 
            // codebreakerToolStripMenuItem
            // 
            this.codebreakerToolStripMenuItem.Name = "codebreakerToolStripMenuItem";
            this.codebreakerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codebreakerToolStripMenuItem.Text = "Codebreaker";
            // 
            // userGuess
            // 
            this.userGuess.Location = new System.Drawing.Point(15, 60);
            this.userGuess.Name = "userGuess";
            this.userGuess.Size = new System.Drawing.Size(100, 20);
            this.userGuess.TabIndex = 1;
            // 
            // userGuessLabel
            // 
            this.userGuessLabel.AutoSize = true;
            this.userGuessLabel.Location = new System.Drawing.Point(12, 44);
            this.userGuessLabel.Name = "userGuessLabel";
            this.userGuessLabel.Size = new System.Drawing.Size(92, 13);
            this.userGuessLabel.TabIndex = 2;
            this.userGuessLabel.Text = "Enter your guess: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 134);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetGameToolStripMenuItem.Text = "Reset Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.userGuessLabel);
            this.Controls.Add(this.userGuess);
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
        private System.Windows.Forms.TextBox userGuess;
        private System.Windows.Forms.Label userGuessLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}