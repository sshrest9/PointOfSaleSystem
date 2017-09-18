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
    public partial class Drinks : Form
    {
        SQLDBClass con;
        Form1 form1;
        Products prod;
        int quntityAmount;

        public Drinks(Form1 frm,Products pro)
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

        private void Drinks_Load(object sender, EventArgs e)
        {

        }

        private void Coke_Click(object sender, EventArgs e)
        {
            getInfo("Coke");
        }

        private void crush_Click(object sender, EventArgs e)
        {
            getInfo("Crush");
        }

        private void canadaDry_Click(object sender, EventArgs e)
        {
            getInfo("Canada Dry");
        }

        private void rootBeer_Click(object sender, EventArgs e)
        {
            getInfo("Root Beer");

        }

        private void dCoke_Click(object sender, EventArgs e)
        {
            getInfo("Diet Coke");

        }

        private void sprite_Click(object sender, EventArgs e)
        {
            getInfo("Sprite");

        }

        private void mountainDew_Click(object sender, EventArgs e)
        {
            getInfo("Mountain Dew");

        }

        private void pepsi_Click(object sender, EventArgs e)
        {
            getInfo("Pepsi");

        }

        private void drPep_Click(object sender, EventArgs e)
        {
            getInfo("Dr.Pepper");

        }

        private void sevenUp_Click(object sender, EventArgs e)
        {
            getInfo("7Up");

        }

        private void orangeJuice_Click(object sender, EventArgs e)
        {
            getInfo("Orange Juice");

        }

        private void lJuice_Click(object sender, EventArgs e)
        {
            getInfo("Lemon Juice");

        }

        private void manJuice_Click(object sender, EventArgs e)
        {
            getInfo("Mango Juice");

        }

        private void appleJuice_Click(object sender, EventArgs e)
        {
            getInfo("Apple Juice");

        }

        private void lycheeJuice_Click(object sender, EventArgs e)
        {
            getInfo("Lychee Juice");

        }

        private void coffee_Click(object sender, EventArgs e)
        {
            getInfo("Coffee");

        }

        private void tea_Click(object sender, EventArgs e)
        {
            getInfo("Tea");

        }

        private void water_Click(object sender, EventArgs e)
        {
            getInfo("Water");

        }
    }
}
