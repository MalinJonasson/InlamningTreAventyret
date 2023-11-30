using Newtonsoft.Json;

namespace InlämningTreÄventyret
{
    public partial class Form2 : Form
    {
        public Form1 Form1;
        public Form3 Form3;
        public StablePanel StablePanel1;
        public ForgePanel ForgePanel1;
        public FoodCellerPanel FoodCellerPanel1;
        public List<Item> BackpackItems = new List<Item>();

        public Form2()
        {
            InitializeComponent();
            stablePanel1.SetForm2(this);
            forgePanel1.SetForm2(this);
            foodCellerPanel1.SetForm2(this);
            new FileInfo(path);
            LoadAll();
        }
        public void SendString(string message)
        {
            PlayersNameLable.Text = message + " is playing.";
        }
        public void SetStablePanel(StablePanel stablePanel)
        {
            StablePanel1 = stablePanel;
        }
        public void SetForgePanel(ForgePanel forgePanel)
        {
            ForgePanel1 = forgePanel;
        }
        public void SetFoodCellerPanel(FoodCellerPanel foodCellerPanel)
        {
            FoodCellerPanel1 = foodCellerPanel;
        }

        string path = "collecteditemslist.json";
        
        public void AddItemToCollectedListBox(string itemName)
        {
            listBoxOfCollectedItems.Items.Add(itemName);
            SaveItems();
        }
        private void CollectItemsStableButton_Click(object sender, EventArgs e)
        {
            stablePanel1.Visible = true;
        }

        private void CollectItemsForgeButton_Click(object sender, EventArgs e)
        {
            forgePanel1.Visible = true;
        }

        private void CollectItemsFoodCellerButton_Click(object sender, EventArgs e)
        {
            foodCellerPanel1.Visible = true;
        }
        private void GoToDragonButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 form3 = new Form3();
            form3.Form2 = this;
            form3.Show();
        }
        private void goBackButton2_Click(object sender, EventArgs e)
        {
            Form1.Show();
            Hide();
        }
        private void LoadAll()
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string json = sr.ReadToEnd();
                    List<Item> loadedItems = JsonConvert.DeserializeObject<List<Item>>(json);

                    if (loadedItems != null)
                    {
                        foreach (Item item in loadedItems)
                        {
                            listBoxOfCollectedItems.Items.Add(item.Name);
                            BackpackItems.Add(item);
                        }
                    }
                }
            }
        }
        private void SaveItems()
        {
            string json = JsonConvert.SerializeObject(BackpackItems);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(json);
            }
        }
        private void FindPanel()
        {
            string selectedItemName = listBoxOfCollectedItems.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedItemName))
            {
                Item selectedItemObject = BackpackItems.FirstOrDefault(x => x.Name == selectedItemName);

                if (selectedItemObject != null)
                {
                    listBoxOfCollectedItems.Items.Remove(selectedItemName);
                    switch (selectedItemObject.Category)
                    {
                        case "Stable":
                            StablePanel1.Form2 = this;
                            StablePanel1.AddBackToPanel(selectedItemObject);
                            break;

                        case "Forge":
                            ForgePanel1.Form2 = this;
                            ForgePanel1.AddBackToPanel(selectedItemObject);
                            break;

                        case "FoodCeller":
                            FoodCellerPanel1.Form2 = this;
                            FoodCellerPanel1.AddBackToPanel(selectedItemObject);
                            break;

                        default:
                            MessageBox.Show("Invalid category");
                            break;
                    }

                    BackpackItems.Remove(selectedItemObject);
                    SaveItems();
                }
                else
                {
                    MessageBox.Show($"Item not found. BackpackItems: {string.Join(", ", BackpackItems.Select(item => item.Name))}");
                }
            }
            else
            {
                MessageBox.Show("You have to choose something to remove");
            }
        }

        private void removeCollectedItemButton_Click(object sender, EventArgs e)
        {
            FindPanel();
            SaveItems();
        }
    }
}
