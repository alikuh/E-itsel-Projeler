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
                {"D�ner", 180},
                {"Lahmacun", 120},
                {"Tavuk �i�", 170},
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
                string itemName = selectedItem.Split('_')[0].Trim(); // "_" yerine do�ru ay�r�c�y� kullanmal�s�n�z

                if (menu.ContainsKey(itemName))
                {
                    sepet.Add(itemName);
                    toplam_fiyat += menu[itemName];
                    listBox2.Items.Add(selectedItem);  // Sepete eklenen ��e
                    label1.Text = $"Toplam tutar : {toplam_fiyat:C}";
                }
            }
            else
            {
                MessageBox.Show("L�tfen bir �r�n se�in!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string yeni_�r�n = textBox1.Text.Trim(); // Yeni �r�n ismi textBox1'den al�n�yor
            string yeni_�r�nFiyati = textBox2.Text.Trim(); // �r�n fiyat� textBox2'den al�n�yor

            if (string.IsNullOrEmpty(yeni_�r�n) || string.IsNullOrEmpty(yeni_�r�nFiyati) || !decimal.TryParse(yeni_�r�nFiyati, out decimal productPrice))
            {
                MessageBox.Show("L�tfen ge�erli bir �r�n ismi ve fiyat� girin.", "Ge�ersiz Girdi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yeni �r�n� men�ye ekleyelim
            menu[yeni_�r�n] = productPrice;

            // L�stBoxa ekleyelim
            listBox1.Items.Add($"{yeni_�r�n} _ {productPrice:C}");

            // TextBox'lar� temizleyelim
            textBox1.Clear();
            textBox2.Clear();

            MessageBox.Show($"'{yeni_�r�n}' �r�n� ba�ar�yla eklendi.", "�r�n Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }
