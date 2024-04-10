using System.Text.RegularExpressions;
using Services;

namespace UI
{
    public partial class SupplierAddForm : Form
    {
        public SupplierAddForm()
        {
            InitializeComponent();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            // Validando se os campos foram preenchidos
            if (checkFieldsFill())
            {
                MessageBox.Show("Fill the necessary fields: \n\n(Name and Cnpj)");
                return;
            }

            // Validando se há duplicidade de CNPJ no sistema
            if (ValidateSupplierCnpj())
            {
                MessageBox.Show("Cnpj already registered, it must be unique!");
                return;
            }

            if (SupplierServices.AddSupplier(txtName.Text, txtCnpj.Text, txtMail.Text))
            {
                MessageBox.Show("Supplier has been succesfully created");
            }
            else
            {
                MessageBox.Show("An ERROR has ocurred while creating a Supplier");
            }
            this.Close();
        }

        // Método para validar preenchimento dos campos
        private bool checkFieldsFill()
        {
            string pattern = @"[^\d]";

            // Remover caracteres especiais da máscara de CNPJ
            string result = Regex.Replace(txtCnpj.Text, pattern, "");

            if (txtName.Text == "" || result == "" || result.Length < 14)
            {
                return true;
            }
            return false;
        }

        // Método para validar duplicidade do CNPJ
        private bool ValidateSupplierCnpj()
        {
            bool response = Services.SupplierServices.ValidateSupplierCnpj(txtCnpj.Text);
            return response;
        }
    }
}
