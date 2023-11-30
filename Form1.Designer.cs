namespace InlämningTreÄventyret
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BackgroundPicture1 = new PictureBox();
            FirstMassege = new Label();
            label1 = new Label();
            StartGameButton = new Button();
            EndButton1 = new Button();
            PlayersNameTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)BackgroundPicture1).BeginInit();
            SuspendLayout();
            // 
            // BackgroundPicture1
            // 
            BackgroundPicture1.Dock = DockStyle.Fill;
            BackgroundPicture1.Image = (Image)resources.GetObject("BackgroundPicture1.Image");
            BackgroundPicture1.Location = new Point(0, 0);
            BackgroundPicture1.Name = "BackgroundPicture1";
            BackgroundPicture1.Size = new Size(884, 610);
            BackgroundPicture1.SizeMode = PictureBoxSizeMode.StretchImage;
            BackgroundPicture1.TabIndex = 0;
            BackgroundPicture1.TabStop = false;
            // 
            // FirstMassege
            // 
            FirstMassege.AutoSize = true;
            FirstMassege.BackColor = Color.Beige;
            FirstMassege.Font = new Font("Viner Hand ITC", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FirstMassege.Location = new Point(126, 53);
            FirstMassege.Name = "FirstMassege";
            FirstMassege.Size = new Size(648, 36);
            FirstMassege.TabIndex = 1;
            FirstMassege.Text = "The prinsess needs saving, she's been taken by the Dragon!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Viner Hand ITC", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(219, 100);
            label1.Name = "label1";
            label1.Size = new Size(501, 36);
            label1.TabIndex = 2;
            label1.Text = "You need to collect items in order to save her.";
            // 
            // StartGameButton
            // 
            StartGameButton.BackColor = Color.Ivory;
            StartGameButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StartGameButton.Location = new Point(672, 517);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(132, 34);
            StartGameButton.TabIndex = 3;
            StartGameButton.Text = "Start Game";
            StartGameButton.UseVisualStyleBackColor = false;
            StartGameButton.Click += StartGameButton_Click;
            // 
            // EndButton1
            // 
            EndButton1.BackColor = Color.Ivory;
            EndButton1.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EndButton1.Location = new Point(186, 517);
            EndButton1.Name = "EndButton1";
            EndButton1.Size = new Size(112, 34);
            EndButton1.TabIndex = 4;
            EndButton1.Text = "End";
            EndButton1.UseVisualStyleBackColor = false;
            EndButton1.Click += EndButton1_Click;
            // 
            // PlayersNameTextBox
            // 
            PlayersNameTextBox.BackColor = Color.Ivory;
            PlayersNameTextBox.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PlayersNameTextBox.Location = new Point(346, 249);
            PlayersNameTextBox.Name = "PlayersNameTextBox";
            PlayersNameTextBox.PlaceholderText = "Enter name";
            PlayersNameTextBox.Size = new Size(218, 37);
            PlayersNameTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 610);
            Controls.Add(PlayersNameTextBox);
            Controls.Add(label1);
            Controls.Add(EndButton1);
            Controls.Add(StartGameButton);
            Controls.Add(FirstMassege);
            Controls.Add(BackgroundPicture1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)BackgroundPicture1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BackgroundPicture1;
        private Label FirstMassege;
        private Label label1;
        private Button StartGameButton;
        private Button EndButton1;
        private TextBox PlayersNameTextBox;
    }
}