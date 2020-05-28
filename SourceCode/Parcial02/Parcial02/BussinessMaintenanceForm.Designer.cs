namespace Parcial02
{
    partial class BussinessMaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BussinessMaintenanceForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddBussiness = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteBussiness = new System.Windows.Forms.Button();
            this.cmbBussiness = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddBussiness);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Negocio";
            // 
            // btnAddBussiness
            // 
            this.btnAddBussiness.Location = new System.Drawing.Point(675, 137);
            this.btnAddBussiness.Name = "btnAddBussiness";
            this.btnAddBussiness.Size = new System.Drawing.Size(178, 70);
            this.btnAddBussiness.TabIndex = 6;
            this.btnAddBussiness.Text = "Agregar";
            this.btnAddBussiness.UseVisualStyleBackColor = true;
            this.btnAddBussiness.Click += new System.EventHandler(this.btnAddBussiness_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(201, 186);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(431, 135);
            this.txtDescription.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(201, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(431, 31);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteBussiness);
            this.groupBox2.Controls.Add(this.cmbBussiness);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(2, 548);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 280);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Negocio";
            // 
            // btnDeleteBussiness
            // 
            this.btnDeleteBussiness.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteBussiness.Location = new System.Drawing.Point(675, 136);
            this.btnDeleteBussiness.Name = "btnDeleteBussiness";
            this.btnDeleteBussiness.Size = new System.Drawing.Size(178, 70);
            this.btnDeleteBussiness.TabIndex = 5;
            this.btnDeleteBussiness.Text = "Eliminar";
            this.btnDeleteBussiness.UseVisualStyleBackColor = true;
            this.btnDeleteBussiness.Click += new System.EventHandler(this.btnDeleteBussiness_Click);
            // 
            // cmbBussiness
            // 
            this.cmbBussiness.FormattingEnabled = true;
            this.cmbBussiness.Location = new System.Drawing.Point(201, 151);
            this.cmbBussiness.Name = "cmbBussiness";
            this.cmbBussiness.Size = new System.Drawing.Size(414, 33);
            this.cmbBussiness.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Negocio:";
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 52);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(260, 61);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "REGRESAR";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BussinessMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(882, 970);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BussinessMaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugo App";
            this.Load += new System.EventHandler(this.BussinessMaintenanceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddBussiness;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteBussiness;
        private System.Windows.Forms.ComboBox cmbBussiness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}