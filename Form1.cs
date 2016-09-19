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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void submitName_Click(object sender, EventArgs e)
        {
            // If text box is empty display error to user. 
            if (String.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                // Shows message box to user. 
                MessageBox.Show("Please enter a Name");

                // WB Testing
                Console.WriteLine("Start Button Press");
                Console.WriteLine("Name not entered, error message displayed.");
            }
            else
            {
                // Creates new player object.
                player player = new player();
                // Runs setName method.
                player.setName();

                Form2 f2 = new Form2();
                // Hides the current form.
                this.Hide();
                // Shows form 2.
                f2.Show();

                // WB Testing
                Console.WriteLine("Start Button Press");
                Console.WriteLine("Name entered, form2 displayed.");
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            // Exits the application if the quit button is pressed.
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exits the application if the form is closed using any other method.
            Application.Exit();
        }
    }
}
