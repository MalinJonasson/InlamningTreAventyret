using Newtonsoft.Json;
using System.IO;

namespace InlämningTreÄventyret
{
    public partial class FoodCellerPanel : UserControl
    {
        public Form2 Form2;
        public List<Item> FoodCellerItems = new();
        public FoodCellerPanel()
        {
            InitializeComponent();
           // Form2.SetFoodCellerPanel(this);

            FileInfo file = new FileInfo(path);
            if (!file.Exists)
            {
               FoodCellerItems.Add(new Item("Potatos", "FoodCeller"));
               FoodCellerItems.Add(new Item("Carrots", "FoodCeller"));
               FoodCellerItems.Add(new Item("Parsnip", "FoodCeller"));

               foreach (Item item in FoodCellerItems)
               {
                 foodCellerItemsListBox.Items.Add(item.Name);
               }            }
            else
            {
                LoadAll();
            }
            UpdateListBox();
        }

        string path = "foodcellerpanellist.json";
        public void SetForm2(Form2 form2)
        {
            Form2 = form2;
            Form2.FoodCellerPanel1 = this;
        }
        private void goBackFoodCellerButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void addItemFoodCellerButton_Click(object sender, EventArgs e)
        {
            string name = ItemFoodCellerTextBox.Text;
            if (!string.IsNullOrEmpty(name))
            {
                Item item = new Item(name, "FoodCeller");
                FoodCellerItems.Add(item);
                foodCellerItemsListBox.Items.Add(item.Name);
                ItemFoodCellerTextBox.Clear();
            }
            else
            {
                MessageBox.Show("You have to write something");
            }
            SaveItems();
        }
        private void removeFoodCellerItemButten_Click(object sender, EventArgs e)
        {
            FindItemToRemove();
            SaveItems();
        }
        private void UpdateListBox()
        {
            foodCellerItemsListBox.Items.Clear();

            foreach (Item item in FoodCellerItems)
            {
                foodCellerItemsListBox.Items.Add(item.Name);
            }
        }
        private void addToBackPackFoodCButton_Click(object sender, EventArgs e)
        {
            string? name = foodCellerItemsListBox.SelectedItem as string;

            if (name != null && foodCellerItemsListBox.SelectedItem != null)
            {
                Item stableItem = FoodCellerItems.FirstOrDefault(x => x.Name == name);

                Form2.BackpackItems.Add(stableItem);  // Add to the BackpackItems list
                FindItemToRemove();
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
            if (FoodCellerItems != null && foodCellerItemsListBox.SelectedItem != null)
            {
                string selectedItemName = foodCellerItemsListBox.SelectedItem as string;
                if (selectedItemName != null)
                {
                    Item selectedItem = FoodCellerItems.Find(item => item.Name == selectedItemName);
                    if (selectedItem != null)
                    {
                        FoodCellerItems.Remove(selectedItem);
                        UpdateListBox();
                    }
                }
            }
        }
        private void SaveItems()
        {
            string json = JsonConvert.SerializeObject(FoodCellerItems);

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
                FoodCellerItems = JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }
        public void AddBackToPanel(Item item)
        {
            foodCellerItemsListBox.Items.Add(item.Name);
            FoodCellerItems.Add(item);
        }
    }
}
