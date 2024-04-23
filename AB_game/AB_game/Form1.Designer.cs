namespace AB_game
{
    partial class WelcForm
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
            this.teamName = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // teamName
            // 
            this.teamName.BackColor = System.Drawing.SystemColors.Control;
            this.teamName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamName.Location = new System.Drawing.Point(173, 76);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(463, 109);
            this.teamName.TabIndex = 0;
            this.teamName.Text = "Group #15";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(42, 221);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(726, 73);
            this.nameBox.TabIndex = 1;
            this.nameBox.Text = "Niccolo, Prianna, Chance";
            // 
            // WelcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.teamName);
            this.Name = "WelcForm";
            this.Text = "Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamName;
        private System.Windows.Forms.TextBox nameBox;
    }
}

