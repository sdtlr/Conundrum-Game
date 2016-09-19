using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConundrumGame
{
    class player
    {
        public String setName()
        {
            // Creates a new object for the textbox in form 1, allows the data to be read from this class.
            TextBox t = Application.OpenForms["Form1"].Controls["nameTextBox"] as TextBox;
            // Sets currentName as the input text in form 1.
            String currentName = t.Text;

            // Method returns the value stored in currentName.
            return currentName;
            
        }
    }
}
