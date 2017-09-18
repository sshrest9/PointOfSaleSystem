namespace SqlDBClass
{
    partial class household
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
            this.Coke = new System.Windows.Forms.Button();
            this.foodWrap = new System.Windows.Forms.Button();
            this.DishSope = new System.Windows.Forms.Button();
            this.paperTowel = new System.Windows.Forms.Button();
            this.laundryDete = new System.Windows.Forms.Button();
            this.tolitPaper = new System.Windows.Forms.Button();
            this.plasticPlate = new System.Windows.Forms.Button();
            this.pSpoon = new System.Windows.Forms.Button();
            this.pCups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Coke
            // 
            this.Coke.Location = new System.Drawing.Point(12, 96);
            this.Coke.Name = "Coke";
            this.Coke.Size = new System.Drawing.Size(90, 36);
            this.Coke.TabIndex = 2;
            this.Coke.Text = "Foil Sheets";
            this.Coke.UseVisualStyleBackColor = true;
            this.Coke.Click += new System.EventHandler(this.Coke_Click);
            // 
            // foodWrap
            // 
            this.foodWrap.Location = new System.Drawing.Point(12, 54);
            this.foodWrap.Name = "foodWrap";
            this.foodWrap.Size = new System.Drawing.Size(90, 36);
            this.foodWrap.TabIndex = 3;
            this.foodWrap.Text = "Food Wrap";
            this.foodWrap.UseVisualStyleBackColor = true;
            this.foodWrap.Click += new System.EventHandler(this.foodWrap_Click);
            // 
            // DishSope
            // 
            this.DishSope.Location = new System.Drawing.Point(12, 12);
            this.DishSope.Name = "DishSope";
            this.DishSope.Size = new System.Drawing.Size(90, 36);
            this.DishSope.TabIndex = 4;
            this.DishSope.Text = "Dishwasher Soap";
            this.DishSope.UseVisualStyleBackColor = true;
            this.DishSope.Click += new System.EventHandler(this.DishSope_Click);
            // 
            // paperTowel
            // 
            this.paperTowel.Location = new System.Drawing.Point(108, 54);
            this.paperTowel.Name = "paperTowel";
            this.paperTowel.Size = new System.Drawing.Size(90, 36);
            this.paperTowel.TabIndex = 5;
            this.paperTowel.Text = "Paper Towel";
            this.paperTowel.UseVisualStyleBackColor = true;
            this.paperTowel.Click += new System.EventHandler(this.paperTowel_Click);
            // 
            // laundryDete
            // 
            this.laundryDete.Location = new System.Drawing.Point(108, 12);
            this.laundryDete.Name = "laundryDete";
            this.laundryDete.Size = new System.Drawing.Size(90, 36);
            this.laundryDete.TabIndex = 6;
            this.laundryDete.Text = "Laundry Detergent";
            this.laundryDete.UseVisualStyleBackColor = true;
            this.laundryDete.Click += new System.EventHandler(this.laundryDete_Click);
            // 
            // tolitPaper
            // 
            this.tolitPaper.Location = new System.Drawing.Point(108, 96);
            this.tolitPaper.Name = "tolitPaper";
            this.tolitPaper.Size = new System.Drawing.Size(90, 36);
            this.tolitPaper.TabIndex = 7;
            this.tolitPaper.Text = "Toilet Paper";
            this.tolitPaper.UseVisualStyleBackColor = true;
            this.tolitPaper.Click += new System.EventHandler(this.tolitPaper_Click);
            // 
            // plasticPlate
            // 
            this.plasticPlate.Location = new System.Drawing.Point(204, 12);
            this.plasticPlate.Name = "plasticPlate";
            this.plasticPlate.Size = new System.Drawing.Size(90, 36);
            this.plasticPlate.TabIndex = 8;
            this.plasticPlate.Text = "Plastic Plate";
            this.plasticPlate.UseVisualStyleBackColor = true;
            this.plasticPlate.Click += new System.EventHandler(this.plasticPlate_Click);
            // 
            // pSpoon
            // 
            this.pSpoon.Location = new System.Drawing.Point(204, 54);
            this.pSpoon.Name = "pSpoon";
            this.pSpoon.Size = new System.Drawing.Size(90, 36);
            this.pSpoon.TabIndex = 9;
            this.pSpoon.Text = "Plastic Spoon";
            this.pSpoon.UseVisualStyleBackColor = true;
            this.pSpoon.Click += new System.EventHandler(this.pSpoon_Click);
            // 
            // pCups
            // 
            this.pCups.Location = new System.Drawing.Point(204, 96);
            this.pCups.Name = "pCups";
            this.pCups.Size = new System.Drawing.Size(90, 36);
            this.pCups.TabIndex = 10;
            this.pCups.Text = "Plastic Cups";
            this.pCups.UseVisualStyleBackColor = true;
            this.pCups.Click += new System.EventHandler(this.pCups_Click);
            // 
            // household
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 140);
            this.Controls.Add(this.pCups);
            this.Controls.Add(this.pSpoon);
            this.Controls.Add(this.plasticPlate);
            this.Controls.Add(this.tolitPaper);
            this.Controls.Add(this.laundryDete);
            this.Controls.Add(this.paperTowel);
            this.Controls.Add(this.DishSope);
            this.Controls.Add(this.foodWrap);
            this.Controls.Add(this.Coke);
            this.Name = "household";
            this.Text = "household";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Coke;
        private System.Windows.Forms.Button foodWrap;
        private System.Windows.Forms.Button DishSope;
        private System.Windows.Forms.Button paperTowel;
        private System.Windows.Forms.Button laundryDete;
        private System.Windows.Forms.Button tolitPaper;
        private System.Windows.Forms.Button plasticPlate;
        private System.Windows.Forms.Button pSpoon;
        private System.Windows.Forms.Button pCups;
    }
}