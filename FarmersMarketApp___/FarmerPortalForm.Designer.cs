namespace FarmersMarketApp___
{
    partial class FarmerPortalForm
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
            this.btnAddProduce = new System.Windows.Forms.Button();
            this.dataGridViewProduce = new System.Windows.Forms.DataGridView();
            this.txtProduceName = new System.Windows.Forms.TextBox();
            this.lblProduceName = new System.Windows.Forms.Label();
            this.lblProduceCategory = new System.Windows.Forms.Label();
            this.lblProducePrice = new System.Windows.Forms.Label();
            this.lblProduceQuantity = new System.Windows.Forms.Label();
            this.lblProduceUnit = new System.Windows.Forms.Label();
            this.txtProduceCategory = new System.Windows.Forms.TextBox();
            this.txtProducePrice = new System.Windows.Forms.TextBox();
            this.txtProduceQuantity = new System.Windows.Forms.TextBox();
            this.txtProduceUnit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduce)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduce
            // 
            this.btnAddProduce.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddProduce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduce.Location = new System.Drawing.Point(197, 710);
            this.btnAddProduce.Name = "btnAddProduce";
            this.btnAddProduce.Size = new System.Drawing.Size(262, 57);
            this.btnAddProduce.TabIndex = 0;
            this.btnAddProduce.Text = "Add Produce";
            this.btnAddProduce.UseVisualStyleBackColor = false;
            this.btnAddProduce.Click += new System.EventHandler(this.btnAddProduce_Click);
            // 
            // dataGridViewProduce
            // 
            this.dataGridViewProduce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduce.Location = new System.Drawing.Point(477, 12);
            this.dataGridViewProduce.Name = "dataGridViewProduce";
            this.dataGridViewProduce.RowHeadersWidth = 62;
            this.dataGridViewProduce.RowTemplate.Height = 28;
            this.dataGridViewProduce.Size = new System.Drawing.Size(1074, 811);
            this.dataGridViewProduce.TabIndex = 1;
            this.dataGridViewProduce.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduce_CellContentClick);
            // 
            // txtProduceName
            // 
            this.txtProduceName.Location = new System.Drawing.Point(207, 63);
            this.txtProduceName.Name = "txtProduceName";
            this.txtProduceName.Size = new System.Drawing.Size(152, 26);
            this.txtProduceName.TabIndex = 2;
            // 
            // lblProduceName
            // 
            this.lblProduceName.AutoSize = true;
            this.lblProduceName.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblProduceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduceName.Location = new System.Drawing.Point(317, 35);
            this.lblProduceName.Name = "lblProduceName";
            this.lblProduceName.Size = new System.Drawing.Size(154, 25);
            this.lblProduceName.TabIndex = 3;
            this.lblProduceName.Text = "Produce Name";
            // 
            // lblProduceCategory
            // 
            this.lblProduceCategory.AutoSize = true;
            this.lblProduceCategory.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblProduceCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduceCategory.Location = new System.Drawing.Point(278, 153);
            this.lblProduceCategory.Name = "lblProduceCategory";
            this.lblProduceCategory.Size = new System.Drawing.Size(193, 25);
            this.lblProduceCategory.TabIndex = 4;
            this.lblProduceCategory.Text = "Produce Categrory";
            this.lblProduceCategory.Click += new System.EventHandler(this.lblProduceCategory_Click);
            // 
            // lblProducePrice
            // 
            this.lblProducePrice.AutoSize = true;
            this.lblProducePrice.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblProducePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducePrice.Location = new System.Drawing.Point(324, 273);
            this.lblProducePrice.Name = "lblProducePrice";
            this.lblProducePrice.Size = new System.Drawing.Size(147, 25);
            this.lblProducePrice.TabIndex = 5;
            this.lblProducePrice.Text = "Produce Price";
            // 
            // lblProduceQuantity
            // 
            this.lblProduceQuantity.AutoSize = true;
            this.lblProduceQuantity.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblProduceQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduceQuantity.Location = new System.Drawing.Point(292, 399);
            this.lblProduceQuantity.Name = "lblProduceQuantity";
            this.lblProduceQuantity.Size = new System.Drawing.Size(179, 25);
            this.lblProduceQuantity.TabIndex = 6;
            this.lblProduceQuantity.Text = "Produce Quantity";
            // 
            // lblProduceUnit
            // 
            this.lblProduceUnit.AutoSize = true;
            this.lblProduceUnit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblProduceUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduceUnit.Location = new System.Drawing.Point(307, 524);
            this.lblProduceUnit.Name = "lblProduceUnit";
            this.lblProduceUnit.Size = new System.Drawing.Size(164, 29);
            this.lblProduceUnit.TabIndex = 7;
            this.lblProduceUnit.Text = "Produce Unit";
            // 
            // txtProduceCategory
            // 
            this.txtProduceCategory.Location = new System.Drawing.Point(207, 191);
            this.txtProduceCategory.Name = "txtProduceCategory";
            this.txtProduceCategory.Size = new System.Drawing.Size(186, 26);
            this.txtProduceCategory.TabIndex = 8;
            // 
            // txtProducePrice
            // 
            this.txtProducePrice.Location = new System.Drawing.Point(219, 301);
            this.txtProducePrice.Name = "txtProducePrice";
            this.txtProducePrice.Size = new System.Drawing.Size(151, 26);
            this.txtProducePrice.TabIndex = 9;
            // 
            // txtProduceQuantity
            // 
            this.txtProduceQuantity.Location = new System.Drawing.Point(219, 427);
            this.txtProduceQuantity.Name = "txtProduceQuantity";
            this.txtProduceQuantity.Size = new System.Drawing.Size(183, 26);
            this.txtProduceQuantity.TabIndex = 10;
            // 
            // txtProduceUnit
            // 
            this.txtProduceUnit.Location = new System.Drawing.Point(219, 556);
            this.txtProduceUnit.Name = "txtProduceUnit";
            this.txtProduceUnit.Size = new System.Drawing.Size(164, 26);
            this.txtProduceUnit.TabIndex = 11;
            // 
            // FarmerPortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmersMarketApp___.Properties.Resources.Famers_Market_Produce;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1685, 901);
            this.Controls.Add(this.txtProduceUnit);
            this.Controls.Add(this.txtProduceQuantity);
            this.Controls.Add(this.txtProducePrice);
            this.Controls.Add(this.txtProduceCategory);
            this.Controls.Add(this.lblProduceUnit);
            this.Controls.Add(this.lblProduceQuantity);
            this.Controls.Add(this.lblProducePrice);
            this.Controls.Add(this.lblProduceCategory);
            this.Controls.Add(this.lblProduceName);
            this.Controls.Add(this.txtProduceName);
            this.Controls.Add(this.dataGridViewProduce);
            this.Controls.Add(this.btnAddProduce);
            this.Name = "FarmerPortalForm";
            this.Text = "FarmerPortalForm";
            this.Load += new System.EventHandler(this.FarmerPortalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduce;
        private System.Windows.Forms.DataGridView dataGridViewProduce;
        private System.Windows.Forms.TextBox txtProduceName;
        private System.Windows.Forms.Label lblProduceName;
        private System.Windows.Forms.Label lblProduceCategory;
        private System.Windows.Forms.Label lblProducePrice;
        private System.Windows.Forms.Label lblProduceQuantity;
        private System.Windows.Forms.Label lblProduceUnit;
        private System.Windows.Forms.TextBox txtProduceCategory;
        private System.Windows.Forms.TextBox txtProducePrice;
        private System.Windows.Forms.TextBox txtProduceQuantity;
        private System.Windows.Forms.TextBox txtProduceUnit;
    }
}