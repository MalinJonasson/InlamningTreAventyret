namespace InlämningTreÄventyret
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            StablesLable = new Label();
            ForgeLable = new Label();
            GuardHouseLable = new Label();
            CollectItemsStableButton = new Button();
            CollectItemsForgeButton = new Button();
            CollectItemsFoodCellerButton = new Button();
            GoToDragonButton = new Button();
            goBackButton2 = new Button();
            label1 = new Label();
            label2 = new Label();
            PlayersNameLable = new Label();
            stablePanel1 = new StablePanel();
            forgePanel1 = new ForgePanel();
            foodCellerPanel1 = new FoodCellerPanel();
            removeCollectedItemButton = new Button();
            listBoxOfCollectedItems = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(619, 366);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // StablesLable
            // 
            StablesLable.AutoSize = true;
            StablesLable.BackColor = Color.Beige;
            StablesLable.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StablesLable.Location = new Point(55, 113);
            StablesLable.Margin = new Padding(2, 0, 2, 0);
            StablesLable.Name = "StablesLable";
            StablesLable.Size = new Size(116, 19);
            StablesLable.TabIndex = 1;
            StablesLable.Text = "Collect items at the";
            // 
            // ForgeLable
            // 
            ForgeLable.AutoSize = true;
            ForgeLable.BackColor = Color.Beige;
            ForgeLable.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForgeLable.Location = new Point(55, 154);
            ForgeLable.Margin = new Padding(2, 0, 2, 0);
            ForgeLable.Name = "ForgeLable";
            ForgeLable.Size = new Size(116, 19);
            ForgeLable.TabIndex = 2;
            ForgeLable.Text = "Collect items at the";
            // 
            // GuardHouseLable
            // 
            GuardHouseLable.AutoSize = true;
            GuardHouseLable.BackColor = Color.Beige;
            GuardHouseLable.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GuardHouseLable.Location = new Point(55, 196);
            GuardHouseLable.Margin = new Padding(2, 0, 2, 0);
            GuardHouseLable.Name = "GuardHouseLable";
            GuardHouseLable.Size = new Size(116, 19);
            GuardHouseLable.TabIndex = 3;
            GuardHouseLable.Text = "Collect items at the";
            // 
            // CollectItemsStableButton
            // 
            CollectItemsStableButton.BackColor = Color.Ivory;
            CollectItemsStableButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CollectItemsStableButton.Location = new Point(192, 110);
            CollectItemsStableButton.Margin = new Padding(2);
            CollectItemsStableButton.Name = "CollectItemsStableButton";
            CollectItemsStableButton.Size = new Size(88, 20);
            CollectItemsStableButton.TabIndex = 5;
            CollectItemsStableButton.Text = "Stables";
            CollectItemsStableButton.UseVisualStyleBackColor = false;
            CollectItemsStableButton.Click += CollectItemsStableButton_Click;
            // 
            // CollectItemsForgeButton
            // 
            CollectItemsForgeButton.BackColor = Color.Ivory;
            CollectItemsForgeButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CollectItemsForgeButton.Location = new Point(192, 151);
            CollectItemsForgeButton.Margin = new Padding(2);
            CollectItemsForgeButton.Name = "CollectItemsForgeButton";
            CollectItemsForgeButton.Size = new Size(88, 20);
            CollectItemsForgeButton.TabIndex = 6;
            CollectItemsForgeButton.Text = "Forge";
            CollectItemsForgeButton.UseVisualStyleBackColor = false;
            CollectItemsForgeButton.Click += CollectItemsForgeButton_Click;
            // 
            // CollectItemsFoodCellerButton
            // 
            CollectItemsFoodCellerButton.BackColor = Color.Ivory;
            CollectItemsFoodCellerButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CollectItemsFoodCellerButton.Location = new Point(192, 193);
            CollectItemsFoodCellerButton.Margin = new Padding(2);
            CollectItemsFoodCellerButton.Name = "CollectItemsFoodCellerButton";
            CollectItemsFoodCellerButton.Size = new Size(88, 20);
            CollectItemsFoodCellerButton.TabIndex = 7;
            CollectItemsFoodCellerButton.Text = "Food Celler";
            CollectItemsFoodCellerButton.UseVisualStyleBackColor = false;
            CollectItemsFoodCellerButton.Click += CollectItemsFoodCellerButton_Click;
            // 
            // GoToDragonButton
            // 
            GoToDragonButton.BackColor = Color.Ivory;
            GoToDragonButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GoToDragonButton.Location = new Point(494, 310);
            GoToDragonButton.Margin = new Padding(2);
            GoToDragonButton.Name = "GoToDragonButton";
            GoToDragonButton.Size = new Size(88, 20);
            GoToDragonButton.TabIndex = 9;
            GoToDragonButton.Text = "Dragon";
            GoToDragonButton.UseVisualStyleBackColor = false;
            GoToDragonButton.Click += GoToDragonButton_Click;
            // 
            // goBackButton2
            // 
            goBackButton2.BackColor = Color.Ivory;
            goBackButton2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            goBackButton2.Location = new Point(132, 310);
            goBackButton2.Margin = new Padding(2);
            goBackButton2.Name = "goBackButton2";
            goBackButton2.Size = new Size(78, 20);
            goBackButton2.TabIndex = 10;
            goBackButton2.Text = "Go back";
            goBackButton2.UseVisualStyleBackColor = false;
            goBackButton2.Click += goBackButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Viner Hand ITC", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(183, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(273, 24);
            label1.TabIndex = 11;
            label1.Text = "Collect items and go to the Dragon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Ivory;
            label2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(374, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 19);
            label2.TabIndex = 13;
            label2.Text = "List of all collected items";
            // 
            // PlayersNameLable
            // 
            PlayersNameLable.AutoSize = true;
            PlayersNameLable.BackColor = Color.Ivory;
            PlayersNameLable.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PlayersNameLable.Location = new Point(38, 43);
            PlayersNameLable.Margin = new Padding(2, 0, 2, 0);
            PlayersNameLable.Name = "PlayersNameLable";
            PlayersNameLable.Size = new Size(87, 19);
            PlayersNameLable.TabIndex = 6;
            PlayersNameLable.Text = "Players name";
            // 
            // stablePanel1
            // 
            stablePanel1.Location = new Point(-7, -27);
            stablePanel1.Margin = new Padding(1);
            stablePanel1.Name = "stablePanel1";
            stablePanel1.Size = new Size(634, 398);
            stablePanel1.TabIndex = 14;
            stablePanel1.Visible = false;
            // 
            // forgePanel1
            // 
            forgePanel1.Location = new Point(-7, -27);
            forgePanel1.Margin = new Padding(1);
            forgePanel1.Name = "forgePanel1";
            forgePanel1.Size = new Size(634, 398);
            forgePanel1.TabIndex = 15;
            forgePanel1.Visible = false;
            // 
            // foodCellerPanel1
            // 
            foodCellerPanel1.Location = new Point(-7, -27);
            foodCellerPanel1.Margin = new Padding(1);
            foodCellerPanel1.Name = "foodCellerPanel1";
            foodCellerPanel1.Size = new Size(634, 398);
            foodCellerPanel1.TabIndex = 16;
            foodCellerPanel1.Visible = false;
            // 
            // removeCollectedItemButton
            // 
            removeCollectedItemButton.BackColor = Color.Ivory;
            removeCollectedItemButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            removeCollectedItemButton.Location = new Point(417, 217);
            removeCollectedItemButton.Margin = new Padding(2);
            removeCollectedItemButton.Name = "removeCollectedItemButton";
            removeCollectedItemButton.Size = new Size(63, 20);
            removeCollectedItemButton.TabIndex = 17;
            removeCollectedItemButton.Text = "Remove";
            removeCollectedItemButton.UseVisualStyleBackColor = false;
            removeCollectedItemButton.Click += removeCollectedItemButton_Click;
            // 
            // listBoxOfCollectedItems
            // 
            listBoxOfCollectedItems.BackColor = Color.Ivory;
            listBoxOfCollectedItems.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxOfCollectedItems.FormattingEnabled = true;
            listBoxOfCollectedItems.ItemHeight = 19;
            listBoxOfCollectedItems.Location = new Point(385, 106);
            listBoxOfCollectedItems.Margin = new Padding(2);
            listBoxOfCollectedItems.Name = "listBoxOfCollectedItems";
            listBoxOfCollectedItems.Size = new Size(127, 99);
            listBoxOfCollectedItems.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 366);
            Controls.Add(stablePanel1);
            Controls.Add(forgePanel1);
            Controls.Add(foodCellerPanel1);
            Controls.Add(listBoxOfCollectedItems);
            Controls.Add(removeCollectedItemButton);
            Controls.Add(PlayersNameLable);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(goBackButton2);
            Controls.Add(GoToDragonButton);
            Controls.Add(CollectItemsFoodCellerButton);
            Controls.Add(CollectItemsForgeButton);
            Controls.Add(CollectItemsStableButton);
            Controls.Add(GuardHouseLable);
            Controls.Add(ForgeLable);
            Controls.Add(StablesLable);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label StablesLable;
        private Label ForgeLable;
        private Label GuardHouseLable;
        private Button CollectItemsStableButton;
        private Button CollectItemsForgeButton;
        private Button CollectItemsFoodCellerButton;
        private Button GoToDragonButton;
        private Button removeForgeItemsButton;
        private Label label1;
        private Label label2;
        private Label PlayersNameLable;
        private StablePanel stablePanel1;
        private ForgePanel forgePanel1;
        private FoodCellerPanel foodCellerPanel1;
        private Button goBackButton2;
        public ListBox listBoxOfStabletems;
        private Button removeCollectedItemButton;
        private ListBox listBoxOfForgeItems;
        private ListBox listBoxOfFoodCellerItems;
        private Button removeFoodCellerItemsButton;
        public ListBox listBoxOfCollectedItems;
    }
}