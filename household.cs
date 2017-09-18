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
    public partial class household : Form
    {
        Form1 form1;
        Products prod;
        SQLDBClass con;
        int quntityAmount;

        public household(Form1 form,Products pro)
        {
            InitializeComponent();
            form1 = form;
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

        private void DishSope_Click(object sender, EventArgs e)
        {
            getInfo("Dishwasher Soap");

        }

        private void foodWrap_Click(object sender, EventArgs e)
        {
            getInfo("Food Wrap");

        }

        private void Coke_Click(object sender, EventArgs e)
        {
            getInfo("Foil Sheets");

        }

        private void laundryDete_Click(object sender, EventArgs e)
        {
            getInfo("Laundry Detergent");

        }

        private void paperTowel_Click(object sender, EventArgs e)
        {
            getInfo("Paper Towel");

        }

        private void tolitPaper_Click(object sender, EventArgs e)
        {
            getInfo("Toilet Paper");

        }

        private void plasticPlate_Click(object sender, EventArgs e)
        {
            getInfo("Plastic Plate");

        }

        private void pSpoon_Click(object sender, EventArgs e)
        {
            getInfo("Plastic Spoon");

        }

        private void pCups_Click(object sender, EventArgs e)
        {
            getInfo("Plastic Cups");

        }
    }
}
