namespace InlämningTreÄventyret
{
    public partial class Form3 : Form
    {
        public Form2 Form2;
        public TalkPanel TalkPanel;
        public Form3()
        {
            InitializeComponent();
            talkPanel1.SetForm3(this);
        }
        private void FightButton_Click(object sender, EventArgs e)
        {
            talkPanel1.Visible = false;
            int numOfAllCollectedItems = Form2.listBoxOfCollectedItems.Items.Count;

            if (numOfAllCollectedItems >= 3)
            {
                fightPanel1.Visible = true;
            }
            else
            {
                MessageBox.Show("You lost");
                Application.Exit();
            }
        }
        private void TalkButton_Click(object sender, EventArgs e)
        {
            fightPanel1.Visible = false;
            talkPanel1.Visible = true;
        }
        private void GoBackButton2_Click(object sender, EventArgs e)
        {
            Form2.Show();
            Hide();
        }

    }
}
