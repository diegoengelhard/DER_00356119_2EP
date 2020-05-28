namespace Parcial02
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnAddress = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(289, 781);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Historial de Ordenes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(522, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pedir Orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(157, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Direcciones";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button3.BackgroundImage = global::Parcial02.Properties.Resources.pngwing;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(294, 537);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 202);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOrder.BackgroundImage = global::Parcial02.Properties.Resources.dinner;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrder.Location = new System.Drawing.Point(494, 223);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(215, 202);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnAddress
            // 
            this.btnAddress.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddress.BackgroundImage = global::Parcial02.Properties.Resources.GEOTRANS_1_;
            this.btnAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddress.Location = new System.Drawing.Point(115, 223);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(215, 202);
            this.btnAddress.TabIndex = 9;
            this.btnAddress.UseVisualStyleBackColor = false;
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(288, 918);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(236, 58);
            this.btnSignOut.TabIndex = 15;
            this.btnSignOut.Text = "Cerrar Sesion";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 1032);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Button btnSignOut;
    }
}