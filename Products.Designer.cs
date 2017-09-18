namespace SqlDBClass
{
    partial class Products
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
            this.produce = new System.Windows.Forms.Button();
            this.dairy = new System.Windows.Forms.Button();
            this.meat = new System.Windows.Forms.Button();
            this.baking = new System.Windows.Forms.Button();
            this.drinks = new System.Windows.Forms.Button();
            this.household = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // produce
            // 
            this.produce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produce.Location = new System.Drawing.Point(12, 12);
            this.produce.Name = "produce";
            this.produce.Size = new System.Drawing.Size(118, 57);
            this.produce.TabIndex = 0;
            this.produce.Text = "Produce";
            this.produce.UseVisualStyleBackColor = true;
            this.produce.Click += new System.EventHandler(this.apple_Click);
            // 
            // dairy
            // 
            this.dairy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dairy.Location = new System.Drawing.Point(12, 75);
            this.dairy.Name = "dairy";
            this.dairy.Size = new System.Drawing.Size(118, 57);
            this.dairy.TabIndex = 10;
            this.dairy.Text = "Dairy";
            this.dairy.UseVisualStyleBackColor = true;
            this.dairy.Click += new System.EventHandler(this.dairy_Click);
            // 
            // meat
            // 
            this.meat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meat.Location = new System.Drawing.Point(158, 12);
            this.meat.Name = "meat";
            this.meat.Size = new System.Drawing.Size(118, 57);
            this.meat.TabIndex = 11;
            this.meat.Text = "Meat";
            this.meat.UseVisualStyleBackColor = true;
            this.meat.Click += new System.EventHandler(this.meat_Click);
            // 
            // baking
            // 
            this.baking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baking.Location = new System.Drawing.Point(158, 75);
            this.baking.Name = "baking";
            this.baking.Size = new System.Drawing.Size(118, 57);
            this.baking.TabIndex = 12;
            this.baking.Text = "Bakery";
            this.baking.UseVisualStyleBackColor = true;
            this.baking.Click += new System.EventHandler(this.baking_Click);
            // 
            // drinks
            // 
            this.drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinks.Location = new System.Drawing.Point(12, 138);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(118, 57);
            this.drinks.TabIndex = 13;
            this.drinks.Text = "Beverages";
            this.drinks.UseVisualStyleBackColor = true;
            this.drinks.Click += new System.EventHandler(this.drinks_Click);
            // 
            // household
            // 
            this.household.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.household.Location = new System.Drawing.Point(158, 138);
            this.household.Name = "household";
            this.household.Size = new System.Drawing.Size(118, 57);
            this.household.TabIndex = 14;
            this.household.Text = "Household";
            this.household.UseVisualStyleBackColor = true;
            this.household.Click += new System.EventHandler(this.household_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 205);
            this.Controls.Add(this.household);
            this.Controls.Add(this.drinks);
            this.Controls.Add(this.baking);
            this.Controls.Add(this.meat);
            this.Controls.Add(this.dairy);
            this.Controls.Add(this.produce);
            this.Name = "Products";
            this.Text = "Products";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button produce;
        private System.Windows.Forms.Button dairy;
        private System.Windows.Forms.Button meat;
        private System.Windows.Forms.Button baking;
        private System.Windows.Forms.Button drinks;
        private System.Windows.Forms.Button household;
    }
}