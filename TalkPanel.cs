namespace InlämningTreÄventyret
{
    public partial class TalkPanel : UserControl
    {
        Form1 Form1;
        Form3 Form3;
        public TalkPanel()
        {
            InitializeComponent();
        }
        public void SetForm3(Form3 form3)
        {
            Form3 = form3;
        }
        private void endButton_Click(object sender, EventArgs e)
        {
            DialogResult endGame = MessageBox.Show("Are you sure you want to leave?" +
               " All your changes won't be saved", "Exit", MessageBoxButtons.YesNo);
            if (endGame == DialogResult.No)
            {
                Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {  
            Form3.Close();
            Form1 = new Form1();
            Form1.Show();
        }
    }
}
