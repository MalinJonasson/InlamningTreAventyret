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
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(884, 610);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // StablesLable
            // 
            StablesLable.AutoSize = true;
            StablesLable.BackColor = Color.Beige;
            StablesLable.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StablesLable.Location = new Point(79, 188);
            StablesLable.Name = "StablesLable";
            StablesLable.Size = new Size(174, 29);
            StablesLable.TabIndex = 1;
            StablesLable.Text = "Collect items at the";
            // 
            // ForgeLable
            // 
            ForgeLable.AutoSize = true;
            ForgeLable.BackColor = Color.Beige;
            ForgeLable.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForgeLable.Location = new Point(79, 257);
            ForgeLable.Name = "ForgeLable";
            ForgeLable.Size = new Size(174, 29);
            ForgeLable.TabIndex = 2;
            ForgeLable.Text = "Collect items at the";
            // 
            // GuardHouseLable
            // 
            GuardHouseLable.AutoSize = true;
            GuardHouseLable.BackColor = Color.Beige;
            GuardHouseLable.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GuardHouseLable.Location = new Point(79, 327);
            GuardHouseLable.Name = "GuardHouseLable";
            GuardHouseLable.Size = new Size(174, 29);
            GuardHouseLable.TabIndex = 3;
            GuardHouseLable.Text = "Collect items at the";
            // 
            // CollectItemsStableButton
            // 
            CollectItemsStableButton.BackColor = Color.Ivory;
            CollectItemsStableButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CollectItemsStableButton.Location = new Point(274, 183);
            CollectItemsStableButton.Name = "CollectItemsStableButton";
            CollectItemsStableButton.Size = new Size(126, 33);
            CollectItemsStableButton.TabIndex = 5;
            CollectItemsStableButton.Text = "Stables";
            CollectItemsStableButton.UseVisualStyleBackColor = false;
            CollectItemsStableButton.Click += CollectItemsStableButton_Click;
            // 
            // CollectItemsForgeButton
            // 
            CollectItemsForgeButton.BackColor = Color.Ivory;
            CollectItemsForgeButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CollectItemsForgeButton.Location = new Point(274, 252);
            CollectItemsForgeButton.Name = "CollectItemsForgeButton";
            CollectItemsForgeButton.Size = new Size(126, 33);
            CollectItemsForgeButton.TabIndex = 6;
            CollectItemsForgeButton.Text = "Forge";
            CollectItemsForgeButton.UseVisualStyleBackColor = false;
            CollectItemsForgeButton.Click += CollectItemsForgeButton_Click;
            // 
            // CollectItemsFoodCellerButton
            // 
            CollectItemsFoodCellerButton.BackColor = Color.Ivory;
            CollectItemsFoodCellerButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CollectItemsFoodCellerButton.Location = new Point(274, 322);
            CollectItemsFoodCellerButton.Name = "CollectItemsFoodCellerButton";
            CollectItemsFoodCellerButton.Size = new Size(126, 33);
            CollectItemsFoodCellerButton.TabIndex = 7;
            CollectItemsFoodCellerButton.Text = "Food Celler";
            CollectItemsFoodCellerButton.UseVisualStyleBackColor = false;
            CollectItemsFoodCellerButton.Click += CollectItemsFoodCellerButton_Click;
            // 
            // GoToDragonButton
            // 
            GoToDragonButton.BackColor = Color.Ivory;
            GoToDragonButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GoToDragonButton.Location = new Point(706, 517);
            GoToDragonButton.Name = "GoToDragonButton";
            GoToDragonButton.Size = new Size(126, 33);
            GoToDragonButton.TabIndex = 9;
            GoToDragonButton.Text = "Dragon";
            GoToDragonButton.UseVisualStyleBackColor = false;
            GoToDragonButton.Click += GoToDragonButton_Click;
            // 
            // goBackButton2
            // 
            goBackButton2.BackColor = Color.Ivory;
            goBackButton2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            goBackButton2.Location = new Point(189, 517);
            goBackButton2.Name = "goBackButton2";
            goBackButton2.Size = new Size(111, 33);
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
            label1.Location = new Point(261, 18);
            label1.Name = "label1";
            label1.Size = new Size(391, 36);
            label1.TabIndex = 11;
            label1.Text = "Collect items and go to the Dragon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Ivory;
            label2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(534, 112);
            label2.Name = "label2";
            label2.Size = new Size(217, 29);
            label2.TabIndex = 13;
            label2.Text = "List of all collected items";
            // 
            // PlayersNameLable
            // 
            PlayersNameLable.AutoSize = true;
            PlayersNameLable.BackColor = Color.Ivory;
            PlayersNameLable.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PlayersNameLable.Location = new Point(54, 72);
            PlayersNameLable.Name = "PlayersNameLable";
            PlayersNameLable.Size = new Size(128, 29);
            PlayersNameLable.TabIndex = 6;
            PlayersNameLable.Text = "Players name";
            // 
            // stablePanel1
            // 
            stablePanel1.Location = new Point(-10, -40);
            stablePanel1.Margin = new Padding(1, 2, 1, 2);
            stablePanel1.Name = "stablePanel1";
            stablePanel1.Size = new Size(906, 658);
            stablePanel1.TabIndex = 14;
            stablePanel1.Visible = false;
            // 
            // forgePanel1
            // 
            forgePanel1.Location = new Point(-10, -40);
            forgePanel1.Margin = new Padding(1, 2, 1, 2);
            forgePanel1.Name = "forgePanel1";
            forgePanel1.Size = new Size(906, 658);
            forgePanel1.TabIndex = 15;
            forgePanel1.Visible = false;
            // 
            // foodCellerPanel1
            // 
            foodCellerPanel1.Location = new Point(-10, -40);
            foodCellerPanel1.Margin = new Padding(1, 2, 1, 2);
            foodCellerPanel1.Name = "foodCellerPanel1";
            foodCellerPanel1.Size = new Size(906, 658);
            foodCellerPanel1.TabIndex = 16;
            foodCellerPanel1.Visible = false;
            // 
            // removeCollectedItemButton
            // 
            removeCollectedItemButton.BackColor = Color.Ivory;
            removeCollectedItemButton.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            removeCollectedItemButton.Location = new Point(550, 361);
            removeCollectedItemButton.Name = "removeCollectedItemButton";
            removeCollectedItemButton.Size = new Size(180, 33);
            removeCollectedItemButton.TabIndex = 17;
            removeCollectedItemButton.Text = "Put Items Back";
            removeCollectedItemButton.UseVisualStyleBackColor = false;
            removeCollectedItemButton.Click += removeCollectedItemButton_Click;
            // 
            // listBoxOfCollectedItems
            // 
            listBoxOfCollectedItems.BackColor = Color.Ivory;
            listBoxOfCollectedItems.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxOfCollectedItems.FormattingEnabled = true;
            listBoxOfCollectedItems.ItemHeight = 29;
            listBoxOfCollectedItems.Location = new Point(550, 177);
            listBoxOfCollectedItems.Name = "listBoxOfCollectedItems";
            listBoxOfCollectedItems.Size = new Size(180, 178);
            listBoxOfCollectedItems.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 610);
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