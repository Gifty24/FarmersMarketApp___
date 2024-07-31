namespace FarmersMarketApp___
{
    partial class MainForm
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
            this.btnCustomerPortal = new System.Windows.Forms.Button();
            this.btnFarmerRegistration = new System.Windows.Forms.Button();
            this.btnFarmerLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerPortal
            // 
            this.btnCustomerPortal.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCustomerPortal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerPortal.Location = new System.Drawing.Point(360, 411);
            this.btnCustomerPortal.Name = "btnCustomerPortal";
            this.btnCustomerPortal.Size = new System.Drawing.Size(228, 70);
            this.btnCustomerPortal.TabIndex = 0;
            this.btnCustomerPortal.Text = "Customer Portal";
            this.btnCustomerPortal.UseVisualStyleBackColor = false;
            this.btnCustomerPortal.Click += new System.EventHandler(this.btnCustomerPortal_Click);
            // 
            // btnFarmerRegistration
            // 
            this.btnFarmerRegistration.BackColor = System.Drawing.Color.Goldenrod;
            this.btnFarmerRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFarmerRegistration.Location = new System.Drawing.Point(799, 411);
            this.btnFarmerRegistration.Name = "btnFarmerRegistration";
            this.btnFarmerRegistration.Size = new System.Drawing.Size(272, 70);
            this.btnFarmerRegistration.TabIndex = 3;
            this.btnFarmerRegistration.Text = "Farmer Registration";
            this.btnFarmerRegistration.UseVisualStyleBackColor = false;
            this.btnFarmerRegistration.Click += new System.EventHandler(this.btnFarmerRegistration_Click);
            // 
            // btnFarmerLogin
            // 
            this.btnFarmerLogin.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFarmerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFarmerLogin.Location = new System.Drawing.Point(1335, 411);
            this.btnFarmerLogin.Name = "btnFarmerLogin";
            this.btnFarmerLogin.Size = new System.Drawing.Size(195, 70);
            this.btnFarmerLogin.TabIndex = 4;
            this.btnFarmerLogin.Text = "Farmer Login";
            this.btnFarmerLogin.UseVisualStyleBackColor = false;
            this.btnFarmerLogin.Click += new System.EventHandler(this.btnFarmerLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmersMarketApp___.Properties.Resources.Farmers_Market_Fruits_and_Produce_sign;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1840, 940);
            this.Controls.Add(this.btnFarmerLogin);
            this.Controls.Add(this.btnFarmerRegistration);
            this.Controls.Add(this.btnCustomerPortal);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerPortal;
        private System.Windows.Forms.Button btnFarmerRegistration;
        private System.Windows.Forms.Button btnFarmerLogin;
    }
}