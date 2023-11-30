using Newtonsoft.Json;

namespace InlämningTreÄventyret
{
    public partial class ForgePanel : UserControl
    {
        public Form2 Form2;
        public List<Item> ForgeItems = new();

        public ForgePanel()
        {
            InitializeComponent();
            //Form2.SetForgePanel(this);

            FileInfo file = new FileInfo(path);
            if (!file.Exists)
            {
                ForgeItems.Add(new Item("Spear", "Forge"));
                ForgeItems.Add(new Item("Hammer","Forge"));
                ForgeItems.Add(new Item("Sledgehammer", "Forge"));

                foreach (Item item in ForgeItems)
                {
                    forgeItemsListBox.Items.Add(item.Name);
                }
            }
            else
            {
                LoadAll();
            }
            UpdateListBox();
        }

        string path = "forgepanellist.json";
        public void SetForm2(Form2 form2)
        {
            Form2 = form2;
        }

        private void goBackForgeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void addForgeItemButton_Click(object sender, EventArgs e)
        {
            string name = addItemForgeTextBox.Text;
            if (!string.IsNullOrEmpty(name))
            {
                Item item = new Item(name, "Forge");
                ForgeItems.Add(item);
                forgeItemsListBox.Items.Add(item.Name);
                addItemForgeTextBox.Clear();
            }
            else
            {
                MessageBox.Show("You have to write something");
            }
            SaveItems();
        }

        private void removeForgeItemButton_Click(object sender, EventArgs e)
        {
            FindItemToRemove();
            SaveItems();
        }
        private void UpdateListBox()
        {
            forgeItemsListBox.Items.Clear();

            foreach (Item item in ForgeItems)
            {
                forgeItemsListBox.Items.Add(item.Name);
            }
        }
        private void addToBackPackForgeButton_Click(object sender, EventArgs e)
        {
            string? name = forgeItemsListBox.SelectedItem as string;

            if (name != null && forgeItemsListBox.SelectedItem != null)
            {
                Item stableItem = ForgeItems.FirstOrDefault(x => x.Name == name);

                Form2.BackpackItems.Add(stableItem);  // Add to the BackpackItems list
                FindItemToRemove();
                Form2.ForgePanel1 = this;
                Form2.AddItemToCollectedListBox(name);
            }
            else
            {
                MessageBox.Show("You have to choose an item to add to your backpack");
            }
            SaveItems();
        }
        public void FindItemToRemove()
        {
            if (ForgeItems != null && forgeItemsListBox.SelectedItem != null)
            {
                string selectedItemName = forgeItemsListBox.SelectedItem as string;
                if (selectedItemName != null)
                {
                    Item selectedItem = ForgeItems.Find(item => item.Name == selectedItemName);
                    if (selectedItem != null)
                    {
                        ForgeItems.Remove(selectedItem);
                        UpdateListBox();
                    }
                }
            }
        }
        private void SaveItems()
        {
            string json = JsonConvert.SerializeObject(ForgeItems);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(json);
            }
        }
        private void LoadAll()
        {
            using (StreamReader sr = new(path))
            {
                string json = sr.ReadToEnd();
                ForgeItems = JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }
        public void AddBackToPanel(Item item)
        {
            forgeItemsListBox.Items.Add(item.Name);
            ForgeItems.Add(item);
        }
    }
}
