using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConundrumGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int count;
        public int score;
        public int difficulty;

        private void easyDiff_Click(object sender, EventArgs e)
        {
            difficulty diff = new difficulty();

            word word = new word();

            // Sets the count to 0.
            count = 0;

            // Sets the string displayWord to the returned value from getWord_easy.
            String displayWord = word.getWord_easy(count);

            // Displays the word to the user.
            guessWordBox.Text = displayWord;

            // Shows the correct label for the difficulty chosen. 
            easyDiffLabel.Show();
            medDiffLabel.Hide();
            hardDiffLabel.Hide();

            // Shows the new word button.
            newWordButton.Show();

            // Sets the difficulty variable to 1 (easy)
            difficulty = 1;

            //WB Tetsing
            Console.WriteLine("Easy Button Press");
            Console.WriteLine("Expected difficulty EASY");
            Console.WriteLine("Difficulty: " + difficulty);
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Current Word: " + displayWord);
        }

        private void medDIff_Click(object sender, EventArgs e)
        {
            difficulty diff = new difficulty();

            word word = new word();

            // Sets the count to 0.
            count = 0;

            // Sets the string displayWord to the returned value from getWord_med.
            String displayWord = word.getWord_med(count);

            // Displays the word to the user.
            guessWordBox.Text = displayWord;

            // Shows the correct label for the difficulty chosen. 
            easyDiffLabel.Show();
            medDiffLabel.Hide();
            hardDiffLabel.Hide();

            // Shows the new word button.
            newWordButton.Show();

            // Sets the difficulty variable to 2 (medium)
            difficulty = 2;

            //WB Tetsing
            Console.WriteLine("Medium Button Press");
            Console.WriteLine("Expected difficulty MEDIUM");
            Console.WriteLine("Difficulty: " + difficulty);
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Current Word: " + displayWord);
        }

        private void hardDiff_Click(object sender, EventArgs e)
        {
            difficulty diff = new difficulty();

            word word = new word();

            // Sets the count to 0.
            count = 0;

            // Sets the string displayWord to the returned value from getWord_hard.
            String displayWord = word.getWord_hard(count);

            // Displays the word to the user.
            guessWordBox.Text = displayWord;

            // Shows the correct label for the difficulty chosen. 
            easyDiffLabel.Show();
            medDiffLabel.Hide();
            hardDiffLabel.Hide();

            // Shows the new word button.
            newWordButton.Show();

            // Sets the difficulty variable to 3 (hard)
            difficulty = 3;

            //WB Tetsing
            Console.WriteLine("Hard Button Press");
            Console.WriteLine("Expected difficulty HARD");
            Console.WriteLine("Difficulty: " + difficulty);
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Current Word: " + displayWord);
        }

        private void newWordButton_Click(object sender, EventArgs e)
        {
            difficulty diff = new difficulty();

            // Increase Count.
            count ++;

            // If difficulty is easy.
            if (difficulty == 1)
            {
                word word = new word();

                // Get easy word from file.
                String displayWord = word.getWord_easy(count);

                // Display word to user.
                guessWordBox.Text = displayWord;

                //WB Testing
                Console.WriteLine("New Word Button Press");
                Console.WriteLine("Expected Difficulty EASY");
                Console.WriteLine("Difficulty: " + difficulty);
                Console.WriteLine("New word displayed: " + displayWord);
            }
            // If difficulty is medium.
            if (difficulty == 2)
            {
                word word = new word();

                // Get medium word from file.
                String displayWord = word.getWord_med(count);

                // Display word to user.
                guessWordBox.Text = displayWord;

                //WB Testing
                Console.WriteLine("New Word Button Press");
                Console.WriteLine("Expected Difficulty MEDIUM");
                Console.WriteLine("Difficulty: " + difficulty);
                Console.WriteLine("New word displayed: " + displayWord);
            }
            // If difficulty is hard.
            if (difficulty == 3)
            {
                word word = new word();

                // Get hard word from file.
                String displayWord = word.getWord_hard(count);

                // Display word to user.
                guessWordBox.Text = displayWord;

                //WB Testing
                Console.WriteLine("New Word Button Press");
                Console.WriteLine("Expected Difficulty HARD");
                Console.WriteLine("Difficulty: " + difficulty);
                Console.WriteLine("New word displayed: " + displayWord);
            }

            //WB Testing
            Console.WriteLine("New Count: " + count);
        }

        private void submitWord_Click(object sender, EventArgs e)
        {
            difficulty diff = new difficulty();
            word word = new word();

            // Gets user input and stores in String variable userAnswer.
            String userAnswer = answerWordBox.Text;

            // If difficulty is easy.
            if (difficulty == 1)
            {
                // Sets vaiable result with returned value from compareWord method.
                bool result = word.compareWord_easy(userAnswer, count);

                // If result is true.
                if (result == true)
                {
                    // New Word

                    // Increase count.
                    count++;

                    // Get new word.
                    String displayWord = word.getWord_easy(count);

                    // Display new word to user.
                    guessWordBox.Text = displayWord;

                    // Increase Score.
                    score++;

                    //WB Testing
                    Console.WriteLine("Submit Button Press");
                    Console.WriteLine("Returned value: " + result);
                    Console.WriteLine("New Count: " + count);
                    Console.WriteLine("New Score: " + score);
                }
                else
                {
                    // Minus one from score.
                    score--;
                    // Show message box containing error message.
                    MessageBox.Show("Thats Incorrect -1 Point");

                    //WB Testing
                    Console.WriteLine("Submit Button Press");
                    Console.WriteLine("Returned value: " + result);
                    Console.WriteLine("New Count: " + count);
                    Console.WriteLine("New Score: " + score);
                }

                scoreLabel.Text = score.ToString();
            }
            // If difficulty is medium.
            if (difficulty == 2)
            {
                bool result = word.compareWord_med(userAnswer, count);

                if (result == true)
                {
                    // New Word

                    // Increase count.
                    count++;

                    // Get new word.
                    String displayWord = word.getWord_med(count);

                    // Display new word to user.
                    guessWordBox.Text = displayWord;

                    // Increase Score.
                    score++;

                    //WB Testing
                    Console.WriteLine("Submit Button Press");
                    Console.WriteLine("Returned value: " + result);
                    Console.WriteLine("New Count: " + count);
                    Console.WriteLine("New Score: " + score);
                }
                else
                {
                    // Minus one from score.
                    score--;
                    // Show message box containing error message.
                    MessageBox.Show("Thats Incorrect -1 Point");

                    //WB Testing
                    Console.WriteLine("Submit Button Press");
                    Console.WriteLine("Returned value: " + result);
                    Console.WriteLine("New Count: " + count);
                    Console.WriteLine("New Score: " + score);
                }

                scoreLabel.Text = score.ToString();
            }
            // If difficulty is hard.
            if (difficulty == 3)
            {
                bool result = word.compareWord_hard(userAnswer, count);

                if (result == true)
                {
                    // New Word

                    // Increase count.
                    count++;

                    // Get new word.
                    String displayWord = word.getWord_hard(count);

                    // Display new word to user.
                    guessWordBox.Text = displayWord;

                    // Increase Score.
                    score++;
                    //WB Testing
                    Console.WriteLine("Submit Button Press");
                    Console.WriteLine("Returned value: " + result);
                    Console.WriteLine("New Count: " + count);
                    Console.WriteLine("New Score: " + score);
                }
                else
                {
                    // Minus one from score.
                    score--;
                    // Show message box containing error message.
                    MessageBox.Show("Thats Incorrect -1 Point");

                    //WB Testing
                    Console.WriteLine("Submit Button Press");
                    Console.WriteLine("Returned value: " + result);
                    Console.WriteLine("New Count: " + count);
                    Console.WriteLine("New Score: " + score);
                }

                scoreLabel.Text = score.ToString();
            }

            

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // When form loads.
            player player = new player();
            // Set player name label using setName method from player class.
            String playerName = player.setName();

            // Sets the player name label.
            playerNameLabel.Text = playerName;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Ecit the application when the exit button is pressed.
            Application.Exit();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // If form 2 is closed, then show form 1.
            Form f1 = new Form1();
            f1.Show();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            // New game button closes the current form.
            this.Close();
        }
    }
}
