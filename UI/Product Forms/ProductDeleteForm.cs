namespace UI.Product_Forms
{
    public partial class ProductDeleteForm : Form
    {
        private int idProduct;
        private string productName;

        public ProductDeleteForm(int _idProduct, string _productName)
        {
            InitializeComponent();

            idProduct = _idProduct;
            productName = _productName;

            txtTitle.Text = "Is it the product: " + productName + " you want to delete?";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (Services.ProductServices.DeleteProduct(idProduct))
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
