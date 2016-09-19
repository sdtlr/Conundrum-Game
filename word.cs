using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConundrumGame
{
    class word
    {
        public String getWord_easy(int count)
        {
            difficulty diff = new difficulty();

            // Initialise the displayWord variable.
            String displayWord = "";

            // Runs the setEasyDiff_jumbled method and stores the returned value in fileDir.
            String fileDir = diff.setEasyDiff_jumbled();

            // Reads the file and stores the complete text document in the string wordBank.
            String wordBank = File.ReadAllText(fileDir);

            // Splits the wordBank at each semi-colon.
            String[] words = wordBank.Split(';');

            // Try catch statement used to pick up overflow on the array. 
            try
            {
                // Sets the current word.
                displayWord = words[count];
            }
            catch (Exception e)
            {
                // Displays an error message to the user if there are no more words in the text file.
                MessageBox.Show("You have run out of words. Please increase the difficulty.");
            }

            // Returns the word to be displayed.
            return displayWord;
        }
        public String getWord_med(int count)
        {
            difficulty diff = new difficulty();

            // Initialise the displayWord variable.
            String displayWord = "";

            // Runs the setMedDiff_jumbled method and stores the returned value in fileDir.
            String fileDir = diff.setMedDiff_jumbled();

            // Reads the file and stores the complete text document in the string wordBank.
            String wordBank = File.ReadAllText(fileDir);

            // Splits the wordBank at each semi-colon.
            String[] words = wordBank.Split(';');

            // Try catch statement used to pick up overflow on the array. 
            try
            {
                // Sets the current word.
                displayWord = words[count];
            }
            catch (Exception e)
            {
                // Displays an error message to the user if there are no more words in the text file.
                MessageBox.Show("You have run out of words. Please increase the difficulty.");
            }

            // Returns the word to be displayed.
            return displayWord;
        }
        public String getWord_hard(int count)
        {
            difficulty diff = new difficulty();

            // Initialise the displayWord variable.
            String displayWord = "";

            // Runs the setHardDiff_jumbled method and stores the returned value in fileDir.
            String fileDir = diff.setHardDiff_jumbled();

            // Reads the file and stores the complete text document in the string wordBank.
            String wordBank = File.ReadAllText(fileDir);

            // Splits the wordBank at each semi-colon.
            String[] words = wordBank.Split(';');

            // Try catch statement used to pick up overflow on the array. 
            try
            {
                // Sets the current word.
                displayWord = words[count];
            }
            catch (Exception e)
            {
                // Displays an error message to the user if there are no more words in the text file.
                MessageBox.Show("You have run out of words. Please increase the difficulty.");
            }

            // Returns the word to be displayed.
            return displayWord;
        }
        public bool compareWord_easy(String userAnswer, int count)
        {
            difficulty diff = new difficulty();

            // Sets the file directory by running setEasyDiff_words method, and stores in fileDir.
            String fileDir = diff.setEasyDiff_words();

            // Reads complete text file and stores in variable wordBank.
            String wordBank = File.ReadAllText(fileDir);

            // Splits the wordBank at each semi-colon.
            String[] words = wordBank.Split(';');

            // If the user answer is the same as the word read into the file.
            if (userAnswer == words[count])
            {
                // Returned value is true.
                return true;
            }
            else
            {
                // Returned value is false.
                return false;
            }

        }
        public bool compareWord_med(String userAnswer, int count)
        {
            difficulty diff = new difficulty();

            // Sets the file directory by running setEasyDiff_words method, and stores in fileDir.
            String fileDir = diff.setMedDiff_words();

            // Reads complete text file and stores in variable wordBank.
            String wordBank = File.ReadAllText(fileDir);

            // Splits the wordBank at each semi-colon.
            String[] words = wordBank.Split(';');

            // If the user answer is the same as the word read into the file.
            if (userAnswer == words[count])
            {
                // Returned value is true.
                return true;
            }
            else
            {
                // Returned value is false.
                return false;
            }
        }
        public bool compareWord_hard(String userAnswer, int count)
        {
            difficulty diff = new difficulty();

            // Sets the file directory by running setEasyDiff_words method, and stores in fileDir.
            String fileDir = diff.setHardDiff_words();

            // Reads complete text file and stores in variable wordBank.
            String wordBank = File.ReadAllText(fileDir);

            // Splits the wordBank at each semi-colon.
            String[] words = wordBank.Split(';');

            // If the user answer is the same as the word read into the file.
            if (userAnswer == words[count])
            {
                // Returned value is true.
                return true;
            }
            else
            {
                // Returned value is false.
                return false;
            }
        }

    }
}
