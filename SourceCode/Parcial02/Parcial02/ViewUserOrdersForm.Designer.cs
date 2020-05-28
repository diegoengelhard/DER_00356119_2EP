namespace Parcial02
{
    partial class ViewUserOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUserOrdersForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(864, 656);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(712, 118);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(189, 70);
            this.btnViewOrders.TabIndex = 32;
            this.btnViewOrders.Text = "Ver Ordenes";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // cmbUser
            // 
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(270, 138);
            this.cmbUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(423, 33);
            this.cmbUser.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(32, 141);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(271, 58);
            this.label20.TabIndex = 30;
            this.label20.Text = "Seleccione un usuario:";
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(25, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(278, 61);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "REGRESAR";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewUserOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(937, 964);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewUserOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugo App";
            this.Load += new System.EventHandler(this.ViewUserOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnBack;
    }
}