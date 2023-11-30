namespace InlämningTreÄventyret
{
    partial class ForgePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgePanel));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            addItemForgeTextBox = new TextBox();
            addForgeItemButton = new Button();
            forgeItemsListBox = new ListBox();
            goBackForgeButton = new Button();
            removeForgeItemButton = new Button();
            addToBackPackForgeButton = new Button();
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
            label1.BackColor = Color.Tan;
            label1.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(280, 58);
            label1.Name = "label1";
            label1.Size = new Size(358, 29);
            label1.TabIndex = 1;
            label1.Text = "Pick an item and then click add to collect";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Tan;
            label2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(596, 172);
            label2.Name = "label2";
            label2.Size = new Size(228, 29);
            label2.TabIndex = 2;
            label2.Text = "List of items to choose from";
            // 
            // addItemForgeTextBox
            // 
            addItemForgeTextBox.BackColor = Color.Tan;
            addItemForgeTextBox.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addItemForgeTextBox.Location = new Point(400, 244);
            addItemForgeTextBox.Name = "addItemForgeTextBox";
            addItemForgeTextBox.Size = new Size(131, 37);
            addItemForgeTextBox.TabIndex = 3;
            // 
            // addForgeItemButton
            // 
            addForgeItemButton.BackColor = Color.Tan;
            addForgeItemButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addForgeItemButton.Location = new Point(400, 316);
            addForgeItemButton.Name = "addForgeItemButton";
            addForgeItemButton.Size = new Size(131, 34);
            addForgeItemButton.TabIndex = 4;
            addForgeItemButton.Text = "Add Item";
            addForgeItemButton.UseVisualStyleBackColor = false;
            addForgeItemButton.Click += addForgeItemButton_Click;
            // 
            // forgeItemsListBox
            // 
            forgeItemsListBox.BackColor = Color.Tan;
            forgeItemsListBox.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            forgeItemsListBox.FormattingEnabled = true;
            forgeItemsListBox.ItemHeight = 29;
            forgeItemsListBox.Location = new Point(630, 225);
            forgeItemsListBox.Name = "forgeItemsListBox";
            forgeItemsListBox.Size = new Size(170, 207);
            forgeItemsListBox.TabIndex = 5;
            // 
            // goBackForgeButton
            // 
            goBackForgeButton.BackColor = Color.Tan;
            goBackForgeButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            goBackForgeButton.Location = new Point(60, 579);
            goBackForgeButton.Name = "goBackForgeButton";
            goBackForgeButton.Size = new Size(112, 34);
            goBackForgeButton.TabIndex = 6;
            goBackForgeButton.Text = "Go Back";
            goBackForgeButton.UseVisualStyleBackColor = false;
            goBackForgeButton.Click += goBackForgeButton_Click;
            // 
            // removeForgeItemButton
            // 
            removeForgeItemButton.BackColor = Color.Tan;
            removeForgeItemButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            removeForgeItemButton.Location = new Point(400, 387);
            removeForgeItemButton.Name = "removeForgeItemButton";
            removeForgeItemButton.Size = new Size(131, 34);
            removeForgeItemButton.TabIndex = 7;
            removeForgeItemButton.Text = "Remove Item";
            removeForgeItemButton.UseVisualStyleBackColor = false;
            removeForgeItemButton.Click += removeForgeItemButton_Click;
            // 
            // addToBackPackForgeButton
            // 
            addToBackPackForgeButton.BackColor = Color.Tan;
            addToBackPackForgeButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addToBackPackForgeButton.Location = new Point(630, 457);
            addToBackPackForgeButton.Name = "addToBackPackForgeButton";
            addToBackPackForgeButton.Size = new Size(170, 34);
            addToBackPackForgeButton.TabIndex = 8;
            addToBackPackForgeButton.Text = "Add To Backpack";
            addToBackPackForgeButton.UseVisualStyleBackColor = false;
            addToBackPackForgeButton.Click += addToBackPackForgeButton_Click;
            // 
            // ForgePanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addToBackPackForgeButton);
            Controls.Add(removeForgeItemButton);
            Controls.Add(goBackForgeButton);
            Controls.Add(forgeItemsListBox);
            Controls.Add(addForgeItemButton);
            Controls.Add(addItemForgeTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ForgePanel";
            Size = new Size(906, 666);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox addItemForgeTextBox;
        private Button addForgeItemButton;
        private ListBox forgeItemsListBox;
        private Button goBackForgeButton;
        private Button removeForgeItemButton;
        private Button addToBackPackForgeButton;
    }
}
