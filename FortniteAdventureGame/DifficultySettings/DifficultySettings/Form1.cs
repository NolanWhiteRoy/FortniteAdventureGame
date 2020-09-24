using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings
{
    public partial class Form1 : Form
    {
        string heroName;
        string difficultySetting;
        public Form1()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            difficultySetting = "easy";
            easyButton.BackColor = Color.Green;
            mediumButton.BackColor = Color.White;
            hardButton.BackColor = Color.White;

        }



        private void beginButton_Click(object sender, EventArgs e)
        {

            heroName = textBox.Text;

            beginButton.BackColor = Color.Blue;
 
            informationLabel.Visible = true;

            informationLabel.Text = "Hello " + heroName + Environment.NewLine + "You have picked the " + 
                difficultySetting + " level.";
            
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            difficultySetting = "medium";
            easyButton.BackColor = Color.White;
            mediumButton.BackColor = Color.Orange;
            hardButton.BackColor = Color.White;
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            difficultySetting = "hard";
            easyButton.BackColor = Color.White;
            mediumButton.BackColor = Color.White;
            hardButton.BackColor = Color.Red;
        }
    }
}
