namespace UI.Supplier_Forms
{
    public partial class SupplierDeleteForm : Form
    {
        private int idSupplier;
        private string supplierName;

        public SupplierDeleteForm(int _idSupplier, string _supplierName)
        {
            InitializeComponent();

            idSupplier = _idSupplier;
            supplierName = _supplierName;

            txtTitle.Text = "Is it the supplier: " + supplierName + " you want to delete?";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (Services.SupplierServices.DeleteSupplier(idSupplier))
            {
                MessageBox.Show("Supplier has been succesfully deleted!");
            }
            else
            {
                MessageBox.Show("An ERROR has ocurred while deleting a Supplier: \n\n 'The Supplier has one or more products associated with it'");
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
