namespace final_calismasi
{
    public partial class Form1 : Form
    {
        public Dictionary<string, decimal> menu;
        public List<string> sepet;
        public decimal toplam_fiyat;

        public Form1()
        {
            InitializeComponent();
            initializeMenu();
        }
        public void initializeMenu()
        {
            menu = new Dictionary<string, decimal>
            {
                {"Hamburger", 150},
                {"Pizza", 200},
                {"Döner", 180},
                {"Lahmacun", 120},
                {"Tavuk Þiþ", 170},
                {"Su", 15},
                {"Kola", 35},
                {"Ayran", 25}
            };
            sepet = new List<string>();
            toplam_fiyat = 0;
            foreach (var item in menu)
            {
                listBox1.Items.Add($"{item.Key} _ {item.Value:C}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                string itemName = selectedItem.Split('_')[0].Trim(); // "_" yerine doðru ayýrýcýyý kullanmalýsýnýz

                if (menu.ContainsKey(itemName))
                {
                    sepet.Add(itemName);
                    toplam_fiyat += menu[itemName];
                    listBox2.Items.Add(selectedItem);  // Sepete eklenen öðe
                    label1.Text = $"Toplam tutar : {toplam_fiyat:C}";
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sepet.Clear();
            toplam_fiyat = 0;
            listBox2.Items.Clear();
            label1.Text = "Toplam: 0 TL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string yeni_ürün = textBox1.Text.Trim(); // Yeni ürün ismi textBox1'den alýnýyor
            string yeni_ürünFiyati = textBox2.Text.Trim(); // Ürün fiyatý textBox2'den alýnýyor

            if (string.IsNullOrEmpty(yeni_ürün) || string.IsNullOrEmpty(yeni_ürünFiyati) || !decimal.TryParse(yeni_ürünFiyati, out decimal productPrice))
            {
                MessageBox.Show("Lütfen geçerli bir ürün ismi ve fiyatý girin.", "Geçersiz Girdi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yeni ürünü menüye ekleyelim
            menu[yeni_ürün] = productPrice;

            // LÝstBoxa ekleyelim
            listBox1.Items.Add($"{yeni_ürün} _ {productPrice:C}");

            // TextBox'larý temizleyelim
            textBox1.Clear();
            textBox2.Clear();

            MessageBox.Show($"'{yeni_ürün}' ürünü baþarýyla eklendi.", "Ürün Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }
