using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Shusen Shrestha

namespace SqlDBClass
{
    public partial class Products : Form
    {
        //Declaring variables needed for the form and SQL connections
        Form1 form1;
        SQLDBClass con;
        //initialization of the form and connection for SQL and Form1
        public Products(Form1 form_1)
        {
            InitializeComponent();
            form1 = form_1;
            con = new SQLDBClass();
        }
        //Displays the products information depending on the button that is pressed.
        //It will display in Form1 and close after the button has been clicked;
        //********************************************************************************
        //All methods from here call the getInfo function so it know which information it need to retrive from the database
        //Dept 65
        private void apple_Click(object sender, EventArgs e)
        {
            produceItems pro = new produceItems(form1,this);
            pro.Show();
        }
        //Dept 68
        private void dairy_Click(object sender, EventArgs e)
        {
            dairyItems dai = new dairyItems(form1, this);
            dai.Show();
        }
        //Dept 35
        private void meat_Click(object sender, EventArgs e)
        {
            Meat met = new Meat(form1, this);
            met.Show();
        }
        //Dept 33
        private void baking_Click(object sender, EventArgs e)
        {
            Baking bake = new Baking(form1, this);
            bake.Show();
        }
        //Dept 29
        private void drinks_Click(object sender, EventArgs e)
        {
            Drinks drink = new Drinks(form1, this);
            drink.Show();
        }
        private void household_Click(object sender, EventArgs e)
        {
            household house = new household(form1,this);
            house.Show();
        }
        //End of Comments
        //********************************************************************************

    }
}

