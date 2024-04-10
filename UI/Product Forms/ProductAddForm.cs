using System.Text.RegularExpressions;

namespace UI
{
    public partial class ProductAddForm : Form
    {
        private List<Domain.Supplier> suppliersList = Services.SupplierServices.FillComboBoxSupplier();
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public ProductAddForm()
        {
            InitializeComponent();

            // Carregando dados do ComboBox de Suppliers
            foreach (var supplier in suppliersList)
            {
                cmbBoxSupppliers.Items.Add(new ComboBoxItem { Text = supplier.Name, Value = supplier.Id });
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Validando se os campos foram preenchidos
            if (checkFieldsFill())
            {
                MessageBox.Show("Fill the necessary fields: \n\n(Name, Price and Quantity)");
                return;
            }


            // Validando se o campo QUANTITY está no formato correto
            if (checkQtdeFormat())
            {
                MessageBox.Show("Set only integer values for Quantity");
                return;
            }


            // Validando se o campo PRICE está no formato correto
            if(checkPriceFormat())
            {
                MessageBox.Show("Set only numbers in the right format for Price \n\n Ex: 2500,00 or 2500");
                return;
            }


            var selectedSupplier = cmbBoxSupppliers.SelectedItem as ComboBoxItem;

            if (selectedSupplier != null)
            {
                int supplierId = (int)selectedSupplier.Value;

                if (Services.ProductServices.AddProduct(txtName.Text, txtDescr.Text, txtPrice.Text, txtQtde.Text, supplierId))
                {
                    MessageBox.Show("Product has been succesfully created");
                }
                else
                {
                    MessageBox.Show("An ERROR has ocurred while creating a Product");
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
            if( txtName.Text == "" || txtPrice.Text == "" || txtQtde.Text == "")
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

            if(!Regex.IsMatch(txtPrice.Text, pattern))
            {
                txtPrice.Text = "";
                return true;
            }
            return false;
        }
    }
}
