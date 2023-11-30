namespace InlämningTreÄventyret
{
    partial class FightPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightPanel));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            EndButton2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(906, 666);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSlateGray;
            label1.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(347, 243);
            label1.Name = "label1";
            label1.Size = new Size(304, 39);
            label1.TabIndex = 1;
            label1.Text = "You defeted the Dragon!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSlateGray;
            label2.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(371, 282);
            label2.Name = "label2";
            label2.Size = new Size(253, 39);
            label2.TabIndex = 2;
            label2.Text = "The Princess is safe!";
            // 
            // EndButton2
            // 
            EndButton2.BackColor = Color.LightSteelBlue;
            EndButton2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EndButton2.Location = new Point(40, 590);
            EndButton2.Name = "EndButton2";
            EndButton2.Size = new Size(112, 34);
            EndButton2.TabIndex = 3;
            EndButton2.Text = "End";
            EndButton2.UseVisualStyleBackColor = false;
            EndButton2.Click += EndButton2_Click;
            // 
            // FightPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EndButton2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FightPanel";
            Size = new Size(906, 666);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button EndButton2;
    }
}
