using ProductInventory.Repositories;
using ProductInventory.Services;

namespace ProductInventory
{
    public partial class Form1 : Form
    {
        private readonly ProductService _productService;
        public Form1()
        {
            InitializeComponent();
            var repo = new ProductRepository();
            _productService = new ProductService(repo);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter valid values.");
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out int quantity) ||
                !int.TryParse(txtUnitPrice.Text, out int unitPrice))
            {
                MessageBox.Show("Please enter valid numbers for quantity and unit price.");
                return;
            }
            
            string name = txtName.Text;
            string description = txtDescription.Text;

            _productService.AddProduct(name, quantity, unitPrice, description);
            LoadProducts();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string term = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(term))
            {
                LoadProducts();
            }
            else
            {
                var results = _productService.Search(term);

                if (results.Count == 0)
                {
                    MessageBox.Show($"No product found for \"{term}\". Click 'View Products' to see all.");
                    txtSearch.Clear();
                }

                dataGridView1.DataSource = results;
            }
        }

        private void LoadProducts()
        {
            var products = _productService.GetAll();
            dataGridView1.DataSource = products;
        }


    }
}
