namespace UI.Product_Forms
{
    partial class ProductDeleteForm
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
            btnAccept = new CustomButtons.CButton();
            btnCancel = new CustomButtons.CButton();
            txtTitle = new TextBox();
            SuspendLayout();
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.ForestGreen;
            btnAccept.BackgroundColor = Color.ForestGreen;
            btnAccept.BorderColor = Color.PaleVioletRed;
            btnAccept.BorderRadius = 0;
            btnAccept.BorderSize = 0;
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(67, 113);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(106, 40);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Yes";
            btnAccept.TextColor = Color.White;
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.BackgroundColor = Color.Firebrick;
            btnCancel.BorderColor = Color.PaleVioletRed;
            btnCancel.BorderRadius = 0;
            btnCancel.BorderSize = 0;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(179, 113);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 40);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "No";
            btnCancel.TextColor = Color.White;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(37, 36);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(275, 71);
            txtTitle.TabIndex = 3;
            // 
            // ProductDeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 165);
            Controls.Add(txtTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ProductDeleteForm";
            Opacity = 0.99D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deleting...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomButtons.CButton btnAccept;
        private CustomButtons.CButton btnCancel;
        private TextBox txtTitle;
    }
}