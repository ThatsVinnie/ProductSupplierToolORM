using System.Text.RegularExpressions;

namespace UI
{
    public partial class ProductEditForm : Form
    {
        private List<Domain.Supplier> suppliersList = Services.SupplierServices.FillComboBoxSupplier();

        private int idProduct;
        private string oldPrice;
        private string oldName;
        private string oldQtde;

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public ProductEditForm(string _name, string _descr, string _price, string _qtde, string _supplierName, int _idProduct)
        {
            InitializeComponent();

            idProduct = _idProduct;

            // Carregando dados do ComboBox de Suppliers
            foreach (var supplier in suppliersList)
            {
                cmbBoxSuppliers.Items.Add(new ComboBoxItem { Text = supplier.Name, Value = supplier.Id });
            }

            txtName.Text = _name;
            txtDescr.Text = _descr;
            txtPrice.Text = _price;
            txtQtde.Text = _qtde;

            oldPrice = _price;
            oldName = _name;
            oldQtde = _qtde;

            // Setando o valor do Supplier Atual
            foreach (ComboBoxItem item in cmbBoxSuppliers.Items)
            {
                if (item.Text == _supplierName)
                {
                    cmbBoxSuppliers.SelectedItem = item;
                    break;
                }
            }

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            // Validando se os campos foram preenchidos
            if (checkFieldsFill())
            {
                MessageBox.Show("Fill the necessary fields: \n\n(Name, Price and Quantity)");
                txtName.Text = oldName;
                txtPrice.Text = oldPrice;
                txtQtde.Text = oldQtde;
                return;
            }


            // Validando se o campo QUANTITY está no formato correto
            if (checkQtdeFormat())
            {
                MessageBox.Show("Set only integer values for Quantity");
                txtQtde.Text = oldQtde;
                return;
            }


            // Validando se o campo PRICE está no formato correto
            if (checkPriceFormat())
            {
                MessageBox.Show("Set only numbers in the right format for Price \n\n Ex: 2500,00 or 2500");
                txtPrice.Text = oldPrice;
                return;
            }

            var selectedSupplier = cmbBoxSuppliers.SelectedItem as ComboBoxItem;

            if (selectedSupplier != null)
            {
                int newSupplierId = (int)selectedSupplier.Value;

                if (Services.ProductServices.UpdateProduct(txtName.Text, txtDescr.Text, txtPrice.Text, txtQtde.Text, newSupplierId, idProduct))
                {
                    MessageBox.Show("Product has been succesfully updated");
                }
                else
                {
                    MessageBox.Show("An ERROR has ocurred while updating a Product");
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Select a Supplier!");
            }
        }

        // Método para validar preenchimento dos campos
        private bool checkFieldsFill()
        {
            if (txtName.Text == "" || txtPrice.Text == "" || txtQtde.Text == "")
            {
                return true;
            }
            return false;
        }

        // Método para validar formato de QUANTITY(Ex.: 20 | 12 | 1 )
        private bool checkQtdeFormat()
        {
            string pattern = @"^\d*$";

            if (!Regex.IsMatch(txtQtde.Text, pattern))
            {
                return true;
            }
            return false;
        }

        // Método para validar formato de PRICE(Ex.: 200,00 | 200 | 2.500,34)
        private bool checkPriceFormat()
        {
            string pattern = @"^\d+(,\d{1,2})?$";

            if (!Regex.IsMatch(txtPrice.Text, pattern))
            {
                return true;
            }
            return false;
        }
    }
}
