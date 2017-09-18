namespace SqlDBClass
{
    partial class adminProducts
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
            this.updateProductGroup = new System.Windows.Forms.GroupBox();
            this.searchId = new System.Windows.Forms.TextBox();
            this.uProductNum = new System.Windows.Forms.TextBox();
            this.ProNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uQuantity = new System.Windows.Forms.TextBox();
            this.proQun = new System.Windows.Forms.Label();
            this.uProductPrice = new System.Windows.Forms.TextBox();
            this.uProductName = new System.Windows.Forms.TextBox();
            this.uProPrice = new System.Windows.Forms.Label();
            this.uProName = new System.Windows.Forms.Label();
            this.updateProduct = new System.Windows.Forms.Button();
            this.productList = new System.Windows.Forms.DataGridView();
            this.addProNumber = new System.Windows.Forms.TextBox();
            this.addQuantity = new System.Windows.Forms.TextBox();
            this.addProductPrice = new System.Windows.Forms.TextBox();
            this.addProductName = new System.Windows.Forms.TextBox();
            this.aProNum = new System.Windows.Forms.Label();
            this.aQuantity = new System.Windows.Forms.Label();
            this.aProPrice = new System.Windows.Forms.Label();
            this.aProName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addProductsGroup = new System.Windows.Forms.GroupBox();
            this.addProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.removeProNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.removeProductName = new System.Windows.Forms.TextBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.removeProductsGroup = new System.Windows.Forms.GroupBox();
            this.addingBtm = new System.Windows.Forms.Button();
            this.removingBtn = new System.Windows.Forms.Button();
            this.updatingBtn = new System.Windows.Forms.Button();
            this.updateProductGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            this.addProductsGroup.SuspendLayout();
            this.removeProductsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateProductGroup
            // 
            this.updateProductGroup.Controls.Add(this.searchId);
            this.updateProductGroup.Controls.Add(this.uProductNum);
            this.updateProductGroup.Controls.Add(this.ProNumber);
            this.updateProductGroup.Controls.Add(this.label6);
            this.updateProductGroup.Controls.Add(this.uQuantity);
            this.updateProductGroup.Controls.Add(this.proQun);
            this.updateProductGroup.Controls.Add(this.uProductPrice);
            this.updateProductGroup.Controls.Add(this.uProductName);
            this.updateProductGroup.Controls.Add(this.uProPrice);
            this.updateProductGroup.Controls.Add(this.uProName);
            this.updateProductGroup.Location = new System.Drawing.Point(20, 9);
            this.updateProductGroup.Name = "updateProductGroup";
            this.updateProductGroup.Size = new System.Drawing.Size(235, 241);
            this.updateProductGroup.TabIndex = 24;
            this.updateProductGroup.TabStop = false;
            this.updateProductGroup.Text = "Update Products";
            this.updateProductGroup.Visible = false;
            this.updateProductGroup.Enter += new System.EventHandler(this.updateProductGroup_Enter);
            // 
            // searchId
            // 
            this.searchId.Location = new System.Drawing.Point(66, 57);
            this.searchId.Name = "searchId";
            this.searchId.Size = new System.Drawing.Size(100, 20);
            this.searchId.TabIndex = 0;
            // 
            // uProductNum
            // 
            this.uProductNum.Location = new System.Drawing.Point(114, 83);
            this.uProductNum.Name = "uProductNum";
            this.uProductNum.Size = new System.Drawing.Size(100, 20);
            this.uProductNum.TabIndex = 1;
            // 
            // ProNumber
            // 
            this.ProNumber.Location = new System.Drawing.Point(18, 83);
            this.ProNumber.Name = "ProNumber";
            this.ProNumber.Size = new System.Drawing.Size(84, 23);
            this.ProNumber.TabIndex = 25;
            this.ProNumber.Text = "Product Number";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 49);
            this.label6.TabIndex = 24;
            this.label6.Text = "Enter product number for the item you would like to update";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uQuantity
            // 
            this.uQuantity.Location = new System.Drawing.Point(114, 161);
            this.uQuantity.Name = "uQuantity";
            this.uQuantity.Size = new System.Drawing.Size(100, 20);
            this.uQuantity.TabIndex = 4;
            // 
            // proQun
            // 
            this.proQun.Location = new System.Drawing.Point(18, 161);
            this.proQun.Name = "proQun";
            this.proQun.Size = new System.Drawing.Size(84, 23);
            this.proQun.TabIndex = 5;
            this.proQun.Text = "Update Quantity";
            // 
            // uProductPrice
            // 
            this.uProductPrice.Location = new System.Drawing.Point(114, 135);
            this.uProductPrice.Name = "uProductPrice";
            this.uProductPrice.Size = new System.Drawing.Size(100, 20);
            this.uProductPrice.TabIndex = 3;
            // 
            // uProductName
            // 
            this.uProductName.Location = new System.Drawing.Point(114, 109);
            this.uProductName.Name = "uProductName";
            this.uProductName.Size = new System.Drawing.Size(100, 20);
            this.uProductName.TabIndex = 2;
            // 
            // uProPrice
            // 
            this.uProPrice.Location = new System.Drawing.Point(18, 138);
            this.uProPrice.Name = "uProPrice";
            this.uProPrice.Size = new System.Drawing.Size(84, 23);
            this.uProPrice.TabIndex = 1;
            this.uProPrice.Text = "Product Price";
            // 
            // uProName
            // 
            this.uProName.Location = new System.Drawing.Point(18, 112);
            this.uProName.Name = "uProName";
            this.uProName.Size = new System.Drawing.Size(84, 23);
            this.uProName.TabIndex = 0;
            this.uProName.Text = "Product Name";
            // 
            // updateProduct
            // 
            this.updateProduct.Location = new System.Drawing.Point(179, 256);
            this.updateProduct.Name = "updateProduct";
            this.updateProduct.Size = new System.Drawing.Size(76, 40);
            this.updateProduct.TabIndex = 25;
            this.updateProduct.Text = "Update Product";
            this.updateProduct.UseVisualStyleBackColor = true;
            this.updateProduct.Click += new System.EventHandler(this.updateProduct_Click);
            // 
            // productList
            // 
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.Location = new System.Drawing.Point(266, 12);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(451, 284);
            this.productList.TabIndex = 26;
            this.productList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productList_CellClick);
            // 
            // addProNumber
            // 
            this.addProNumber.Location = new System.Drawing.Point(108, 65);
            this.addProNumber.Name = "addProNumber";
            this.addProNumber.Size = new System.Drawing.Size(100, 20);
            this.addProNumber.TabIndex = 0;
            // 
            // addQuantity
            // 
            this.addQuantity.Location = new System.Drawing.Point(108, 143);
            this.addQuantity.Name = "addQuantity";
            this.addQuantity.Size = new System.Drawing.Size(100, 20);
            this.addQuantity.TabIndex = 3;
            // 
            // addProductPrice
            // 
            this.addProductPrice.Location = new System.Drawing.Point(108, 117);
            this.addProductPrice.Name = "addProductPrice";
            this.addProductPrice.Size = new System.Drawing.Size(100, 20);
            this.addProductPrice.TabIndex = 2;
            // 
            // addProductName
            // 
            this.addProductName.Location = new System.Drawing.Point(108, 91);
            this.addProductName.Name = "addProductName";
            this.addProductName.Size = new System.Drawing.Size(100, 20);
            this.addProductName.TabIndex = 1;
            // 
            // aProNum
            // 
            this.aProNum.Location = new System.Drawing.Point(6, 65);
            this.aProNum.Name = "aProNum";
            this.aProNum.Size = new System.Drawing.Size(84, 23);
            this.aProNum.TabIndex = 31;
            this.aProNum.Text = "Product Number";
            // 
            // aQuantity
            // 
            this.aQuantity.Location = new System.Drawing.Point(6, 143);
            this.aQuantity.Name = "aQuantity";
            this.aQuantity.Size = new System.Drawing.Size(84, 23);
            this.aQuantity.TabIndex = 30;
            this.aQuantity.Text = "Quantity";
            // 
            // aProPrice
            // 
            this.aProPrice.Location = new System.Drawing.Point(6, 120);
            this.aProPrice.Name = "aProPrice";
            this.aProPrice.Size = new System.Drawing.Size(84, 23);
            this.aProPrice.TabIndex = 29;
            this.aProPrice.Text = "Product Price";
            // 
            // aProName
            // 
            this.aProName.Location = new System.Drawing.Point(6, 94);
            this.aProName.Name = "aProName";
            this.aProName.Size = new System.Drawing.Size(84, 23);
            this.aProName.TabIndex = 28;
            this.aProName.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 49);
            this.label1.TabIndex = 28;
            this.label1.Text = "Enter information to add new products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addProductsGroup
            // 
            this.addProductsGroup.Controls.Add(this.label1);
            this.addProductsGroup.Controls.Add(this.aProNum);
            this.addProductsGroup.Controls.Add(this.addProNumber);
            this.addProductsGroup.Controls.Add(this.aQuantity);
            this.addProductsGroup.Controls.Add(this.addQuantity);
            this.addProductsGroup.Controls.Add(this.aProPrice);
            this.addProductsGroup.Controls.Add(this.addProductPrice);
            this.addProductsGroup.Controls.Add(this.aProName);
            this.addProductsGroup.Controls.Add(this.addProductName);
            this.addProductsGroup.Location = new System.Drawing.Point(20, 9);
            this.addProductsGroup.Name = "addProductsGroup";
            this.addProductsGroup.Size = new System.Drawing.Size(229, 235);
            this.addProductsGroup.TabIndex = 32;
            this.addProductsGroup.TabStop = false;
            this.addProductsGroup.Text = "Add Products";
            this.addProductsGroup.Visible = false;
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(15, 256);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(76, 40);
            this.addProduct.TabIndex = 33;
            this.addProduct.Text = "Add Product";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 55);
            this.label2.TabIndex = 33;
            this.label2.Text = "Enter information of product you want remove";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Product Number";
            // 
            // removeProNumber
            // 
            this.removeProNumber.Location = new System.Drawing.Point(119, 77);
            this.removeProNumber.Name = "removeProNumber";
            this.removeProNumber.Size = new System.Drawing.Size(100, 20);
            this.removeProNumber.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "Product Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // removeProductName
            // 
            this.removeProductName.Location = new System.Drawing.Point(119, 106);
            this.removeProductName.Name = "removeProductName";
            this.removeProductName.Size = new System.Drawing.Size(100, 20);
            this.removeProductName.TabIndex = 1;
            this.removeProductName.TextChanged += new System.EventHandler(this.removeProductName_TextChanged);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(97, 256);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(76, 40);
            this.removeBtn.TabIndex = 34;
            this.removeBtn.Text = "Remove Product";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // removeProductsGroup
            // 
            this.removeProductsGroup.Controls.Add(this.label3);
            this.removeProductsGroup.Controls.Add(this.removeProNumber);
            this.removeProductsGroup.Controls.Add(this.label2);
            this.removeProductsGroup.Controls.Add(this.label4);
            this.removeProductsGroup.Controls.Add(this.removeProductName);
            this.removeProductsGroup.Location = new System.Drawing.Point(14, 12);
            this.removeProductsGroup.Name = "removeProductsGroup";
            this.removeProductsGroup.Size = new System.Drawing.Size(235, 238);
            this.removeProductsGroup.TabIndex = 38;
            this.removeProductsGroup.TabStop = false;
            this.removeProductsGroup.Text = "Remove Products";
            this.removeProductsGroup.Visible = false;
            // 
            // addingBtm
            // 
            this.addingBtm.Location = new System.Drawing.Point(15, 256);
            this.addingBtm.Name = "addingBtm";
            this.addingBtm.Size = new System.Drawing.Size(76, 40);
            this.addingBtm.TabIndex = 39;
            this.addingBtm.Text = "Add Product";
            this.addingBtm.UseVisualStyleBackColor = true;
            this.addingBtm.Visible = false;
            this.addingBtm.Click += new System.EventHandler(this.addingBtm_Click);
            // 
            // removingBtn
            // 
            this.removingBtn.Location = new System.Drawing.Point(97, 256);
            this.removingBtn.Name = "removingBtn";
            this.removingBtn.Size = new System.Drawing.Size(76, 40);
            this.removingBtn.TabIndex = 40;
            this.removingBtn.Text = "Remove Product";
            this.removingBtn.UseVisualStyleBackColor = true;
            this.removingBtn.Visible = false;
            this.removingBtn.Click += new System.EventHandler(this.removingBtn_Click);
            // 
            // updatingBtn
            // 
            this.updatingBtn.Location = new System.Drawing.Point(179, 256);
            this.updatingBtn.Name = "updatingBtn";
            this.updatingBtn.Size = new System.Drawing.Size(76, 40);
            this.updatingBtn.TabIndex = 41;
            this.updatingBtn.Text = "Update Product";
            this.updatingBtn.UseVisualStyleBackColor = true;
            this.updatingBtn.Visible = false;
            this.updatingBtn.Click += new System.EventHandler(this.updatingBtn_Click);
            // 
            // adminProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 306);
            this.Controls.Add(this.removeProductsGroup);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.addProductsGroup);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.updateProduct);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.updateProductGroup);
            this.Controls.Add(this.addingBtm);
            this.Controls.Add(this.removingBtn);
            this.Controls.Add(this.updatingBtn);
            this.Name = "adminProducts";
            this.Text = "adminProducts";
            this.updateProductGroup.ResumeLayout(false);
            this.updateProductGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            this.addProductsGroup.ResumeLayout(false);
            this.addProductsGroup.PerformLayout();
            this.removeProductsGroup.ResumeLayout(false);
            this.removeProductsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox updateProductGroup;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox uQuantity;
        public System.Windows.Forms.Label proQun;
        public System.Windows.Forms.TextBox uProductPrice;
        public System.Windows.Forms.TextBox uProductName;
        public System.Windows.Forms.Label uProPrice;
        public System.Windows.Forms.Label uProName;
        public System.Windows.Forms.Button updateProduct;
        private System.Windows.Forms.DataGridView productList;
        public System.Windows.Forms.TextBox searchId;
        public System.Windows.Forms.TextBox uProductNum;
        public System.Windows.Forms.Label ProNumber;
        public System.Windows.Forms.TextBox addProNumber;
        public System.Windows.Forms.TextBox addQuantity;
        public System.Windows.Forms.TextBox addProductPrice;
        public System.Windows.Forms.TextBox addProductName;
        public System.Windows.Forms.Label aProNum;
        public System.Windows.Forms.Label aQuantity;
        public System.Windows.Forms.Label aProPrice;
        public System.Windows.Forms.Label aProName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button addProduct;
        public System.Windows.Forms.GroupBox addProductsGroup;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox removeProNumber;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox removeProductName;
        public System.Windows.Forms.Button removeBtn;
        public System.Windows.Forms.GroupBox removeProductsGroup;
        public System.Windows.Forms.Button addingBtm;
        public System.Windows.Forms.Button removingBtn;
        public System.Windows.Forms.Button updatingBtn;
    }
}