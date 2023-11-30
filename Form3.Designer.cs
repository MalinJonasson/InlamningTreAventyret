namespace InlämningTreÄventyret
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            FightButton = new Button();
            TalkButton = new Button();
            GoBackButton2 = new Button();
            label1 = new Label();
            label2 = new Label();
            fightPanel1 = new FightPanel();
            talkPanel1 = new TalkPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(884, 610);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FightButton
            // 
            FightButton.BackColor = Color.DarkSlateGray;
            FightButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FightButton.Location = new Point(138, 405);
            FightButton.Name = "FightButton";
            FightButton.Size = new Size(112, 34);
            FightButton.TabIndex = 1;
            FightButton.Text = "Fight";
            FightButton.UseVisualStyleBackColor = false;
            FightButton.Click += FightButton_Click;
            // 
            // TalkButton
            // 
            TalkButton.BackColor = Color.DarkSlateGray;
            TalkButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TalkButton.Location = new Point(625, 405);
            TalkButton.Name = "TalkButton";
            TalkButton.Size = new Size(112, 34);
            TalkButton.TabIndex = 2;
            TalkButton.Text = "Talk";
            TalkButton.UseVisualStyleBackColor = false;
            TalkButton.Click += TalkButton_Click;
            // 
            // GoBackButton2
            // 
            GoBackButton2.BackColor = Color.DarkSlateGray;
            GoBackButton2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GoBackButton2.Location = new Point(23, 552);
            GoBackButton2.Name = "GoBackButton2";
            GoBackButton2.Size = new Size(112, 34);
            GoBackButton2.TabIndex = 3;
            GoBackButton2.Text = "Go Back";
            GoBackButton2.UseVisualStyleBackColor = false;
            GoBackButton2.Click += GoBackButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Viner Hand ITC", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(364, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 36);
            label1.TabIndex = 4;
            label1.Text = "Save the Princess!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Viner Hand ITC", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(258, 56);
            label2.Name = "label2";
            label2.Size = new Size(426, 36);
            label2.TabIndex = 5;
            label2.Text = "You either fight or talk to the dragon";
            // 
            // fightPanel1
            // 
            fightPanel1.BackgroundImage = (Image)resources.GetObject("fightPanel1.BackgroundImage");
            fightPanel1.Location = new Point(-10, -46);
            fightPanel1.Name = "fightPanel1";
            fightPanel1.Size = new Size(906, 668);
            fightPanel1.TabIndex = 6;
            fightPanel1.Visible = false;
            // 
            // talkPanel1
            // 
            talkPanel1.Location = new Point(-10, -46);
            talkPanel1.Name = "talkPanel1";
            talkPanel1.Size = new Size(906, 668);
            talkPanel1.TabIndex = 7;
            talkPanel1.Visible = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 610);
            Controls.Add(talkPanel1);
            Controls.Add(fightPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GoBackButton2);
            Controls.Add(TalkButton);
            Controls.Add(FightButton);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button FightButton;
        private Button TalkButton;
        private Button GoBackButton2;
        private Label label1;
        private Label label2;
        private FightPanel fightPanel1;
        private TalkPanel talkPanel1;
    }
}