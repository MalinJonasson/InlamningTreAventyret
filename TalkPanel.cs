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
            Application.Exit();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {  //Bugg form3 ligger kvar.
            Form3.Close();
            Form1 = new Form1();
            Form1.Show();
        }
    }
}
