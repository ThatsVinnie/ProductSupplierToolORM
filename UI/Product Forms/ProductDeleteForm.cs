using Services;

namespace UI.Product_Forms
{
    public partial class ProductDeleteForm : Form
    {
        private int idProduct;
        private string productName;
        private readonly ProductServices _productServices;

        public ProductDeleteForm(int _idProduct, string _productName, ProductServices productServices)
        {
            InitializeComponent();

            idProduct = _idProduct;
            productName = _productName;

            txtTitle.Text = "Is it the product: " + productName + " you want to delete?";

            _productServices = productServices;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (_productServices.DeleteProduct(idProduct))
            {
                MessageBox.Show("Product has been succesfully deleted!");
            }
            else
            {
                MessageBox.Show("An ERROR has ocurred while deleting a Product");
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
