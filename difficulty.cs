using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConundrumGame
{
    class difficulty
    {
        public String setEasyDiff_words()
        {
            // Sets the file directory of the easy words text document.
            String fileDir = Application.StartupPath + "/conundrum_easy_words.txt";

            // Method retuns the file directory.
            return fileDir;
        }

        public String setEasyDiff_jumbled()
        {
            // Sets the file directory of the medium words text document.
            String fileDir = Application.StartupPath + "/conundrum_easy_jumbled.txt";

            // Method retuns the file directory.
            return fileDir;
        }

        public String setMedDiff_words()
        {
            // Sets the file directory of the hard words text document.
            String fileDir = Application.StartupPath + "/conundrum_med_words.txt";

            // Method retuns the file directory.
            return fileDir;
        }

        public String setMedDiff_jumbled()
        {
            // Sets the file directory of the easy jumbled text document.
            String fileDir = Application.StartupPath + "/conundrum_med_jumbled.txt";

            // Method retuns the file directory.
            return fileDir;
        }
        public String setHardDiff_words()
        {
            // Sets the file directory of the medium jumbled text document.
            String fileDir = Application.StartupPath + "/conundrum_hard_words.txt";

            // Method retuns the file directory.
            return fileDir;
        }

        public String setHardDiff_jumbled()
        {
            // Sets the file directory of the hard jumbled text document.
            String fileDir = Application.StartupPath + "/conundrum_hard_jumbled.txt";

            // Method retuns the file directory.
            return fileDir;
        }
    }
}
