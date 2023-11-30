using Newtonsoft.Json;
using System.IO;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace InlämningTreÄventyret
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void EndButton1_Click(object sender, EventArgs e)
        {
           DialogResult endGame = MessageBox.Show("Are you sure you want to leave?" +
               " All your changes will be saved", "Exit", MessageBoxButtons.YesNo);
            if (endGame == DialogResult.No)
            {
                Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(PlayersNameTextBox.Text))
            { 
                Hide();
                form2 = new Form2();
                form2.Form1 = this;
                form2.Show();
                form2.SendString(PlayersNameTextBox.Text + " is playing");
            }
            else
            {
                MessageBox.Show("You have to enter a name");
            }
        }
    }
}