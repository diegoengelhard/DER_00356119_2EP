namespace Parcial02
{
    partial class ProductMaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductMaintenanceForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.cmbBussiness = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDeleteProduct = new System.Windows.Forms.ComboBox();
            this.cmbDeleteProduct_Bussiness = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProduct);
            this.groupBox1.Controls.Add(this.cmbBussiness);
            this.groupBox1.Location = new System.Drawing.Point(0, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Producto";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(623, 120);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(174, 69);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Agregar";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agregar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Negocio:";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(172, 187);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(409, 31);
            this.txtProduct.TabIndex = 1;
            // 
            // cmbBussiness
            // 
            this.cmbBussiness.FormattingEnabled = true;
            this.cmbBussiness.Location = new System.Drawing.Point(172, 95);
            this.cmbBussiness.Name = "cmbBussiness";
            this.cmbBussiness.Size = new System.Drawing.Size(409, 33);
            this.cmbBussiness.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbDeleteProduct_Bussiness);
            this.groupBox2.Controls.Add(this.cmbDeleteProduct);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(12, 610);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(812, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Producto:";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(611, 137);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 69);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(30, 55);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(253, 61);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "REGRESAR";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Negocio:";
            // 
            // cmbDeleteProduct
            // 
            this.cmbDeleteProduct.FormattingEnabled = true;
            this.cmbDeleteProduct.Location = new System.Drawing.Point(173, 188);
            this.cmbDeleteProduct.Name = "cmbDeleteProduct";
            this.cmbDeleteProduct.Size = new System.Drawing.Size(409, 33);
            this.cmbDeleteProduct.TabIndex = 7;
            // 
            // cmbDeleteProduct_Bussiness
            // 
            this.cmbDeleteProduct_Bussiness.FormattingEnabled = true;
            this.cmbDeleteProduct_Bussiness.Location = new System.Drawing.Point(173, 124);
            this.cmbDeleteProduct_Bussiness.Name = "cmbDeleteProduct_Bussiness";
            this.cmbDeleteProduct_Bussiness.Size = new System.Drawing.Size(409, 33);
            this.cmbDeleteProduct_Bussiness.TabIndex = 6;
            // 
            // ProductMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(824, 1032);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProductMaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugo App";
            this.Load += new System.EventHandler(this.ProductMaintenanceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.ComboBox cmbBussiness;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDeleteProduct_Bussiness;
        private System.Windows.Forms.ComboBox cmbDeleteProduct;
    }
}