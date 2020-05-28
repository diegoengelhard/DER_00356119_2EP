namespace Parcial02
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChooseProduct = new System.Windows.Forms.ComboBox();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.btnAddOrder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbChooseProduct);
            this.groupBox1.Controls.Add(this.cmbAddress);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(26, 137);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(747, 459);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Nuevo Pedido";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 58);
            this.label4.TabIndex = 35;
            this.label4.Text = "Seleccione Fecha:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(298, 244);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(426, 31);
            this.dtpDate.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 58);
            this.label3.TabIndex = 31;
            this.label3.Text = "Seleccione Producto:";
            // 
            // cmbChooseProduct
            // 
            this.cmbChooseProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChooseProduct.FormattingEnabled = true;
            this.cmbChooseProduct.Location = new System.Drawing.Point(295, 170);
            this.cmbChooseProduct.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbChooseProduct.Name = "cmbChooseProduct";
            this.cmbChooseProduct.Size = new System.Drawing.Size(423, 33);
            this.cmbChooseProduct.TabIndex = 27;
            // 
            // cmbAddress
            // 
            this.cmbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Location = new System.Drawing.Point(298, 84);
            this.cmbAddress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(423, 33);
            this.cmbAddress.TabIndex = 26;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(14, 91);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(271, 58);
            this.label19.TabIndex = 25;
            this.label19.Text = "Seleccione Direccion:";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteOrder.Location = new System.Drawing.Point(301, 176);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(304, 70);
            this.btnDeleteOrder.TabIndex = 19;
            this.btnDeleteOrder.Text = "Eliminar Orden";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(18, 182);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 58);
            this.label17.TabIndex = 16;
            this.label17.Text = "Producto:";
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(26, 44);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(264, 61);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "REGRESAR";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnDeleteOrder);
            this.groupBox2.Location = new System.Drawing.Point(26, 659);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 288);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Orden";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 58);
            this.label5.TabIndex = 31;
            this.label5.Text = "Digite ID de Orden:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 31);
            this.textBox1.TabIndex = 32;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.ForeColor = System.Drawing.Color.Black;
            this.btnAddOrder.Location = new System.Drawing.Point(331, 326);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(304, 70);
            this.btnAddOrder.TabIndex = 33;
            this.btnAddOrder.Text = "Agregar Orden";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click_1);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(801, 1066);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbChooseProduct;
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddOrder;
    }
}