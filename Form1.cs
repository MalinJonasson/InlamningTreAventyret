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
            Application.Exit();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            Hide();
            bool click = true;
            if (click)
            {
                form2 = new Form2();
                form2.Form1 = this;
                form2.Show();
            }
            form2.SendString(PlayersNameTextBox.Text);
        }
    }
}