namespace Parcial02
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnProductMaintenance = new System.Windows.Forms.Button();
            this.btnBussinessMaintenance = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.btnUserMaintenance = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(71, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mantenimiento de Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(517, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ver Usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(71, 681);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mantenimiento de Negocios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(441, 681);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mantenimiento de Productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(145, 964);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ver Ordenes";
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.MediumPurple;
            this.btnViewOrders.BackgroundImage = global::Parcial02.Properties.Resources.pngwing;
            this.btnViewOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewOrders.Location = new System.Drawing.Point(110, 741);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(215, 202);
            this.btnViewOrders.TabIndex = 4;
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnProductMaintenance
            // 
            this.btnProductMaintenance.BackColor = System.Drawing.Color.Khaki;
            this.btnProductMaintenance.BackgroundImage = global::Parcial02.Properties.Resources.dinner;
            this.btnProductMaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProductMaintenance.Location = new System.Drawing.Point(489, 456);
            this.btnProductMaintenance.Name = "btnProductMaintenance";
            this.btnProductMaintenance.Size = new System.Drawing.Size(215, 202);
            this.btnProductMaintenance.TabIndex = 3;
            this.btnProductMaintenance.UseVisualStyleBackColor = false;
            this.btnProductMaintenance.Click += new System.EventHandler(this.btnProductMaintenance_Click);
            // 
            // btnBussinessMaintenance
            // 
            this.btnBussinessMaintenance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnBussinessMaintenance.BackgroundImage = global::Parcial02.Properties.Resources.bussinessPNG;
            this.btnBussinessMaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBussinessMaintenance.Location = new System.Drawing.Point(110, 456);
            this.btnBussinessMaintenance.Name = "btnBussinessMaintenance";
            this.btnBussinessMaintenance.Size = new System.Drawing.Size(215, 202);
            this.btnBussinessMaintenance.TabIndex = 2;
            this.btnBussinessMaintenance.UseVisualStyleBackColor = false;
            this.btnBussinessMaintenance.Click += new System.EventHandler(this.btnBussinessMaintenance_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnViewUsers.BackgroundImage = global::Parcial02.Properties.Resources.black_and_white_panda_logo_users_group_encapsulated_postscript_user_profile_group_png_clip_art_1_;
            this.btnViewUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewUsers.Location = new System.Drawing.Point(489, 162);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(215, 202);
            this.btnViewUsers.TabIndex = 1;
            this.btnViewUsers.UseVisualStyleBackColor = false;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // btnUserMaintenance
            // 
            this.btnUserMaintenance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUserMaintenance.BackgroundImage = global::Parcial02.Properties.Resources.iconfinder_user_alt_285645;
            this.btnUserMaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUserMaintenance.Location = new System.Drawing.Point(110, 162);
            this.btnUserMaintenance.Name = "btnUserMaintenance";
            this.btnUserMaintenance.Size = new System.Drawing.Size(215, 202);
            this.btnUserMaintenance.TabIndex = 0;
            this.btnUserMaintenance.UseVisualStyleBackColor = false;
            this.btnUserMaintenance.Click += new System.EventHandler(this.btnUserMaintenance_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(468, 835);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(236, 58);
            this.btnSignOut.TabIndex = 16;
            this.btnSignOut.Text = "Cerrar Sesion";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(824, 1032);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnProductMaintenance);
            this.Controls.Add(this.btnBussinessMaintenance);
            this.Controls.Add(this.btnViewUsers);
            this.Controls.Add(this.btnUserMaintenance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugo App";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserMaintenance;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.Button btnBussinessMaintenance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProductMaintenance;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSignOut;
    }
}