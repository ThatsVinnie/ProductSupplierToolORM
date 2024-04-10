using System.Text.RegularExpressions;

namespace UI
{
    public partial class SupplierEditForm : Form
    {
        private int idSupplier;
        private string oldName;
        private string oldCnpj;
        public SupplierEditForm(string _name, string _cnpj, string _mail, int _idSupplier)
        {
            InitializeComponent();

            txtName.Text = _name;
            txtCnpj.Text = _cnpj;
            txtMail.Text = _mail;

            idSupplier = _idSupplier;
            oldName = _name;
            oldCnpj = _cnpj;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validando se os campos foram preenchidos
            if (checkFieldsFill())
            {
                MessageBox.Show("Fill the necessary fields: \n\n(Name and Cnpj)");
                txtName.Text = oldName;
                txtCnpj.Text = oldCnpj;

                return;
            }

            // Validando se há duplicidade de CNPJ no sistema
            if (ValidateSupplierCnpj())
            {
                MessageBox.Show("Cnpj already registered, it must be unique!");
                txtCnpj.Text = oldCnpj;
                return;
            }

            if (Services.SupplierServices.UpdateSupplier(txtName.Text, txtCnpj.Text, txtMail.Text, idSupplier))
            {
                MessageBox.Show("Supplier has been succesfully updated");
            }
            else
            {
                MessageBox.Show("An ERROR has ocurred while updating a Supplier");
            }
            this.Close();
        }

        private bool checkFieldsFill()
        {
            string pattern = @"[^\d]";

            // Remover caracteres especiais
            string result = Regex.Replace(txtCnpj.Text, pattern, "");

            if (txtName.Text == "" || result == "" || result.Length < 14)
            {
                return true;
            }
            return false;
        }

        private bool ValidateSupplierCnpj()
        {
            bool response = Services.SupplierServices.ValidateSupplierCnpj(txtCnpj.Text);
            return response;
        }
    }
}
