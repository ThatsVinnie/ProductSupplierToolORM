using System.Data;
using System.Windows.Forms;

namespace ProductSupplierTool
{
    public partial class Main : Form
    {

        private DataTable products;
        private DataTable suppliers;

        public Main()
        {
            InitializeComponent();

            //Exibindo a tabela de produtos
            ShowProductData();
        }

        // Métodos para recuperar dados
        private void ShowProductData()
        {
            dataGridViewProducts.Columns.Clear(); // Limpando as colunas padrão

            dataGridViewProducts.AutoGenerateColumns = false; // Configurando colunas personalizadas

            // Adicionando colunas manualmente
            var idColumn = new DataGridViewTextBoxColumn(); // Coluna oculta para armazenar os IDs
            idColumn.Name = "ID";

            dataGridViewProducts.Columns.Add(idColumn);
            dataGridViewProducts.Columns.Add("Name", "Name");
            dataGridViewProducts.Columns.Add("Description", "Description");
            dataGridViewProducts.Columns.Add("Price", "Price");
            dataGridViewProducts.Columns.Add("Quantity", "Quantity");
            dataGridViewProducts.Columns.Add("Supplier", "Supplier");

            // Associando os dados às colunas
            dataGridViewProducts.Columns["Name"].DataPropertyName = "_name";
            dataGridViewProducts.Columns["Description"].DataPropertyName = "descr";
            dataGridViewProducts.Columns["Price"].DataPropertyName = "price";
            dataGridViewProducts.Columns["Quantity"].DataPropertyName = "quantity";
            dataGridViewProducts.Columns["Supplier"].DataPropertyName = "supplier_name";
            dataGridViewProducts.Columns["ID"].DataPropertyName = "id";

            idColumn.Visible = false; // Ocultando a coluna ID
            dataGridViewProducts.Columns["Price"].DefaultCellStyle.Format = "c"; // Formatando a coluna de preço

            SetProductData();
        }
        private void ShowSupplierData()
        {
            dataGridViewSuppliers.Columns.Clear(); // Limpando as colunas padrão

            dataGridViewSuppliers.AutoGenerateColumns = false; // Configurando colunas personalizadas

            var idSupColumn = new DataGridViewTextBoxColumn(); // Coluna oculta para armazenar os IDs
            idSupColumn.Name = "ID";

            // Adicionando colunas manualmente
            dataGridViewSuppliers.Columns.Add(idSupColumn);
            dataGridViewSuppliers.Columns.Add("Name", "Name");
            dataGridViewSuppliers.Columns.Add("Cnpj", "CNPJ");
            dataGridViewSuppliers.Columns.Add("Email", "Email");

            // Associando os dados às colunas
            dataGridViewSuppliers.Columns["Name"].DataPropertyName = "_Name";
            dataGridViewSuppliers.Columns["Cnpj"].DataPropertyName = "Cnpj";
            dataGridViewSuppliers.Columns["Email"].DataPropertyName = "Email";
            dataGridViewSuppliers.Columns["ID"].DataPropertyName = "id";
            idSupColumn.Visible = false;

            SetSupplierData();
        }
        private void SetProductData()
        {
            // Recebendo os dados do banco
            products = Services.ProductServices.DisplayProducts();

            // Exibindo dados para o cliente
            dataGridViewProducts.DataSource = products;
        }
        private void SetSupplierData()
        {
            suppliers = Services.SupplierServices.DisplaySuppliers();

            dataGridViewSuppliers.DataSource = suppliers;
        }



        // Métodos CRUD Product
        private void btnAddDataProduct_Click(object sender, EventArgs e)
        {
            var productAddForm = new UI.ProductAddForm();

            productAddForm.ShowDialog();

            SetProductData();
        }
        private void btnAlterDataProduct_Click(object sender, EventArgs e)
        {
            int indexSelectedLine = dataGridViewProducts.SelectedRows[0].Index;

            var selectedLine = dataGridViewProducts.Rows[indexSelectedLine];

            object idProduct = dataGridViewProducts.Rows[indexSelectedLine].Cells["ID"].Value;

            string name = selectedLine.Cells["Name"].Value.ToString();
            string descr = selectedLine.Cells["Description"].Value.ToString();
            string price = selectedLine.Cells["Price"].Value.ToString();
            string qtde = selectedLine.Cells["Quantity"].Value.ToString();
            string supplier = selectedLine.Cells["Supplier"].Value.ToString();

            var productEditForm = new UI.ProductEditForm(name, descr, price, qtde, supplier, Convert.ToInt32(idProduct));

            productEditForm.ShowDialog();

            SetProductData();
        }
        private void btnDeleteDataProduct_Click(object sender, EventArgs e)
        {
            int indexSelectedLine = dataGridViewProducts.SelectedRows[0].Index;

            int idProduct = Convert.ToInt32(dataGridViewProducts.Rows[indexSelectedLine].Cells["ID"].Value);
            string productName = dataGridViewProducts.Rows[indexSelectedLine].Cells["Name"].Value.ToString();

            var deleteForm = new UI.Product_Forms.ProductDeleteForm(idProduct, productName);

            deleteForm.ShowDialog();

            SetProductData();
        }



        // Métodos CRUD Supplier
        private void btnAddDataSupplier_Click(object sender, EventArgs e)
        {
            var supplierCad = new UI.SupplierAddForm();

            supplierCad.ShowDialog();

            SetSupplierData();
        }
        private void btnAlterDataSupplier_Click(object sender, EventArgs e)
        {
            int indexSelectedLine = dataGridViewSuppliers.SelectedRows[0].Index;

            var selectedLine = dataGridViewSuppliers.Rows[indexSelectedLine];

            int idSupplier = Convert.ToInt32(dataGridViewSuppliers.Rows[indexSelectedLine].Cells["ID"].Value);
            string name = selectedLine.Cells["Name"].Value.ToString();
            string cnpj = selectedLine.Cells["Cnpj"].Value.ToString();
            string mail = selectedLine.Cells["Email"].Value.ToString();

            var supplierEditForm = new UI.SupplierEditForm(name, cnpj, mail, idSupplier);
                
            supplierEditForm.ShowDialog();

            SetSupplierData();
        }
        private void btnDeleteDataSupplier_Click(object sender, EventArgs e)
        {
            int indexSelectedLine = dataGridViewSuppliers.SelectedRows[0].Index;

            int idSupplier = Convert.ToInt32(dataGridViewSuppliers.Rows[indexSelectedLine].Cells["ID"].Value);
            string supplierName = dataGridViewSuppliers.Rows[indexSelectedLine].Cells["Name"].Value.ToString();

            var deleteForm = new UI.Supplier_Forms.SupplierDeleteForm(idSupplier, supplierName);

            deleteForm.ShowDialog();

            SetSupplierData();
        }



        // Métodos de design
        private void SetTabTitle()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                lblPageTitle.Text = "Products";
            }
            else
            {
                lblPageTitle.Text = "Suppliers";
            }
        }
        private void btnSwitchProdTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

            // Alterando o título da página
            SetTabTitle();

            // Recarregando dados
            ShowProductData();
        }
        private void btnSwitchSupTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

            // Alterando o título da página
            SetTabTitle();

            // Recarregando os dados
            ShowSupplierData();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                // Alterando o título da página para Product
                SetTabTitle();

                // Recarregando os dados de Product
                ShowProductData();
            }
            //Alterando o título da página para Supplier
            SetTabTitle();

            // Recarregando os dados de Supplier
            ShowSupplierData();
        }


        // Método para SearchBar Products
        private void txtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            string filter = txtSearchProduct.Text.Trim();

            SetProductData();

            if (!string.IsNullOrEmpty(filter))
            {
                // Aplicar filtro
                DataView dv = products.DefaultView;
                dv.RowFilter = $"_name LIKE '%{filter}%'";
                dataGridViewProducts.DataSource = dv;
            }
            else
            {
                // Limpar filtro
                dataGridViewProducts.DataSource = products;
            }
        }

        // Método para SearchBar Suppliers
        private void txtSearchSuppliers_TextChanged(object sender, EventArgs e)
        {
            string filter = txtSearchSupplier.Text.Trim();

            SetSupplierData();

            if (!string.IsNullOrEmpty(filter))
            {
                // Aplicar filtro
                DataView dv = suppliers.DefaultView;
                dv.RowFilter = $"_name LIKE '%{filter}%'";
                dataGridViewSuppliers.DataSource = dv;
            }
            else
            {
                // Limpar filtro
                dataGridViewSuppliers.DataSource = suppliers;
            }
        }
    }
}
