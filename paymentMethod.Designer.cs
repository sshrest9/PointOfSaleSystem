namespace SqlDBClass
{
    partial class paymentMethod
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
            this.cash = new System.Windows.Forms.Button();
            this.amtLable = new System.Windows.Forms.Label();
            this.cashAmount = new System.Windows.Forms.TextBox();
            this.cashMethod = new System.Windows.Forms.GroupBox();
            this.cashMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // cash
            // 
            this.cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.Location = new System.Drawing.Point(12, 25);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(102, 48);
            this.cash.TabIndex = 0;
            this.cash.Text = "Cash";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.Click += new System.EventHandler(this.cash_Click);
            // 
            // amtLable
            // 
            this.amtLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtLable.Location = new System.Drawing.Point(10, 13);
            this.amtLable.Name = "amtLable";
            this.amtLable.Size = new System.Drawing.Size(153, 25);
            this.amtLable.TabIndex = 2;
            this.amtLable.Text = "Enter cash amount:";
            // 
            // cashAmount
            // 
            this.cashAmount.Location = new System.Drawing.Point(25, 41);
            this.cashAmount.Name = "cashAmount";
            this.cashAmount.Size = new System.Drawing.Size(109, 20);
            this.cashAmount.TabIndex = 1;
            this.cashAmount.TextChanged += new System.EventHandler(this.cashAmount_TextChanged);
            this.cashAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashAmount_KeyDown);
            this.cashAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cashAmount_KeyPress);
            // 
            // cashMethod
            // 
            this.cashMethod.Controls.Add(this.amtLable);
            this.cashMethod.Controls.Add(this.cashAmount);
            this.cashMethod.Location = new System.Drawing.Point(145, 12);
            this.cashMethod.Name = "cashMethod";
            this.cashMethod.Size = new System.Drawing.Size(190, 70);
            this.cashMethod.TabIndex = 3;
            this.cashMethod.TabStop = false;
            this.cashMethod.Text = "Cash Method";
            this.cashMethod.Visible = false;
            // 
            // paymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 102);
            this.Controls.Add(this.cashMethod);
            this.Controls.Add(this.cash);
            this.Name = "paymentMethod";
            this.Text = "paymentMethod";
            this.cashMethod.ResumeLayout(false);
            this.cashMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cash;
        private System.Windows.Forms.Label amtLable;
        private System.Windows.Forms.TextBox cashAmount;
        private System.Windows.Forms.GroupBox cashMethod;
    }
}