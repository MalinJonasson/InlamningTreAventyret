namespace InlämningTreÄventyret
{
    partial class StablePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StablePanel));
            pictureBox1 = new PictureBox();
            stableItemsListBox = new ListBox();
            label1 = new Label();
            addItemStableTextBox = new TextBox();
            addStableItemButton = new Button();
            label2 = new Label();
            goBackStableButton = new Button();
            removeStableItemButton = new Button();
            addToBackpackButton = new Button();
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
            // stableItemsListBox
            // 
            stableItemsListBox.BackColor = Color.Tan;
            stableItemsListBox.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            stableItemsListBox.FormattingEnabled = true;
            stableItemsListBox.ItemHeight = 29;
            stableItemsListBox.Location = new Point(655, 213);
            stableItemsListBox.Name = "stableItemsListBox";
            stableItemsListBox.Size = new Size(171, 207);
            stableItemsListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tan;
            label1.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(623, 153);
            label1.Name = "label1";
            label1.Size = new Size(228, 29);
            label1.TabIndex = 2;
            label1.Text = "List of items to choose from";
            // 
            // addItemStableTextBox
            // 
            addItemStableTextBox.BackColor = Color.Tan;
            addItemStableTextBox.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addItemStableTextBox.Location = new Point(384, 227);
            addItemStableTextBox.Name = "addItemStableTextBox";
            addItemStableTextBox.Size = new Size(150, 37);
            addItemStableTextBox.TabIndex = 3;
            // 
            // addStableItemButton
            // 
            addStableItemButton.BackColor = Color.Tan;
            addStableItemButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addStableItemButton.Location = new Point(402, 302);
            addStableItemButton.Name = "addStableItemButton";
            addStableItemButton.Size = new Size(112, 34);
            addStableItemButton.TabIndex = 4;
            addStableItemButton.Text = "Add Item";
            addStableItemButton.UseVisualStyleBackColor = false;
            addStableItemButton.Click += addStableItemButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Tan;
            label2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(277, 60);
            label2.Name = "label2";
            label2.Size = new Size(358, 29);
            label2.TabIndex = 5;
            label2.Text = "Pick an item and then click add to collect";
            // 
            // goBackStableButton
            // 
            goBackStableButton.BackColor = Color.Tan;
            goBackStableButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            goBackStableButton.Location = new Point(46, 592);
            goBackStableButton.Name = "goBackStableButton";
            goBackStableButton.Size = new Size(112, 34);
            goBackStableButton.TabIndex = 6;
            goBackStableButton.Text = "Go back";
            goBackStableButton.UseVisualStyleBackColor = false;
            goBackStableButton.Click += goBackStableButton_Click;
            // 
            // removeStableItemButton
            // 
            removeStableItemButton.BackColor = Color.Tan;
            removeStableItemButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            removeStableItemButton.Location = new Point(402, 375);
            removeStableItemButton.Name = "removeStableItemButton";
            removeStableItemButton.Size = new Size(112, 34);
            removeStableItemButton.TabIndex = 7;
            removeStableItemButton.Text = "Remove Item";
            removeStableItemButton.UseVisualStyleBackColor = false;
            removeStableItemButton.Click += removeStableItemButton_Click;
            // 
            // addToBackpackButton
            // 
            addToBackpackButton.BackColor = Color.Tan;
            addToBackpackButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addToBackpackButton.Location = new Point(655, 444);
            addToBackpackButton.Name = "addToBackpackButton";
            addToBackpackButton.Size = new Size(171, 34);
            addToBackpackButton.TabIndex = 8;
            addToBackpackButton.Text = "Add To Backpack";
            addToBackpackButton.UseVisualStyleBackColor = false;
            addToBackpackButton.Click += addToBackpackButton_Click;
            // 
            // StablePanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addToBackpackButton);
            Controls.Add(removeStableItemButton);
            Controls.Add(goBackStableButton);
            Controls.Add(label2);
            Controls.Add(addStableItemButton);
            Controls.Add(addItemStableTextBox);
            Controls.Add(label1);
            Controls.Add(stableItemsListBox);
            Controls.Add(pictureBox1);
            Name = "StablePanel";
            Size = new Size(906, 666);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox stableItemsListBox;
        private Label label1;
        private TextBox addItemStableTextBox;
        private Button addStableItemButton;
        private Label label2;
        private Button goBackStableButton;
        private Button removeStableItemButton;
        private Button addToBackpackButton;
    }
}
