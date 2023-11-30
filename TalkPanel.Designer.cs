namespace InlämningTreÄventyret
{
    partial class TalkPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalkPanel));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            endButton = new Button();
            playAgainButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(634, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(407, 176);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(227, 223);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Linen;
            label1.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 140);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(269, 26);
            label1.TabIndex = 2;
            label1.Text = "The Dragon was actually nice.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 163);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(264, 26);
            label2.TabIndex = 3;
            label2.Text = "It was all a misunderstanding";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Linen;
            label3.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 187);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(208, 26);
            label3.TabIndex = 4;
            label3.Text = "The Princess is now safe";
            // 
            // endButton
            // 
            endButton.BackColor = Color.Linen;
            endButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            endButton.Location = new Point(30, 325);
            endButton.Margin = new Padding(2, 2, 2, 2);
            endButton.Name = "endButton";
            endButton.Size = new Size(78, 20);
            endButton.TabIndex = 5;
            endButton.Text = "End";
            endButton.UseVisualStyleBackColor = false;
            endButton.Click += endButton_Click;
            // 
            // playAgainButton
            // 
            playAgainButton.BackColor = Color.Linen;
            playAgainButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            playAgainButton.Location = new Point(517, 325);
            playAgainButton.Margin = new Padding(2, 2, 2, 2);
            playAgainButton.Name = "playAgainButton";
            playAgainButton.Size = new Size(89, 20);
            playAgainButton.TabIndex = 6;
            playAgainButton.Text = "Play Again";
            playAgainButton.UseVisualStyleBackColor = false;
            playAgainButton.Click += playAgainButton_Click;
            // 
            // TalkPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(playAgainButton);
            Controls.Add(endButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "TalkPanel";
            Size = new Size(634, 400);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button endButton;
        private Button playAgainButton;
    }
}
