namespace ConundrumGame
{
    partial class Form1
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.submitName = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(121, 13);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Conundrum";
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Location = new System.Drawing.Point(12, 32);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(126, 13);
            this.enterNameLabel.TabIndex = 1;
            this.enterNameLabel.Text = "Please Enter Your Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(170, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // submitName
            // 
            this.submitName.Location = new System.Drawing.Point(12, 74);
            this.submitName.Name = "submitName";
            this.submitName.Size = new System.Drawing.Size(86, 25);
            this.submitName.TabIndex = 3;
            this.submitName.Text = "Start!";
            this.submitName.UseVisualStyleBackColor = true;
            this.submitName.Click += new System.EventHandler(this.submitName_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(104, 74);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(78, 25);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Exit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 111);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.submitName);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.enterNameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Form1";
            this.Text = "Conundrum";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button submitName;
        private System.Windows.Forms.Button quitButton;
    }
}

