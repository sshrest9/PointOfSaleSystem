namespace SqlDBClass
{
    partial class Form1
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
            this.Show = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Button();
            this.subTotal = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.finalTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.paymentMethod = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCashAmt = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(15, 152);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(119, 49);
            this.Show.TabIndex = 6;
            this.Show.Text = "PRODUCTS";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(107, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product Number";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(274, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(108, 225);
            this.listBox1.TabIndex = 17;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(381, 56);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(98, 225);
            this.listBox2.TabIndex = 18;
            this.listBox2.TabStop = false;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(478, 57);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(99, 225);
            this.listBox3.TabIndex = 19;
            this.listBox3.TabStop = false;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(140, 97);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(119, 49);
            this.add.TabIndex = 5;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(15, 97);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(119, 49);
            this.Search.TabIndex = 4;
            this.Search.Text = "SEARCH";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(140, 152);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(119, 49);
            this.total.TabIndex = 24;
            this.total.Text = "TOTAL";
            this.total.UseVisualStyleBackColor = true;
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // subTotal
            // 
            this.subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal.Location = new System.Drawing.Point(377, 302);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(95, 38);
            this.subTotal.TabIndex = 25;
            // 
            // Tax
            // 
            this.Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax.Location = new System.Drawing.Point(377, 325);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(95, 38);
            this.Tax.TabIndex = 26;
            this.Tax.Click += new System.EventHandler(this.Tax_Click);
            // 
            // finalTotal
            // 
            this.finalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalTotal.Location = new System.Drawing.Point(377, 348);
            this.finalTotal.Name = "finalTotal";
            this.finalTotal.Size = new System.Drawing.Size(95, 38);
            this.finalTotal.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 38);
            this.label4.TabIndex = 28;
            this.label4.Text = "Sub Total:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 38);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tax:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 38);
            this.label6.TabIndex = 30;
            this.label6.Text = "Total:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 49);
            this.button2.TabIndex = 31;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(271, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "Product Name";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(377, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 33;
            this.label8.Text = "Price";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(478, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Product Number";
            // 
            // paymentMethod
            // 
            this.paymentMethod.Location = new System.Drawing.Point(140, 207);
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Size = new System.Drawing.Size(119, 49);
            this.paymentMethod.TabIndex = 35;
            this.paymentMethod.Text = "PAYMENT METHOD";
            this.paymentMethod.UseVisualStyleBackColor = true;
            this.paymentMethod.Visible = false;
            this.paymentMethod.Click += new System.EventHandler(this.paymentMethod_Click);
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(12, 373);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(119, 49);
            this.logOut.TabIndex = 38;
            this.logOut.Text = "LOGOUT";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 25);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Change:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(441, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 46);
            this.label10.TabIndex = 41;
            this.label10.Text = "Cash Amount:";
            // 
            // txtCashAmt
            // 
            this.txtCashAmt.Location = new System.Drawing.Point(523, 306);
            this.txtCashAmt.Name = "txtCashAmt";
            this.txtCashAmt.Size = new System.Drawing.Size(54, 20);
            this.txtCashAmt.TabIndex = 42;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(523, 350);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(54, 20);
            this.txtChange.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(510, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "$";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(510, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 424);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtCashAmt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.paymentMethod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.finalTotal);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.total);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Cash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ListBox listBox2;
        public System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button paymentMethod;
        private System.Windows.Forms.Button logOut;
        public System.Windows.Forms.Label subTotal;
        public System.Windows.Forms.Label Tax;
        public System.Windows.Forms.Label finalTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtCashAmt;
        public System.Windows.Forms.TextBox txtChange;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
    }
}

