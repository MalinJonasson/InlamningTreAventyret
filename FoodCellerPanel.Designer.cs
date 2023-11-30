namespace InlämningTreÄventyret
{
    partial class FoodCellerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodCellerPanel));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            foodCellerItemsListBox = new ListBox();
            addItemFoodCellerButton = new Button();
            goBackFoodCellerButton = new Button();
            ItemFoodCellerTextBox = new TextBox();
            removeFoodCellerItemButten = new Button();
            addToBackPackFoodCButton = new Button();
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
            label1.BackColor = Color.DarkOliveGreen;
            label1.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(324, 64);
            label1.Name = "label1";
            label1.Size = new Size(315, 29);
            label1.TabIndex = 1;
            label1.Text = "Pick an item and click add to collect";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkOliveGreen;
            label2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(634, 174);
            label2.Name = "label2";
            label2.Size = new Size(228, 29);
            label2.TabIndex = 2;
            label2.Text = "List of items to choose from";
            // 
            // foodCellerItemsListBox
            // 
            foodCellerItemsListBox.BackColor = Color.DarkOliveGreen;
            foodCellerItemsListBox.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            foodCellerItemsListBox.FormattingEnabled = true;
            foodCellerItemsListBox.ItemHeight = 29;
            foodCellerItemsListBox.Location = new Point(665, 229);
            foodCellerItemsListBox.Name = "foodCellerItemsListBox";
            foodCellerItemsListBox.Size = new Size(169, 207);
            foodCellerItemsListBox.TabIndex = 3;
            // 
            // addItemFoodCellerButton
            // 
            addItemFoodCellerButton.BackColor = Color.DarkOliveGreen;
            addItemFoodCellerButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addItemFoodCellerButton.Location = new Point(409, 320);
            addItemFoodCellerButton.Name = "addItemFoodCellerButton";
            addItemFoodCellerButton.Size = new Size(132, 34);
            addItemFoodCellerButton.TabIndex = 4;
            addItemFoodCellerButton.Text = "Add Item";
            addItemFoodCellerButton.UseVisualStyleBackColor = false;
            addItemFoodCellerButton.Click += addItemFoodCellerButton_Click;
            // 
            // goBackFoodCellerButton
            // 
            goBackFoodCellerButton.BackColor = Color.DarkOliveGreen;
            goBackFoodCellerButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            goBackFoodCellerButton.Location = new Point(47, 579);
            goBackFoodCellerButton.Name = "goBackFoodCellerButton";
            goBackFoodCellerButton.Size = new Size(112, 34);
            goBackFoodCellerButton.TabIndex = 5;
            goBackFoodCellerButton.Text = "Go back";
            goBackFoodCellerButton.UseVisualStyleBackColor = false;
            goBackFoodCellerButton.Click += goBackFoodCellerButton_Click;
            // 
            // ItemFoodCellerTextBox
            // 
            ItemFoodCellerTextBox.BackColor = Color.DarkOliveGreen;
            ItemFoodCellerTextBox.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemFoodCellerTextBox.Location = new Point(409, 250);
            ItemFoodCellerTextBox.Name = "ItemFoodCellerTextBox";
            ItemFoodCellerTextBox.Size = new Size(132, 37);
            ItemFoodCellerTextBox.TabIndex = 6;
            // 
            // removeFoodCellerItemButten
            // 
            removeFoodCellerItemButten.BackColor = Color.DarkOliveGreen;
            removeFoodCellerItemButten.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            removeFoodCellerItemButten.Location = new Point(409, 388);
            removeFoodCellerItemButten.Name = "removeFoodCellerItemButten";
            removeFoodCellerItemButten.Size = new Size(132, 34);
            removeFoodCellerItemButten.TabIndex = 7;
            removeFoodCellerItemButten.Text = "Remove Item";
            removeFoodCellerItemButten.UseVisualStyleBackColor = false;
            removeFoodCellerItemButten.Click += removeFoodCellerItemButten_Click;
            // 
            // addToBackPackFoodCButton
            // 
            addToBackPackFoodCButton.BackColor = Color.DarkOliveGreen;
            addToBackPackFoodCButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addToBackPackFoodCButton.Location = new Point(665, 458);
            addToBackPackFoodCButton.Name = "addToBackPackFoodCButton";
            addToBackPackFoodCButton.Size = new Size(169, 34);
            addToBackPackFoodCButton.TabIndex = 8;
            addToBackPackFoodCButton.Text = "Add To Backpack";
            addToBackPackFoodCButton.UseVisualStyleBackColor = false;
            addToBackPackFoodCButton.Click += addToBackPackFoodCButton_Click;
            // 
            // FoodCellerPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addToBackPackFoodCButton);
            Controls.Add(removeFoodCellerItemButten);
            Controls.Add(ItemFoodCellerTextBox);
            Controls.Add(goBackFoodCellerButton);
            Controls.Add(addItemFoodCellerButton);
            Controls.Add(foodCellerItemsListBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FoodCellerPanel";
            Size = new Size(906, 666);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ListBox foodCellerItemsListBox;
        private Button addItemFoodCellerButton;
        private Button goBackFoodCellerButton;
        private TextBox ItemFoodCellerTextBox;
        private Button removeFoodCellerItemButten;
        private Button addToBackPackFoodCButton;
    }
}
