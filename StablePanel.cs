using Newtonsoft.Json;

namespace InlämningTreÄventyret
{
    public partial class StablePanel : UserControl
    {
        public Form2 Form2;
        public List<Item> StableItems = new();
        public StablePanel()
        {

            InitializeComponent();
            //Form2.SetStablePanel(this);

            FileInfo file = new FileInfo(path);
            if (!file.Exists)
            {
                StableItems.Add(new Item("Horse", "Stable"));
                StableItems.Add(new Item("Pitchfork", "Stable"));
                StableItems.Add(new Item("Sadle", "Stable"));

                foreach (Item item in StableItems)
                {
                    stableItemsListBox.Items.Add(item.Name);
                }
            }
            else
            {
                LoadAll();
            }
            UpdateListBox();

        }
        string path = "stablepanellist.json";

        public void SetForm2(Form2 form2)
        {
            Form2 = form2;
        }
        private void goBackStableButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void addStableItemButton_Click(object sender, EventArgs e)
        {
            string name = addItemStableTextBox.Text;

            if (!string.IsNullOrEmpty(name))
            {
                Item item = new Item(name, "Stable");
                StableItems.Add(item);
                stableItemsListBox.Items.Add(item.Name);
                addItemStableTextBox.Clear();
            }
            else
            {
                MessageBox.Show("You have to write something");
            }
            SaveItems();
        }
        private void removeStableItemButton_Click(object sender, EventArgs e)
        {
            FindItemToRemove();
            SaveItems();
        }
        private void UpdateListBox()
        {
            stableItemsListBox.Items.Clear();

            foreach (Item item in StableItems)
            {
                stableItemsListBox.Items.Add(item.Name);
            }
        }
        private void addToBackpackButton_Click(object sender, EventArgs e)
        {
            string? name = stableItemsListBox.SelectedItem as string;

            if (name != null && stableItemsListBox.SelectedItem != null)
            {
                Item stableItem = StableItems.FirstOrDefault(x => x.Name == name);

                Form2.BackpackItems.Add(stableItem);  // Add to the BackpackItems list
                FindItemToRemove();
                Form2.StablePanel1 = this;
                Form2.AddItemToCollectedListBox(name);
            }
            else
            {
                MessageBox.Show("You have to choose an item to add to your backpack");
            }
            SaveItems();
        }
        private void SaveItems()
        {
            string json = JsonConvert.SerializeObject(StableItems);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(json);
            }
        }
        public void FindItemToRemove()
        {
            if (StableItems != null && stableItemsListBox.SelectedItem != null)
            {
                if (stableItemsListBox.SelectedItem is string selectedItemName)
                {
                    Item selectedItem = StableItems.Find(item => item.Name == selectedItemName);
                    if (selectedItem != null)
                    {
                        StableItems.Remove(selectedItem);
                        UpdateListBox();
                    }
                }
            }
        }
        private void LoadAll()
        {
            using (StreamReader sr = new(path))
            {
                string json = sr.ReadToEnd();
                StableItems = JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }
        public void AddBackToPanel(Item item)
        {
            stableItemsListBox.Items.Add(item.Name);
            StableItems.Add(item);
        }
    }
}
