namespace ConundrumGame
{
    partial class Form2
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
            this.difficultyQLabel = new System.Windows.Forms.Label();
            this.easyDiff = new System.Windows.Forms.Button();
            this.medDIff = new System.Windows.Forms.Button();
            this.hardDiff = new System.Windows.Forms.Button();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.easyDiffLabel = new System.Windows.Forms.Label();
            this.medDiffLabel = new System.Windows.Forms.Label();
            this.hardDiffLabel = new System.Windows.Forms.Label();
            this.newWordButton = new System.Windows.Forms.Button();
            this.yourScoreLabel = new System.Windows.Forms.Label();
            this.guessWordBox = new System.Windows.Forms.TextBox();
            this.answerWordBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.submitWord = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // difficultyQLabel
            // 
            this.difficultyQLabel.AutoSize = true;
            this.difficultyQLabel.Location = new System.Drawing.Point(12, 9);
            this.difficultyQLabel.Name = "difficultyQLabel";
            this.difficultyQLabel.Size = new System.Drawing.Size(143, 13);
            this.difficultyQLabel.TabIndex = 0;
            this.difficultyQLabel.Text = "Please Select Your Difficulty:";
            // 
            // easyDiff
            // 
            this.easyDiff.Location = new System.Drawing.Point(12, 35);
            this.easyDiff.Name = "easyDiff";
            this.easyDiff.Size = new System.Drawing.Size(75, 23);
            this.easyDiff.TabIndex = 4;
            this.easyDiff.Text = "Easy";
            this.easyDiff.UseVisualStyleBackColor = true;
            this.easyDiff.Click += new System.EventHandler(this.easyDiff_Click);
            // 
            // medDIff
            // 
            this.medDIff.Location = new System.Drawing.Point(12, 64);
            this.medDIff.Name = "medDIff";
            this.medDIff.Size = new System.Drawing.Size(75, 23);
            this.medDIff.TabIndex = 5;
            this.medDIff.Text = "Medium";
            this.medDIff.UseVisualStyleBackColor = true;
            this.medDIff.Click += new System.EventHandler(this.medDIff_Click);
            // 
            // hardDiff
            // 
            this.hardDiff.Location = new System.Drawing.Point(12, 93);
            this.hardDiff.Name = "hardDiff";
            this.hardDiff.Size = new System.Drawing.Size(75, 23);
            this.hardDiff.TabIndex = 6;
            this.hardDiff.Text = "Hard";
            this.hardDiff.UseVisualStyleBackColor = true;
            this.hardDiff.Click += new System.EventHandler(this.hardDiff_Click);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(532, 9);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(50, 13);
            this.difficultyLabel.TabIndex = 7;
            this.difficultyLabel.Text = "Difficulty:";
            // 
            // easyDiffLabel
            // 
            this.easyDiffLabel.AutoSize = true;
            this.easyDiffLabel.Location = new System.Drawing.Point(588, 9);
            this.easyDiffLabel.Name = "easyDiffLabel";
            this.easyDiffLabel.Size = new System.Drawing.Size(30, 13);
            this.easyDiffLabel.TabIndex = 8;
            this.easyDiffLabel.Text = "Easy";
            this.easyDiffLabel.Visible = false;
            // 
            // medDiffLabel
            // 
            this.medDiffLabel.AutoSize = true;
            this.medDiffLabel.Location = new System.Drawing.Point(583, 9);
            this.medDiffLabel.Name = "medDiffLabel";
            this.medDiffLabel.Size = new System.Drawing.Size(44, 13);
            this.medDiffLabel.TabIndex = 9;
            this.medDiffLabel.Text = "Medium";
            this.medDiffLabel.Visible = false;
            // 
            // hardDiffLabel
            // 
            this.hardDiffLabel.AutoSize = true;
            this.hardDiffLabel.Location = new System.Drawing.Point(583, 9);
            this.hardDiffLabel.Name = "hardDiffLabel";
            this.hardDiffLabel.Size = new System.Drawing.Size(30, 13);
            this.hardDiffLabel.TabIndex = 10;
            this.hardDiffLabel.Text = "Hard";
            this.hardDiffLabel.Visible = false;
            // 
            // newWordButton
            // 
            this.newWordButton.Location = new System.Drawing.Point(12, 226);
            this.newWordButton.Name = "newWordButton";
            this.newWordButton.Size = new System.Drawing.Size(155, 23);
            this.newWordButton.TabIndex = 11;
            this.newWordButton.Text = "New Word";
            this.newWordButton.UseVisualStyleBackColor = true;
            this.newWordButton.Visible = false;
            this.newWordButton.Click += new System.EventHandler(this.newWordButton_Click);
            // 
            // yourScoreLabel
            // 
            this.yourScoreLabel.AutoSize = true;
            this.yourScoreLabel.Location = new System.Drawing.Point(532, 35);
            this.yourScoreLabel.Name = "yourScoreLabel";
            this.yourScoreLabel.Size = new System.Drawing.Size(63, 13);
            this.yourScoreLabel.TabIndex = 12;
            this.yourScoreLabel.Text = "Your Score:";
            // 
            // guessWordBox
            // 
            this.guessWordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessWordBox.Location = new System.Drawing.Point(167, 49);
            this.guessWordBox.Name = "guessWordBox";
            this.guessWordBox.Size = new System.Drawing.Size(307, 38);
            this.guessWordBox.TabIndex = 13;
            // 
            // answerWordBox
            // 
            this.answerWordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerWordBox.Location = new System.Drawing.Point(167, 119);
            this.answerWordBox.Name = "answerWordBox";
            this.answerWordBox.Size = new System.Drawing.Size(307, 38);
            this.answerWordBox.TabIndex = 14;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(164, 103);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(70, 13);
            this.answerLabel.TabIndex = 15;
            this.answerLabel.Text = "Your Answer:";
            // 
            // submitWord
            // 
            this.submitWord.Location = new System.Drawing.Point(262, 163);
            this.submitWord.Name = "submitWord";
            this.submitWord.Size = new System.Drawing.Size(109, 23);
            this.submitWord.TabIndex = 17;
            this.submitWord.Text = "Submit Word";
            this.submitWord.UseVisualStyleBackColor = true;
            this.submitWord.Click += new System.EventHandler(this.submitWord_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(594, 35);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(13, 13);
            this.scoreLabel.TabIndex = 18;
            this.scoreLabel.Text = "0";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(377, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(100, 13);
            this.welcomeLabel.TabIndex = 20;
            this.welcomeLabel.Text = "You are playing as: ";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(471, 9);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(33, 13);
            this.playerNameLabel.TabIndex = 21;
            this.playerNameLabel.Text = "None";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(474, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(155, 23);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(243, 226);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(155, 23);
            this.newGameButton.TabIndex = 23;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 261);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.submitWord);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.answerWordBox);
            this.Controls.Add(this.guessWordBox);
            this.Controls.Add(this.yourScoreLabel);
            this.Controls.Add(this.newWordButton);
            this.Controls.Add(this.hardDiffLabel);
            this.Controls.Add(this.medDiffLabel);
            this.Controls.Add(this.easyDiffLabel);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.hardDiff);
            this.Controls.Add(this.medDIff);
            this.Controls.Add(this.easyDiff);
            this.Controls.Add(this.difficultyQLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label difficultyQLabel;
        private System.Windows.Forms.Button easyDiff;
        private System.Windows.Forms.Button medDIff;
        private System.Windows.Forms.Button hardDiff;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label easyDiffLabel;
        private System.Windows.Forms.Label medDiffLabel;
        private System.Windows.Forms.Label hardDiffLabel;
        private System.Windows.Forms.Button newWordButton;
        private System.Windows.Forms.Label yourScoreLabel;
        private System.Windows.Forms.TextBox guessWordBox;
        private System.Windows.Forms.TextBox answerWordBox;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button submitWord;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button newGameButton;
    }
}