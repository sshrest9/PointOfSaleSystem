using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlDBClass
{
    public partial class dairyItems : Form
    {
        Form1 form1;
        Products prod;
        SQLDBClass con;
        int quntityAmount;

        public dairyItems(Form1 frm, Products pro)
        {
            InitializeComponent();
            form1 = frm;
            prod = pro;
            con = new SQLDBClass();
        }
        private void getInfo(string name)
        {
            con.SqlQuery("SELECT * FROM itemList where Name='" + name + "'");
            foreach (DataRow dr in con.QueryExeute().Rows)
            {
                form1.listBox1.Items.Add(dr[1].ToString());
                form1.listBox2.Items.Add(dr[2].ToString());
                form1.listBox3.Items.Add(dr[3].ToString());
                form1.counter++;
                quntityAmount = (int)dr[4];

            }
            quntityAmount--;
            form1.quantity.Add(quntityAmount);

            con.SqlQuery("UPDATE itemList SET Quantity=@Qun WHERE Name='" + name + "'");
            con._cmd.Parameters.AddWithValue("@Qun", quntityAmount);
            con.NonQueryExeute();
            this.Close();
            prod.Close();
        }

        private void milkTwoPer_Click(object sender, EventArgs e)
        {
            getInfo("2% Milk");

        }

        private void MilkThreePer_Click(object sender, EventArgs e)
        {
            getInfo("3% Milk");

        }

        private void skimMilk_Click(object sender, EventArgs e)
        {
            getInfo("Skim Milk");

        }

        private void butter_Click(object sender, EventArgs e)
        {
            getInfo("Butter");

        }

        private void margarine_Click(object sender, EventArgs e)
        {
            getInfo("Margarine");

        }

        private void yoghurt_Click(object sender, EventArgs e)
        {
            getInfo("Yogurth");

        }

        private void cCheese_Click(object sender, EventArgs e)
        {
            getInfo("Cottage Cheese");

        }

        private void sCheese_Click(object sender, EventArgs e)
        {
            getInfo("Swiss Cheese");

        }

        private void cheddarCheese_Click(object sender, EventArgs e)
        {
            getInfo("Cheddar Cheese");

        }

        private void goudaCheese_Click(object sender, EventArgs e)
        {
            getInfo("Gouda Cheese");

        }

        private void pepperJack_Click(object sender, EventArgs e)
        {
            getInfo("Pepper Jack Cheese");

        }

        private void mayonnaise_Click(object sender, EventArgs e)
        {
            getInfo("Mayonnise");

        }

        private void iceCream_Click(object sender, EventArgs e)
        {
            getInfo("Ice Cream");

        }

        private void cream_Click(object sender, EventArgs e)
        {
            getInfo("Cream");

        }

        private void eggs_Click(object sender, EventArgs e)
        {
            getInfo("Eggs");

        }
    }
}
