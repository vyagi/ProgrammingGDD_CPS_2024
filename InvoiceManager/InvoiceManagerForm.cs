namespace InvoiceManager
{
    public partial class InvoiceManagerForm : Form
    {
        public InvoiceManagerForm()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("The file does not exist. Cannot continue.");
                return;
            }

            var content = File.ReadAllText(path);

            resultTextBox.Text = content;
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("The file does not exist. Cannot continue.");
                return;
            }

            var lines = File.ReadAllLines(path);

            var categories = new Dictionary<string, decimal>();

            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];

                var splitLine = line.Split(';');

                var amount = decimal.Parse(splitLine[1].Replace(".",","));
                var category = splitLine[2];

                if (categories.ContainsKey(category))
                {
                    categories[category] += amount;
                }
                else 
                {
                    categories[category] = amount;
                }
            }

            resultTextBox.Clear();

            foreach (var category in categories.Keys) 
            {
                resultTextBox.Text += $"{category}\t{categories[category]}{Environment.NewLine}";
            }

        }
    }
}
