namespace UI
{
    partial class SupplierEditForm
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
            btnUpdate = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            btnAddSupplier = new CustomButtons.CButton();
            panel1 = new Panel();
            panel4 = new Panel();
            txtName = new TextBox();
            txtCnpj = new MaskedTextBox();
            txtMail = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(111, 190);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Atualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(87, 15);
            label1.Name = "label1";
            label1.Size = new Size(199, 24);
            label1.TabIndex = 5;
            label1.Text = "Update a Supplier";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSeaGreen;
            panel3.Location = new Point(45, 216);
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
            // btnAddSupplier
            // 
            btnAddSupplier.BackColor = Color.ForestGreen;
            btnAddSupplier.BackgroundColor = Color.ForestGreen;
            btnAddSupplier.BorderColor = Color.PaleVioletRed;
            btnAddSupplier.BorderRadius = 0;
            btnAddSupplier.BorderSize = 0;
            btnAddSupplier.Cursor = Cursors.Hand;
            btnAddSupplier.FlatAppearance.BorderSize = 0;
            btnAddSupplier.FlatStyle = FlatStyle.Flat;
            btnAddSupplier.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddSupplier.ForeColor = Color.White;
            btnAddSupplier.Location = new Point(46, 269);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(240, 40);
            btnAddSupplier.TabIndex = 4;
            btnAddSupplier.Text = "Update";
            btnAddSupplier.TextColor = Color.White;
            btnAddSupplier.UseVisualStyleBackColor = false;
            btnAddSupplier.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnAddSupplier);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtCnpj);
            panel1.Controls.Add(txtMail);
            panel1.Location = new Point(21, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 330);
            panel1.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSeaGreen;
            panel4.ForeColor = Color.DarkSeaGreen;
            panel4.Location = new Point(45, 139);
            panel4.Name = "panel4";
            panel4.Size = new Size(238, 1);
            panel4.TabIndex = 7;
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
            // txtCnpj
            // 
            txtCnpj.BorderStyle = BorderStyle.None;
            txtCnpj.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCnpj.ForeColor = Color.FromArgb(64, 64, 64);
            txtCnpj.Location = new Point(46, 117);
            txtCnpj.Mask = "00,000,000/0000-00";
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(240, 20);
            txtCnpj.TabIndex = 2;
            // 
            // txtMail
            // 
            txtMail.BorderStyle = BorderStyle.None;
            txtMail.Cursor = Cursors.IBeam;
            txtMail.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMail.ForeColor = Color.FromArgb(64, 64, 64);
            txtMail.Location = new Point(44, 190);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Mail";
            txtMail.Size = new Size(240, 20);
            txtMail.TabIndex = 3;
            // 
            // SupplierEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(367, 399);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SupplierEditForm";
            Opacity = 0.99D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Updating...";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUpdate;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private CustomButtons.CButton btnAddSupplier;
        private Panel panel1;
        private Panel panel4;
        private TextBox txtName;
        private MaskedTextBox txtCnpj;
        private TextBox txtMail;
    }
}