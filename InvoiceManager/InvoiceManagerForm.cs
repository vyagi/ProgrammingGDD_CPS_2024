using System.Globalization;

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

            resultTextBox.Text = content.Replace("\n", "\r\n").Replace(";", "\t");
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

            var invoices = lines.Skip(1).Select(x => new Invoice(x)).ToList();

            var categories = new Dictionary<string, decimal>();

            foreach(var invoice in invoices) 
            {
                if (categories.ContainsKey(invoice.Category))
                {
                    categories[invoice.Category] += invoice.Amount;
                }
                else
                {
                    categories[invoice.Category] = invoice.Amount;
                }
            }

            resultTextBox.Clear();

            foreach (var category in categories.Keys)
            {
                resultTextBox.Text += $"{category}\t{categories[category]}{Environment.NewLine}";
            }

        }

        private void byMonthButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("The file does not exist. Cannot continue.");
                return;
            }

            var lines = File.ReadAllLines(path);

            var invoices = lines.Skip(1).Select(x => new Invoice(x)).ToList();

            var months = new Dictionary<string, decimal>();

            foreach (var invoice in invoices)
            {
                var month = $"{invoice.Date.Year}-{invoice.Date.Month}";

                if (months.ContainsKey(month))
                {
                    months[month] += invoice.Amount;
                }
                else
                {
                    months[month] = invoice.Amount;
                }
            }

            resultTextBox.Clear();
            foreach (var entry in months)
            {
                resultTextBox.Text += $"{entry.Key}\t{entry.Value}\r\n";
            }
        }
    }

    public class Invoice
    {
        public string Name { get; private set; }
        public decimal Amount { get; private set; }
        public string Category { get; private set; }
        public DateTime Date { get; private set; }

        public Invoice(string line)
        {
            var split = line.Split(";");
            
            Name = split[0];
            Amount = decimal.Parse(split[1]
                .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            Category = split[2];
            Date = DateTime.Parse(split[3]);
        }
    }
}
