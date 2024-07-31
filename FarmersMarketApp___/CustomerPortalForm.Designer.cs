namespace FarmersMarketApp___
{
    partial class CustomerPortalForm
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
            this.dataGridViewBasket = new System.Windows.Forms.DataGridView();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridViewProduce = new System.Windows.Forms.DataGridView();
            this.btnRemoveFromBasket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduce)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBasket
            // 
            this.dataGridViewBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBasket.Location = new System.Drawing.Point(926, 53);
            this.dataGridViewBasket.Name = "dataGridViewBasket";
            this.dataGridViewBasket.RowHeadersWidth = 62;
            this.dataGridViewBasket.RowTemplate.Height = 28;
            this.dataGridViewBasket.Size = new System.Drawing.Size(796, 808);
            this.dataGridViewBasket.TabIndex = 0;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(774, 904);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(166, 40);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(936, 730);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(109, 29);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Subtotal";
            this.lblSubtotal.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddToBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToBasket.Location = new System.Drawing.Point(41, 876);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(270, 45);
            this.btnAddToBasket.TabIndex = 4;
            this.btnAddToBasket.Text = "Add To Basket";
            this.btnAddToBasket.UseVisualStyleBackColor = false;
            this.btnAddToBasket.Click += new System.EventHandler(this.btnAddToBasket_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(936, 775);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 29);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            // 
            // dataGridViewProduce
            // 
            this.dataGridViewProduce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduce.Location = new System.Drawing.Point(41, 53);
            this.dataGridViewProduce.Name = "dataGridViewProduce";
            this.dataGridViewProduce.RowHeadersWidth = 62;
            this.dataGridViewProduce.RowTemplate.Height = 28;
            this.dataGridViewProduce.Size = new System.Drawing.Size(831, 797);
            this.dataGridViewProduce.TabIndex = 6;
            // 
            // btnRemoveFromBasket
            // 
            this.btnRemoveFromBasket.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRemoveFromBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromBasket.Location = new System.Drawing.Point(1344, 881);
            this.btnRemoveFromBasket.Name = "btnRemoveFromBasket";
            this.btnRemoveFromBasket.Size = new System.Drawing.Size(313, 40);
            this.btnRemoveFromBasket.TabIndex = 7;
            this.btnRemoveFromBasket.Text = "Remove From Basket";
            this.btnRemoveFromBasket.UseVisualStyleBackColor = false;
            this.btnRemoveFromBasket.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CustomerPortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmersMarketApp___.Properties.Resources.Famers_Market_Veggies;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1734, 1149);
            this.Controls.Add(this.btnRemoveFromBasket);
            this.Controls.Add(this.dataGridViewProduce);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAddToBasket);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.dataGridViewBasket);
            this.Name = "CustomerPortalForm";
            this.Text = "CustomerPortalForm";
            this.Load += new System.EventHandler(this.CustomerPortalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBasket;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnAddToBasket;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGridViewProduce;
        private System.Windows.Forms.Button btnRemoveFromBasket;
    }
}