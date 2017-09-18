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
    public partial class Meat : Form
    {
        Form1 form1;
        Products prod;
        SQLDBClass con;
        int quntityAmount;

        public Meat(Form1 frm, Products pro)
        {
            InitializeComponent();
            con = new SQLDBClass();
            form1 = frm;
            prod = pro;
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

        private void chickenB_Click(object sender, EventArgs e)
        {
            getInfo("Chicken Breast");

        }

        private void chickenL_Click(object sender, EventArgs e)
        {
            getInfo("Chicken Leg");

        }

        private void chickenW_Click(object sender, EventArgs e)
        {
            getInfo("Whole Chicken");

        }

        private void chickenLiv_Click(object sender, EventArgs e)
        {
            getInfo("Chicken Liver");

        }

        private void turkey_Click(object sender, EventArgs e)
        {
            getInfo("Turkey");

        }

        private void duck_Click(object sender, EventArgs e)
        {
            getInfo("Duck");

        }

        private void goat_Click(object sender, EventArgs e)
        {
            getInfo("Goat");

        }

        private void lamb_Click(object sender, EventArgs e)
        {
            getInfo("Lamb");

        }

        private void porkR_Click(object sender, EventArgs e)
        {
            getInfo("Pork Ribs");

        }

        private void bacon_Click(object sender, EventArgs e)
        {
            getInfo("Bacon");

        }

        private void beef_Click(object sender, EventArgs e)
        {
            getInfo("Beef");

        }

        private void beefLiv_Click(object sender, EventArgs e)
        {
            getInfo("Beef Liver");

        }
    }
}
