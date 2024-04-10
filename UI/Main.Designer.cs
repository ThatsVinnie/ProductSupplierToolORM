namespace ProductSupplierTool
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnSwitchProdTab = new CustomButtons.CButton();
            btnSwitchSupTab = new CustomButtons.CButton();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            lblPageTitle = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtSearchProduct = new TextBox();
            btnDeleteDataProduct = new CustomButtons.CButton();
            btnAlterDataProduct = new CustomButtons.CButton();
            btnAddDataProduct = new CustomButtons.CButton();
            dataGridViewProducts = new DataGridView();
            tabPage2 = new TabPage();
            dataGridViewSuppliers = new DataGridView();
            txtSearchSupplier = new TextBox();
            btnDeleteDataSupplier = new CustomButtons.CButton();
            btnAlterDataSupplier = new CustomButtons.CButton();
            btnAddDataSupplier = new CustomButtons.CButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSwitchProdTab);
            panel1.Controls.Add(btnSwitchSupTab);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 664);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MintCream;
            panel4.Location = new Point(68, 122);
            panel4.Name = "panel4";
            panel4.Size = new Size(62, 1);
            panel4.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(11, 183);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnSwitchProdTab
            // 
            btnSwitchProdTab.BackColor = Color.DarkGreen;
            btnSwitchProdTab.BackgroundColor = Color.DarkGreen;
            btnSwitchProdTab.BorderColor = Color.PaleVioletRed;
            btnSwitchProdTab.BorderRadius = 0;
            btnSwitchProdTab.BorderSize = 0;
            btnSwitchProdTab.Cursor = Cursors.Hand;
            btnSwitchProdTab.FlatAppearance.BorderSize = 0;
            btnSwitchProdTab.FlatStyle = FlatStyle.Flat;
            btnSwitchProdTab.Font = new Font("MS Reference Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSwitchProdTab.ForeColor = Color.WhiteSmoke;
            btnSwitchProdTab.ImageAlign = ContentAlignment.MiddleLeft;
            btnSwitchProdTab.Location = new Point(49, 135);
            btnSwitchProdTab.Name = "btnSwitchProdTab";
            btnSwitchProdTab.Size = new Size(151, 40);
            btnSwitchProdTab.TabIndex = 6;
            btnSwitchProdTab.Text = "Products";
            btnSwitchProdTab.TextAlign = ContentAlignment.MiddleLeft;
            btnSwitchProdTab.TextColor = Color.WhiteSmoke;
            btnSwitchProdTab.UseVisualStyleBackColor = false;
            btnSwitchProdTab.Click += btnSwitchProdTab_Click;
            // 
            // btnSwitchSupTab
            // 
            btnSwitchSupTab.BackColor = Color.DarkGreen;
            btnSwitchSupTab.BackgroundColor = Color.DarkGreen;
            btnSwitchSupTab.BorderColor = Color.Violet;
            btnSwitchSupTab.BorderRadius = 0;
            btnSwitchSupTab.BorderSize = 0;
            btnSwitchSupTab.Cursor = Cursors.Hand;
            btnSwitchSupTab.FlatAppearance.BorderSize = 0;
            btnSwitchSupTab.FlatStyle = FlatStyle.Flat;
            btnSwitchSupTab.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSwitchSupTab.ForeColor = Color.WhiteSmoke;
            btnSwitchSupTab.Location = new Point(49, 180);
            btnSwitchSupTab.Name = "btnSwitchSupTab";
            btnSwitchSupTab.Size = new Size(151, 40);
            btnSwitchSupTab.TabIndex = 5;
            btnSwitchSupTab.Text = "Suppliers";
            btnSwitchSupTab.TextAlign = ContentAlignment.MiddleLeft;
            btnSwitchSupTab.TextColor = Color.WhiteSmoke;
            btnSwitchSupTab.UseVisualStyleBackColor = false;
            btnSwitchSupTab.Click += btnSwitchSupTab_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGreen;
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, -29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(183, 173);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(lblPageTitle);
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 100);
            panel2.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Cursor = Cursors.IBeam;
            lblPageTitle.Font = new Font("MS Reference Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblPageTitle.Location = new Point(13, 29);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(147, 35);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Products";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(201, 76);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(920, 588);
            tabControl1.TabIndex = 2;
            tabControl1.Tag = "";
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(txtSearchProduct);
            tabPage1.Controls.Add(btnDeleteDataProduct);
            tabPage1.Controls.Add(btnAlterDataProduct);
            tabPage1.Controls.Add(btnAddDataProduct);
            tabPage1.Controls.Add(dataGridViewProducts);
            tabPage1.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(912, 559);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Products";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Cursor = Cursors.IBeam;
            txtSearchProduct.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchProduct.Location = new Point(8, 33);
            txtSearchProduct.Margin = new Padding(5);
            txtSearchProduct.Multiline = true;
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.PlaceholderText = "Search for products";
            txtSearchProduct.Size = new Size(895, 40);
            txtSearchProduct.TabIndex = 25;
            txtSearchProduct.TextChanged += txtSearchProducts_TextChanged;
            // 
            // btnDeleteDataProduct
            // 
            btnDeleteDataProduct.BackColor = Color.Firebrick;
            btnDeleteDataProduct.BackgroundColor = Color.Firebrick;
            btnDeleteDataProduct.BorderColor = Color.PaleVioletRed;
            btnDeleteDataProduct.BorderRadius = 0;
            btnDeleteDataProduct.BorderSize = 0;
            btnDeleteDataProduct.Cursor = Cursors.Hand;
            btnDeleteDataProduct.FlatAppearance.BorderSize = 0;
            btnDeleteDataProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteDataProduct.Font = new Font("MS Reference Sans Serif", 12.75F);
            btnDeleteDataProduct.ForeColor = Color.White;
            btnDeleteDataProduct.Location = new Point(344, 512);
            btnDeleteDataProduct.Name = "btnDeleteDataProduct";
            btnDeleteDataProduct.Size = new Size(559, 40);
            btnDeleteDataProduct.TabIndex = 23;
            btnDeleteDataProduct.Text = "Delete";
            btnDeleteDataProduct.TextColor = Color.White;
            btnDeleteDataProduct.UseVisualStyleBackColor = false;
            btnDeleteDataProduct.Click += btnDeleteDataProduct_Click;
            // 
            // btnAlterDataProduct
            // 
            btnAlterDataProduct.BackColor = Color.SteelBlue;
            btnAlterDataProduct.BackgroundColor = Color.SteelBlue;
            btnAlterDataProduct.BorderColor = Color.PaleVioletRed;
            btnAlterDataProduct.BorderRadius = 0;
            btnAlterDataProduct.BorderSize = 0;
            btnAlterDataProduct.Cursor = Cursors.Hand;
            btnAlterDataProduct.FlatAppearance.BorderSize = 0;
            btnAlterDataProduct.FlatStyle = FlatStyle.Flat;
            btnAlterDataProduct.Font = new Font("MS Reference Sans Serif", 12.75F);
            btnAlterDataProduct.ForeColor = Color.White;
            btnAlterDataProduct.Location = new Point(183, 512);
            btnAlterDataProduct.Name = "btnAlterDataProduct";
            btnAlterDataProduct.Size = new Size(155, 40);
            btnAlterDataProduct.TabIndex = 22;
            btnAlterDataProduct.Text = "Update";
            btnAlterDataProduct.TextColor = Color.White;
            btnAlterDataProduct.UseVisualStyleBackColor = false;
            btnAlterDataProduct.Click += btnAlterDataProduct_Click;
            // 
            // btnAddDataProduct
            // 
            btnAddDataProduct.BackColor = Color.ForestGreen;
            btnAddDataProduct.BackgroundColor = Color.ForestGreen;
            btnAddDataProduct.BorderColor = Color.PaleVioletRed;
            btnAddDataProduct.BorderRadius = 0;
            btnAddDataProduct.BorderSize = 0;
            btnAddDataProduct.Cursor = Cursors.Hand;
            btnAddDataProduct.FlatAppearance.BorderSize = 0;
            btnAddDataProduct.FlatStyle = FlatStyle.Flat;
            btnAddDataProduct.Font = new Font("MS Reference Sans Serif", 12.75F);
            btnAddDataProduct.ForeColor = Color.White;
            btnAddDataProduct.Location = new Point(8, 512);
            btnAddDataProduct.Name = "btnAddDataProduct";
            btnAddDataProduct.Size = new Size(169, 40);
            btnAddDataProduct.TabIndex = 7;
            btnAddDataProduct.Text = "Add";
            btnAddDataProduct.TextColor = Color.White;
            btnAddDataProduct.UseVisualStyleBackColor = false;
            btnAddDataProduct.Click += btnAddDataProduct_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.BorderStyle = BorderStyle.None;
            dataGridViewProducts.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.ForestGreen;
            dataGridViewCellStyle1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProducts.EnableHeadersVisualStyles = false;
            dataGridViewProducts.GridColor = Color.Yellow;
            dataGridViewProducts.Location = new Point(8, 79);
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkGreen;
            dataGridViewCellStyle3.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewProducts.RowTemplate.ReadOnly = true;
            dataGridViewProducts.ScrollBars = ScrollBars.Vertical;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.ShowCellErrors = false;
            dataGridViewProducts.ShowCellToolTips = false;
            dataGridViewProducts.ShowEditingIcon = false;
            dataGridViewProducts.ShowRowErrors = false;
            dataGridViewProducts.Size = new Size(895, 425);
            dataGridViewProducts.TabIndex = 21;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewSuppliers);
            tabPage2.Controls.Add(txtSearchSupplier);
            tabPage2.Controls.Add(btnDeleteDataSupplier);
            tabPage2.Controls.Add(btnAlterDataSupplier);
            tabPage2.Controls.Add(btnAddDataSupplier);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(912, 559);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Suppliers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.AllowUserToAddRows = false;
            dataGridViewSuppliers.AllowUserToDeleteRows = false;
            dataGridViewSuppliers.AllowUserToResizeRows = false;
            dataGridViewSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSuppliers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewSuppliers.BackgroundColor = Color.White;
            dataGridViewSuppliers.BorderStyle = BorderStyle.None;
            dataGridViewSuppliers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewSuppliers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.ForestGreen;
            dataGridViewCellStyle4.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.Padding = new Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Cursor = Cursors.Hand;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewSuppliers.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewSuppliers.EnableHeadersVisualStyles = false;
            dataGridViewSuppliers.GridColor = Color.Yellow;
            dataGridViewSuppliers.Location = new Point(8, 79);
            dataGridViewSuppliers.MultiSelect = false;
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.ReadOnly = true;
            dataGridViewSuppliers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.DarkGreen;
            dataGridViewCellStyle6.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkGreen;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewSuppliers.RowHeadersVisible = false;
            dataGridViewSuppliers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewSuppliers.RowTemplate.ReadOnly = true;
            dataGridViewSuppliers.ScrollBars = ScrollBars.Vertical;
            dataGridViewSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSuppliers.ShowCellErrors = false;
            dataGridViewSuppliers.ShowCellToolTips = false;
            dataGridViewSuppliers.ShowEditingIcon = false;
            dataGridViewSuppliers.ShowRowErrors = false;
            dataGridViewSuppliers.Size = new Size(895, 426);
            dataGridViewSuppliers.TabIndex = 31;
            // 
            // txtSearchSupplier
            // 
            txtSearchSupplier.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchSupplier.Location = new Point(8, 33);
            txtSearchSupplier.Multiline = true;
            txtSearchSupplier.Name = "txtSearchSupplier";
            txtSearchSupplier.PlaceholderText = "Search for suppliers";
            txtSearchSupplier.Size = new Size(895, 40);
            txtSearchSupplier.TabIndex = 30;
            txtSearchSupplier.TextChanged += txtSearchSuppliers_TextChanged;
            // 
            // btnDeleteDataSupplier
            // 
            btnDeleteDataSupplier.BackColor = Color.Firebrick;
            btnDeleteDataSupplier.BackgroundColor = Color.Firebrick;
            btnDeleteDataSupplier.BorderColor = Color.Violet;
            btnDeleteDataSupplier.BorderRadius = 0;
            btnDeleteDataSupplier.BorderSize = 0;
            btnDeleteDataSupplier.Cursor = Cursors.Hand;
            btnDeleteDataSupplier.FlatAppearance.BorderSize = 0;
            btnDeleteDataSupplier.FlatStyle = FlatStyle.Flat;
            btnDeleteDataSupplier.Font = new Font("MS Reference Sans Serif", 12.75F);
            btnDeleteDataSupplier.ForeColor = Color.White;
            btnDeleteDataSupplier.Location = new Point(344, 512);
            btnDeleteDataSupplier.Name = "btnDeleteDataSupplier";
            btnDeleteDataSupplier.Size = new Size(559, 40);
            btnDeleteDataSupplier.TabIndex = 28;
            btnDeleteDataSupplier.Text = "Delete";
            btnDeleteDataSupplier.TextColor = Color.White;
            btnDeleteDataSupplier.UseVisualStyleBackColor = false;
            btnDeleteDataSupplier.Click += btnDeleteDataSupplier_Click;
            // 
            // btnAlterDataSupplier
            // 
            btnAlterDataSupplier.BackColor = Color.SteelBlue;
            btnAlterDataSupplier.BackgroundColor = Color.SteelBlue;
            btnAlterDataSupplier.BorderColor = Color.Violet;
            btnAlterDataSupplier.BorderRadius = 0;
            btnAlterDataSupplier.BorderSize = 0;
            btnAlterDataSupplier.Cursor = Cursors.Hand;
            btnAlterDataSupplier.FlatAppearance.BorderSize = 0;
            btnAlterDataSupplier.FlatStyle = FlatStyle.Flat;
            btnAlterDataSupplier.Font = new Font("MS Reference Sans Serif", 12.75F);
            btnAlterDataSupplier.ForeColor = Color.White;
            btnAlterDataSupplier.Location = new Point(183, 512);
            btnAlterDataSupplier.Name = "btnAlterDataSupplier";
            btnAlterDataSupplier.Size = new Size(155, 40);
            btnAlterDataSupplier.TabIndex = 27;
            btnAlterDataSupplier.Text = "Update";
            btnAlterDataSupplier.TextColor = Color.White;
            btnAlterDataSupplier.UseVisualStyleBackColor = false;
            btnAlterDataSupplier.Click += btnAlterDataSupplier_Click;
            // 
            // btnAddDataSupplier
            // 
            btnAddDataSupplier.BackColor = Color.ForestGreen;
            btnAddDataSupplier.BackgroundColor = Color.ForestGreen;
            btnAddDataSupplier.BorderColor = Color.Violet;
            btnAddDataSupplier.BorderRadius = 0;
            btnAddDataSupplier.BorderSize = 0;
            btnAddDataSupplier.Cursor = Cursors.Hand;
            btnAddDataSupplier.FlatAppearance.BorderSize = 0;
            btnAddDataSupplier.FlatStyle = FlatStyle.Flat;
            btnAddDataSupplier.Font = new Font("MS Reference Sans Serif", 12.75F);
            btnAddDataSupplier.ForeColor = Color.White;
            btnAddDataSupplier.Location = new Point(8, 512);
            btnAddDataSupplier.Name = "btnAddDataSupplier";
            btnAddDataSupplier.Size = new Size(169, 40);
            btnAddDataSupplier.TabIndex = 26;
            btnAddDataSupplier.Text = "Add";
            btnAddDataSupplier.TextColor = Color.White;
            btnAddDataSupplier.UseVisualStyleBackColor = false;
            btnAddDataSupplier.Click += btnAddDataSupplier_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1120, 664);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company: Products & Suppliers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridViewProducts;
        private Button btnDeleteDataSupplier1;
        private Button btnAddDataSupplier1;
        private Button btnAlterDataSupplier1;
        private CustomButtons.CButton btnSwitchProdTab;
        private CustomButtons.CButton btnSwitchSupTab;
        private CustomButtons.CButton cButton5;
        private CustomButtons.CButton cButton4;
        private CustomButtons.CButton cButton6;
        private TextBox txtSearchProduct;
        private DataGridView dataGridViewSuppliers;
        private TextBox txtSearchSupplier;
        private CustomButtons.CButton btnDeleteDataSupplier;
        private CustomButtons.CButton btnAlterDataSupplier;
        private CustomButtons.CButton btnAddDataSupplier;
        private CustomButtons.CButton btnDeleteDataProduct;
        private CustomButtons.CButton btnAlterDataProduct;
        private CustomButtons.CButton btnAddDataProduct;
        private Label lblPageTitle;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel4;
        private PictureBox pictureBox3;
    }
}
