namespace UI
{
    partial class ProductEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            txtQtde = new TextBox();
            txtDescr = new TextBox();
            cmbBoxSuppliers = new ComboBox();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            btnUpdateProduct = new CustomButtons.CButton();
            txtName = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(txtQtde);
            panel1.Controls.Add(txtDescr);
            panel1.Controls.Add(cmbBoxSuppliers);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnUpdateProduct);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtPrice);
            panel1.Location = new Point(20, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 367);
            panel1.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkSeaGreen;
            panel6.Location = new Point(45, 272);
            panel6.Name = "panel6";
            panel6.Size = new Size(238, 1);
            panel6.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSeaGreen;
            panel5.Location = new Point(45, 225);
            panel5.Name = "panel5";
            panel5.Size = new Size(238, 1);
            panel5.TabIndex = 10;
            // 
            // txtQtde
            // 
            txtQtde.BorderStyle = BorderStyle.None;
            txtQtde.Cursor = Cursors.IBeam;
            txtQtde.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQtde.ForeColor = Color.FromArgb(64, 64, 64);
            txtQtde.Location = new Point(44, 199);
            txtQtde.Name = "txtQtde";
            txtQtde.PlaceholderText = "Quantity";
            txtQtde.Size = new Size(240, 20);
            txtQtde.TabIndex = 4;
            // 
            // txtDescr
            // 
            txtDescr.BorderStyle = BorderStyle.None;
            txtDescr.Cursor = Cursors.IBeam;
            txtDescr.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescr.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescr.Location = new Point(44, 92);
            txtDescr.Multiline = true;
            txtDescr.Name = "txtDescr";
            txtDescr.PlaceholderText = "Description";
            txtDescr.Size = new Size(240, 36);
            txtDescr.TabIndex = 2;
            // 
            // cmbBoxSuppliers
            // 
            cmbBoxSuppliers.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxSuppliers.FormattingEnabled = true;
            cmbBoxSuppliers.Location = new Point(44, 243);
            cmbBoxSuppliers.Name = "cmbBoxSuppliers";
            cmbBoxSuppliers.Size = new Size(238, 24);
            cmbBoxSuppliers.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSeaGreen;
            panel4.ForeColor = Color.DarkSeaGreen;
            panel4.Location = new Point(45, 134);
            panel4.Name = "panel4";
            panel4.Size = new Size(238, 1);
            panel4.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSeaGreen;
            panel3.Location = new Point(45, 179);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 1);
            panel3.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.ForeColor = Color.DarkSeaGreen;
            panel2.Location = new Point(44, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 1);
            panel2.TabIndex = 5;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.ForestGreen;
            btnUpdateProduct.BackgroundColor = Color.ForestGreen;
            btnUpdateProduct.BorderColor = Color.PaleVioletRed;
            btnUpdateProduct.BorderRadius = 0;
            btnUpdateProduct.BorderSize = 0;
            btnUpdateProduct.Cursor = Cursors.Hand;
            btnUpdateProduct.FlatAppearance.BorderSize = 0;
            btnUpdateProduct.FlatStyle = FlatStyle.Flat;
            btnUpdateProduct.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateProduct.ForeColor = Color.White;
            btnUpdateProduct.Location = new Point(42, 313);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(240, 40);
            btnUpdateProduct.TabIndex = 6;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.TextColor = Color.White;
            btnUpdateProduct.UseVisualStyleBackColor = false;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Cursor = Cursors.IBeam;
            txtName.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.FromArgb(64, 64, 64);
            txtName.Location = new Point(44, 45);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(240, 20);
            txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.None;
            txtPrice.Cursor = Cursors.IBeam;
            txtPrice.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.ForeColor = Color.FromArgb(64, 64, 64);
            txtPrice.Location = new Point(44, 153);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(240, 20);
            txtPrice.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(90, 13);
            label1.Name = "label1";
            label1.Size = new Size(190, 24);
            label1.TabIndex = 9;
            label1.Text = "Update a Product";
            // 
            // ProductEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 430);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ProductEditForm";
            Opacity = 0.99D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Updating...";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBoxSuppliers;
        private TextBox txtName;
        private TextBox txtDescr;
        private TextBox txtPrice;
        private TextBox txtQtde;
        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private TextBox txtQtde1;
        private TextBox txtDescr1;
        private ComboBox cmbBoxSuppliers1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private CustomButtons.CButton btnAddProduct1;
        private TextBox txtName1;
        private Label label1;
        private CustomButtons.CButton btnUpdateProduct;
    }
}