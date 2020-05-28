namespace Parcial02
{
    partial class AddressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress_Add = new System.Windows.Forms.TextBox();
            this.cmbUser_Add = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAddress_Update = new System.Windows.Forms.ComboBox();
            this.btnUpdateAddress = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUser_Update = new System.Windows.Forms.ComboBox();
            this.txtAddress_Update = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAddress_Delete = new System.Windows.Forms.ComboBox();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbChooseUser_Delete = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAddress_Add);
            this.groupBox1.Controls.Add(this.cmbUser_Add);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Direccion";
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(599, 150);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(178, 77);
            this.btnAddAddress.TabIndex = 4;
            this.btnAddAddress.Text = "Agregar";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // txtAddress_Add
            // 
            this.txtAddress_Add.Location = new System.Drawing.Point(177, 164);
            this.txtAddress_Add.Multiline = true;
            this.txtAddress_Add.Name = "txtAddress_Add";
            this.txtAddress_Add.Size = new System.Drawing.Size(320, 118);
            this.txtAddress_Add.TabIndex = 1;
            // 
            // cmbUser_Add
            // 
            this.cmbUser_Add.FormattingEnabled = true;
            this.cmbUser_Add.Location = new System.Drawing.Point(177, 66);
            this.cmbUser_Add.Name = "cmbUser_Add";
            this.cmbUser_Add.Size = new System.Drawing.Size(320, 33);
            this.cmbUser_Add.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbAddress_Update);
            this.groupBox2.Controls.Add(this.btnUpdateAddress);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbUser_Update);
            this.groupBox2.Controls.Add(this.txtAddress_Update);
            this.groupBox2.Location = new System.Drawing.Point(12, 464);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actualizar Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Direccion:";
            // 
            // cmbAddress_Update
            // 
            this.cmbAddress_Update.FormattingEnabled = true;
            this.cmbAddress_Update.Location = new System.Drawing.Point(177, 138);
            this.cmbAddress_Update.Name = "cmbAddress_Update";
            this.cmbAddress_Update.Size = new System.Drawing.Size(320, 33);
            this.cmbAddress_Update.TabIndex = 10;
            // 
            // btnUpdateAddress
            // 
            this.btnUpdateAddress.Location = new System.Drawing.Point(599, 86);
            this.btnUpdateAddress.Name = "btnUpdateAddress";
            this.btnUpdateAddress.Size = new System.Drawing.Size(178, 77);
            this.btnUpdateAddress.TabIndex = 9;
            this.btnUpdateAddress.Text = "Actualizar";
            this.btnUpdateAddress.UseVisualStyleBackColor = true;
            this.btnUpdateAddress.Click += new System.EventHandler(this.btnUpdateAddress_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Direccion Direccion:";
            // 
            // cmbUser_Update
            // 
            this.cmbUser_Update.FormattingEnabled = true;
            this.cmbUser_Update.Location = new System.Drawing.Point(177, 62);
            this.cmbUser_Update.Name = "cmbUser_Update";
            this.cmbUser_Update.Size = new System.Drawing.Size(320, 33);
            this.cmbUser_Update.TabIndex = 5;
            // 
            // txtAddress_Update
            // 
            this.txtAddress_Update.Location = new System.Drawing.Point(241, 195);
            this.txtAddress_Update.Multiline = true;
            this.txtAddress_Update.Name = "txtAddress_Update";
            this.txtAddress_Update.Size = new System.Drawing.Size(320, 118);
            this.txtAddress_Update.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmbAddress_Delete);
            this.groupBox3.Controls.Add(this.btnDeleteAddress);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbChooseUser_Delete);
            this.groupBox3.Location = new System.Drawing.Point(12, 848);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(838, 272);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Borrar Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Direccion:";
            // 
            // cmbAddress_Delete
            // 
            this.cmbAddress_Delete.FormattingEnabled = true;
            this.cmbAddress_Delete.Location = new System.Drawing.Point(210, 184);
            this.cmbAddress_Delete.Name = "cmbAddress_Delete";
            this.cmbAddress_Delete.Size = new System.Drawing.Size(320, 33);
            this.cmbAddress_Delete.TabIndex = 15;
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteAddress.Location = new System.Drawing.Point(582, 122);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(178, 77);
            this.btnDeleteAddress.TabIndex = 14;
            this.btnDeleteAddress.Text = "Eliminar";
            this.btnDeleteAddress.UseVisualStyleBackColor = true;
            this.btnDeleteAddress.Click += new System.EventHandler(this.btnDeleteAddress_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Usuario:";
            // 
            // cmbChooseUser_Delete
            // 
            this.cmbChooseUser_Delete.FormattingEnabled = true;
            this.cmbChooseUser_Delete.Location = new System.Drawing.Point(210, 105);
            this.cmbChooseUser_Delete.Name = "cmbChooseUser_Delete";
            this.cmbChooseUser_Delete.Size = new System.Drawing.Size(320, 33);
            this.cmbChooseUser_Delete.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(282, 61);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "REGRESAR";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(576, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(243, 75);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "ACTUALIZAR DATOS";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(881, 1123);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddressForm";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress_Add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdateAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUser_Update;
        private System.Windows.Forms.TextBox txtAddress_Update;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbChooseUser_Delete;
        private System.Windows.Forms.ComboBox cmbUser_Add;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAddress_Update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAddress_Delete;
    }
}